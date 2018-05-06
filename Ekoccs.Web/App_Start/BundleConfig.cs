using System.Web.Optimization;

namespace Ekoccs.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/Css").Include(
                "~/Content/css/style.default.css"));

            bundles.Add(new ScriptBundle("~/Content/JS").Include(
                "~/Content/js/jquery-1.12.4.js",
                "~/Content/js/jquery-migrate-1.2.1.min.js",
                "~/Content/js/jquery-ui.js",
                "~/Content/js/bootstrap.min.js",
                "~/Content/js/modernizr.min.js",
                "~/Content/js/jquery.sparkline.min.js",
                "~/Content/js/toggles.min.js",
                "~/Content/js/retina.min.js",
                "~/Content/js/jquery.cookies.js",
                "~/Content/js/custom.js",
                "~/Content/js/datatables.min.js",
                "~/Content/js/jquery.maskedinput.min.js",
                "~/Content/js/jquery.gritter.min.js",
                "~/Content/js/toastr.js",
                "~/Content/js/jquery.datetimepicker.js"));
            bundles.Add(new ScriptBundle("~/Content/angularJS").Include(
                     "~/Content/js/angular.js"));
            bundles.Add(new ScriptBundle("~/Content/CustomerJS").Include(
                     "~/Content/Scripts/Module.js",
                     "~/Content/Scripts/Service.js",
                     "~/Content/Scripts/Controller.js"));
            //bundles.Add(new ScriptBundle("~/Content/CustomJS").Include(
            //         "~/Scripts/angular.js"));
            // BundleTable.EnableOptimizations = true;
        }
    }
}