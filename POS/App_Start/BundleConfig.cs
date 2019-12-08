using System.Web;
using System.Web.Optimization;

namespace POS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
              "~/Scripts/angular.js",
              "~/Scripts/angular-material.js",
              "~/Scripts/angular-animate.js",
              "~/Scripts/angular-aria.js"));
            bundles.Add(new ScriptBundle("~/bundles/CustAng").Include("~/ANG_POS_Service/*.js","~/Ang_POS/*.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/baseCss").Include(
                      "~/Content/bootstrap.css","~/Content/site.css", "~/Content/angular-material.css", "~/css/font-awesome.css"));
        }
    }
}
