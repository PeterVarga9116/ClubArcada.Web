using System.Web.Optimization;

namespace ClubArcada.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/materialize/materialize.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/slippry.js",
                      "~/Scripts/app.js",
                      "~/Scripts/site.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/slippry.css",
                      "~/Content/materialize/css/materialize.css",
                      "~/Content/site.css"));
        }
    }
}