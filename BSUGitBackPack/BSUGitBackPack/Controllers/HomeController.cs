﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcMovie.Models;


namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //[HttpPost]
        //public IActionResult Login(string userName, string password)
        //{
        //    if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
        //    {
        //        return RedirectToAction("Login");
        //    }

        //    //Check the user name and password  
        //    //Here can be implemented checking logic from the database  

        //    if (userName == "Admin" && password == "password")
        //    {

        //        //Create the identity for the user  
        //        var identity = new ClaimsIdentity(new[] {
        //            new Claim(ClaimTypes.Name, userName)
        //        }, CookieAuthenticationDefaults.AuthenticationScheme);

        //        var principal = new ClaimsPrincipal(identity);

        //        var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

        //        return RedirectToAction("Index", "Home");
        //    }

        //    return View();
        //}

        //public async Task<ActionResult> IndexAsync(CancellationToken cancellationToken)
        //{
        //    var result = await new AuthorizationCodeMvcApp(this, new AppFlowMetadata()).
        //        AuthorizeAsync(cancellationToken);

        //    if (result.Credential != null)
        //    {
        //        var oauthService = new Google.Apis.Oauth2.v2.Oauth2Service(
        //            new BaseClientService.Initializer()
        //            {
        //                HttpClientInitializer = result.Credential,
        //                ApplicationName = "Mike Test"
        //            });
        //        var userInfo = await oauthService.Userinfo.Get().ExecuteAsync();
        //        Console.WriteLine(result.Credential.UserId);
        //        return View();
        //    }
        //    else
        //    {
        //        Console.WriteLine("null credential seen");
        //        return new RedirectResult(result.RedirectUri);
        //    }
        //}

    }
}
