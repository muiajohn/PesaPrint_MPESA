using System.Web.Optimization;

namespace PesaPrint.MPESA
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // App Styles
            bundles.Add(new StyleBundle("~/Content/appCss").Include(
                "~/Content/app/css/app.css"
            ));

            // Bootstrap Styles
            bundles.Add(new StyleBundle("~/Content/bootstrapCss").Include(
                "~/Content/app/css/bootstrap.css", new CssRewriteUrlTransform()
            ));


            bundles.Add(new ScriptBundle("~/bundles/Angle").Include(
                // App init
                "~/Scripts/app/app.init.js",
                // Modules
                "~/Scripts/app/modules/bootstrap-start.js",
                "~/Scripts/app/modules/clear-storage.js",
                "~/Scripts/app/modules/constants.js",
                "~/Scripts/app/modules/localize.js",
                "~/Scripts/app/modules/navbar-search.js",
                "~/Scripts/app/modules/sidebar.js",
                "~/Scripts/app/modules/toggle-state.js",
                "~/Scripts/app/modules/utils.js"
            ));

            // Main Vendor

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.1.4.js"
            ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            // Vendor Plugins

            bundles.Add(new StyleBundle("~/bundles/simpleLineIcons").Include(
              "~/Vendor/simple-line-icons/css/simple-line-icons.css", new CssRewriteUrlTransform()
            ));


            bundles.Add(new ScriptBundle("~/bundles/storage").Include(
              "~/Vendor/jQuery-Storage-API/jquery.storageapi.js"
            ));

            bundles.Add(new StyleBundle("~/bundles/whirl").Include(
              "~/Vendor/whirl/dist/whirl.css"
            ));

            bundles.Add(new StyleBundle("~/bundles/fontawesome").Include(
              "~/Vendor/fontawesome/css/font-awesome.min.css", new CssRewriteUrlTransform()
            ));

            bundles.Add(new StyleBundle("~/bundles/animatecss").Include(
              "~/Vendor/animate.css/animate.min.css"
            ));

            bundles.Add(new ScriptBundle("~/bundles/localize").Include(
              "~/Vendor/jquery-localize-i18n/dist/jquery.localize.js"
            ));



            //LandingPage 
            bundles.Add(new StyleBundle("~/bundles/preloadercs").Include(
            "~/Vendor/nprogress/nprogress.css"
          ));
            bundles.Add(new ScriptBundle("~/bundles/preloaderjs").Include(
              "~/Vendor/nprogress/nprogress.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jquerybrowser").Include(
           "~/Vendor/jquery.browser/dist/jquery.browser.js"
         ));


             bundles.Add(new StyleBundle("~/bundles/vendorcss").Include(
              "~/Vendor/owl.carousel/dist/assets/owl.carousel.css",
              "~/Vendor/owl.carousel/dist/assets/owl.theme.default.css",
              "~/Vendor/Nivo-Lightbox/nivo-lightbox.css",
              "~/Vendor/Nivo-Lightbox/themes/default/default.css",
              "~/Vendor/animate.css/animate.css"
            ));

             bundles.Add(new StyleBundle("~/bundles/landingcss").Include(
               "~/Content/app/css/styles.css",
               "~/Content/app/css/theme-a.css"
             ));


             bundles.Add(new ScriptBundle("~/bundles/vendorjs").Include(
              "~/Vendor/waitForImages/dist/jquery.waitforimages.min.js",
              "~/Vendor/smoothscroll/smoothscroll.js",
              "~/Vendor/owl.carousel/dist/owl.carousel.js",
              "~/Vendor/Nivo-Lightbox/nivo-lightbox.js",
              "~/Vendor/html5shiv/dist/html5shiv.js",
              "~/Vendor/respond/src/respond.js",
              "~/Vendor/retina.js/dist/retina.js",
              "~/Vendor/jquery.scrollTo/jquery.scrollTo.js",
              "~/Vendor/wow/dist/wow.js",
              "~/Vendor/matchMedia/matchMedia.js",
              "~/Vendor/background-video/jquery.backgroundvideo.js",
              "~/Vendor/jQuery-One-Page-Nav/jquery.nav.js",
              "~/Vendor/jQuery-Storage-API/jquery.storageapi.js",
              "~/Vendor/jQuery-Storage-API/jquery.storageapi.js",
                 "~/Scripts/app/landing.js"
            ));
            

            bundles.Add(new ScriptBundle("~/bundles/jqueryeasing").Include(
                 "~/Vendor/jquery.easing/js/jquery.easing.js"
                ));


            //KENDO UI
            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
            "~/Vendor/kendo/js/kendo.all.min.js",
            "~/Vendor/kendo/js/kendo.aspnetmvc.min.js",
            "~/Vendor/kendo/js/kendo.timezones.min.js"));


            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
                        "~/Vendor/kendo/css/web/kendo.common.min.css",
                        "~/Vendor/kendo/css/web/kendo.rtl.min.css",
                        "~/Vendor/kendo/css/web/kendo.default.min.css",
                        "~/Venndor/kendo/css/web/kendo.default.mobile.min.css",
                        "~/Vendor/kendo/css/dataviz/kendo.dataviz.min.css",
                        "~/Vendor/kendo/css/dataviz/kendo.dataviz.default.min.css",
                        "~/Vendor/kendo/css/mobile/kendo.mobile.all.min.css"));


            bundles.Add(new StyleBundle("~/Content/mobile/css").Include(
                        "~/Vendor/kendo/css/mobile/kendo.mobile.all.min.css"));

            bundles.Add(new StyleBundle("~/Content/shared/css").Include(
                        "~/Vendor/kendo/css/shared/examples-offline.css"));

            bundles.IgnoreList.Clear();
        }
    }
}
