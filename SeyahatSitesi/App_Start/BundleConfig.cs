using System.Web;
using System.Web.Optimization;

namespace SeyahatSitesi
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
               .Include("~/plugins/jquery/jquery.min.js",
                        "~/plugins/bootstrap/js/bootstrap.bundle.min.js",
                        "~/dist/js/adminlte.min.js"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/plugins/font-awesome/css/font-awesome.min.css",
                         "~/dist/css/adminlte.min.css"));
        }
    }
}
