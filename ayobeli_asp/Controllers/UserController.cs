using System;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using CustomSecurity;
using System.Net.Mail;
using System.Net;
using ayobeli_asp.Models;

namespace ayobeli_asp.Controllers
{
    public class UserController : Controller
    {

								public ActionResult Register()
								{
												return View();
								}

								[HttpPost]
								[ValidateAntiForgeryToken]
								public ActionResult Register([Bind(Exclude = "isEmailVerified, Activation")] User user)
        {
												if (ModelState.IsValid)
												{
																if (IsEmailExist(user.Email))
																{
																				ModelState.AddModelError("Email", "* alamat email sudah terdaftar");
																				return View(user);
																}

																// fill user data
																user.Activation = Guid.NewGuid();
																user.Password = Security.GetHashedSensitive(user.Password);
																user.ConfirmPassword = user.Password;
																user.Role = "normal";
																user.Verified = false;
															
																// save user to db
																var db = new AyobeliDBEntities();
																db.Users.Add(user);
																// db.Configuration.ValidateOnSaveEnabled = false
																db.SaveChanges();
																SendVerificationEmailLink(user.Email, user.Activation.ToString());

																ViewBag.CoreMessage = StringResource.RegisterSuccessTopMessage;
																ViewBag.SupplementaryMessage = StringResource.RegisterSuccessExplanation;
																return View("Success");
												}

												return View(user);
								}
								public ActionResult Success()
								{
												return View();
								}

								[HttpGet]
								public ActionResult VerifyAccount(string id)
								{
												bool isValidRequest = false;
												using (AyobeliDBEntities db = new AyobeliDBEntities())
												{
																var user = db.Users.Where(u => u.Activation == new Guid(id)).FirstOrDefault();
																if (user != null)
																{
																				user.Verified = true;
																				user.Activation = null;
																				isValidRequest = true;
																				db.SaveChanges();
																}
												}
												
												return View();
								}

								[HttpPost]
								[ValidateAntiForgeryToken]
								public ActionResult Login()
								{
												return View();
								}

								[NonAction]
								private bool IsEmailExist(string email)
								{
												AyobeliDBEntities db = new AyobeliDBEntities();
												var user = db.Users.Where(u => u.Email == email).FirstOrDefault();
												return user != null;
								}

								[NonAction]
								private void SendVerificationEmailLink(string userEmail, string activationCode)
								{
												string verifyUrl = "/User/VerifyAccount/" + activationCode;
												string link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifyUrl);

												var AyoBeliEmail = new MailAddress(StringResource.EmailAccount, "AyoBeli");
												var AyoBeliPassword = StringResource.EmailPassword;

												var receiver = new MailAddress(userEmail);
												string subject = StringResource.VerifyEmailSubject;
												string body = String.Format(StringResource.VerifyEmailBody, link);

												var emailClient = new SmtpClient
												{
																Host = "smtp.gmail.com",
																Port = 587,
																EnableSsl = true,
																DeliveryMethod = SmtpDeliveryMethod.Network,
																UseDefaultCredentials = false,
																Credentials = new NetworkCredential(AyoBeliEmail.Address, AyoBeliPassword)
												};

												using (var message = new MailMessage(AyoBeliEmail, receiver)
												{
																Subject = subject,
																Body = body,
																IsBodyHtml = true
												})
												emailClient.Send(message);
								}
    }
}