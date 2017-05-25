using System.Web;
using System.Web.Optimization;

namespace BabyShop
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/fancySelect.css",
                                    "~/Content/uniform.css",
                                    "~/Content/jquery.bxslider.css",
                                    "~/Content/jquery-ui-1.10.4.custom.css",
                                    "~/Content/all.css"));

            bundles.Add(new ScriptBundle("~/Scripts/js").Include("~/Scripts/jcarousellite.js",
                            "~/Scripts/jquery.placeholder.js",
                            "~/Scripts/jquery.uniform.min.js",
                            "~/Scripts/fancySelect.js",
                            "~/Scripts/jquery.bxslider.js",
                            "~/Scripts/jquery-ui-1.10.4.custom.js",
                            "~/Scripts/main.js"));
        }
    }
}
