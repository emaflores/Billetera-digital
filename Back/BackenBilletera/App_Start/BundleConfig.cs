﻿using System.Web;
using System.Web.Optimization;

namespace BackenBilletera
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new Bundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new Bundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new Bundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new Bundle("~/Script/bundles").Include(
                    "~/bundles/main.*",
                    "~/bundles/inline.*",
                    "~/bundles/polyfills.*",
                    "~/bundles/scripts.*",
                    "~/bundles/vendor.*",
                    "~/bundles/runtime.*",
                    "~/bundles/zone.*"
                    ));
            bundles.Add(new Bundle("~/Content/Styles").Include("~/bundles/styles.*"));
        }
    }
}
