using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ayobeli_asp
{
				public class BundleConfig
				{
								public static void RegisterBundles(BundleCollection bundles)
								{
												bundles.Add(new ScriptBundle("~/bundles/jquery-w-bootstrap")
																.Include("~/Scripts/jquery-3.0.0.min.js",
																"~/Scripts/umd/popper.min.js",
																"~/Scripts/bootstrap.min.js"));

												bundles.Add(new ScriptBundle("~/bundles/jquery-validate")
																.Include("~/Scripts/jquery-3.0.0.min.js",
																"~/Scripts/jquery.validate.min.js",
																"~/Scripts/jquery.validate.unobtrusive.min.js"));
												
												bundles.Add(new StyleBundle("~/content/site")
																.Include("~/Content/Site.css", "~/Content/bootstrap.min.css"));
								}
				}
}