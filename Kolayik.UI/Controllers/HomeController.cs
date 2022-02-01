using Business;
using KolayIk.Core;
using Entities.Classes;
using Kolayik.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using ViewModels;

namespace Kolayik.UI.Controllers
{
    public class HomeController : MyController
    {
        private UserService _userService = new UserService();
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
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        
        public IActionResult Register(SirketRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ServiceResult<Sirket> result = _userService.Register(model);

                if (result.HasError)
                {
                    AddErrorsToModelState(result.Errors);
                }
                else
                {
                    return RedirectToAction(nameof(Login));
                }
            }

            return View(model);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(SirketLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                ServiceResult<Sirket> result = _userService.Login(model);

                if (result.HasError)
                {
                    AddErrorsToModelState(result.Errors);
                }
                else
                {
                    // Doğrulama başarılı, doğrulama hafızada tutulmalı.
                    HttpContext.Session.SetInt32(Constants.SessionUserId, result.Data.Id);
                    //HttpContext.Session.SetString(Constants.SessionUserIsLogin, bool.TrueString);
                    HttpContext.Session.SetString(Constants.SessionUsername, result.Data.Ad);
                    HttpContext.Session.SetString(Constants.SessionUserEmail, result.Data.Email);

                    return RedirectToAction(nameof(Index));
                }
            }

            return View(model);
        }

    }
}
