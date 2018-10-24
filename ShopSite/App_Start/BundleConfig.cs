﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ShopSite.App_Start
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/javascript").Include(
                        "~/Scripts/move-top.js",
                        "~/Scripts/easing.js",
                        "~/Scripts/megamenu.js",
                        "~/Scripts/simpleCart.min.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/css/bootstrap.css",
                      "~/Content/css/style.css",                      
                      "~/Content/css/megamenu.css"));

            
        }
    }
}