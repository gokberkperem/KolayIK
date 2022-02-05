using Business;
using Entities.Classes;
using KolayIk.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViewModels;

namespace Kolayik.UI.Controllers
{
    public class PersonelController : MyController
    {
        private PersonelService _personelService = new PersonelService();
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(PersonelLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                ServiceResult<Personel> result = _personelService.Login(model);

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
        public IActionResult ShowProfile()
        {
            int? userId = HttpContext.Session.GetInt32(Constants.SessionUserId);

            ServiceResult<Personel> result = _personelService.Find(userId.Value);

            if (result.HasError)
            {
                return RedirectToAction(nameof(Login));
            }

            return View(result.Data);
        }
        public new IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult EditProfile()
        {
            int? personelId = HttpContext.Session.GetInt32(Constants.SessionUserId);

            ServiceResult<Personel> result = _personelService.Find(personelId.Value);

            if (result.HasError)
            {
                return RedirectToAction(nameof(Login));
            }

            return View(result.Data);
        }
        [HttpPost]
        public IActionResult ProfileSaveInfo(Personel p)
        {
            int? personelId = HttpContext.Session.GetInt32(Constants.SessionUserId);

            ServiceResult<Personel> result = _personelService.Find(personelId.Value);

            Personel personel = result.Data;

            _personelService.SaveProfileInfo(personel.Id, p);
            return View(nameof(EditProfile));
        }
    }
}
