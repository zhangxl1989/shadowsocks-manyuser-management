﻿using SSMM.Cache;
using SSMM.Helper;
using SSMM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSMM.Web.Controllers
{
    public class IndexController : Controller
    {

        public ActionResult Index()
        {

            ViewBag.WebSiteTitle = SettingCache.Cache.Get(SettingFlag.WebSiteTitle);
            ViewBag.WebSiteKeywords = SettingCache.Cache.Get(SettingFlag.WebSiteKeywords);
            ViewBag.WebSiteDescription = SettingCache.Cache.Get(SettingFlag.WebSiteDescription);
            //aff
            var affcode = RequestHelper.GetValue("aff");
            if (!string.IsNullOrEmpty(affcode))
                CookieHelper.AffCode = affcode;
            return View();
        }
    }
}