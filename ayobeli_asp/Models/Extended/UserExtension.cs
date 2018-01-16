using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ayobeli_asp.Models
{
				[MetadataType(typeof(UserMetaData))]
				public partial class User
				{
								public string ConfirmPassword { get; set; }
				}

				public class UserMetaData
				{
								[Display(Name = "Name")]
								[Required(AllowEmptyStrings = false, ErrorMessage = "* Nama harus diisi")]
								public string Name { get; set; }

								[Display(Name = "Email")]
								[Required(AllowEmptyStrings = false, ErrorMessage = "* Email harus diisi dan valid")]
								[DataType(DataType.EmailAddress)]
								public string Email { get; set; }

								[Display(Name = "Password")]
								[Required(AllowEmptyStrings = false, ErrorMessage = "* Password harus diisi")]
								[DataType(DataType.Password)]
								[MinLength(8, ErrorMessage = "* Password harus memiliki 8 karakter")]
								public string Password { get; set; }

								[System.ComponentModel.DataAnnotations.Schema.NotMapped]
								[Display(Name = "Confirm Password")]
								[DataType(DataType.Password)]
								[Compare("Password", ErrorMessage = "* Password tidak cocok")]
								public string ConfirmPassword { get; set; }
								
								public string Sex { get; set; }
				}
}