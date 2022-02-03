using Business;
using KolayIk.Core;
using Entities.Classes;
using Kolayik.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using ViewModels;
using System.Collections.Generic;

namespace Kolayik.UI.Controllers
{
    public class HomeController : MyController
    {
        private UserService _userService = new UserService();
        private PersonelService _personelService = new PersonelService();

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
                    return RedirectToAction(nameof(SirketLogin));
                }
            }

            return View(model);
        }
        public IActionResult SirketLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SirketLogin(SirketLoginViewModel model)
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

                    return RedirectToAction(nameof(SirketAnasayfasi));
                }
            }

            return View(model);
        }

        public IActionResult SirketAnasayfasi()
        {
            List<Personel> personels = _personelService.GetPersonels();

            return View(personels);
        }

        public IActionResult PersonelEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PersonelEkle(PersonelRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                ServiceResult<Personel> result = _personelService.Register(model);

                if (result.HasError)
                {
                    AddErrorsToModelState(result.Errors);
                }
                else
                {
                    return RedirectToAction(nameof(SirketAnasayfasi));
                }
            }

            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ServiceResult<Personel> result = _personelService.Find(id);
            return View(result.Data);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            ServiceResult<object> result = _personelService.Remove(id);

            if (result.HasError)
            {
                AddErrorsToModelState(result.Errors);
                return View(nameof(Delete), _personelService.Find(id).Data);
            }

            return RedirectToAction(nameof(SirketAnasayfasi));
        }
        public IActionResult Details(int id)
        {
            ServiceResult<Personel> result = _personelService.Find(id);
            return View(result.Data);
        }
        public IActionResult Edit(int id)
        {
            ServiceResult<Personel> result = _personelService.Find(id);

            if (result.HasError)
            {
                AddErrorsToModelState(result.Errors);

                // Kullanıcıyı kayıt yoksa her türlü index e gönder..
                //if (result.NotFound)
                //{
                //    return RedirectToAction(nameof(Index));
                //}
            }

            PersonelEditViewModel model = null;

            if (result.Data != null)
            {
                model = new PersonelEditViewModel
                {
                    Ad = result.Data.Ad,
                    Soyad = result.Data.Soyad,
                    Email = result.Data.Email,
                    Telefon = result.Data.Telefon,
                    IseAlimTarihi = result.Data.IseAlimTarihi,
                    DogumTarihi = result.Data.DogumTarihi,
                    AktifMi = result.Data.AktifMi
                };
            }
            else
            {
                model = new PersonelEditViewModel
                {
                    NotFound = result.NotFound
                };
            }

            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(int id, PersonelEditViewModel model)
        {
            ServiceResult<Personel> result = _personelService.Update(id, model);

            if (result.HasError)
            {
                AddErrorsToModelState(result.Errors);
                return View(model);
            }

            return RedirectToAction(nameof(SirketAnasayfasi));
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
