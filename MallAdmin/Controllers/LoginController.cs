using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MumbaiMallLibrary;
using System.Data.SqlClient;
using MallAdmin.Models;
using MallAdmin.Code;

namespace MallAdmin.Controllers
{
      public class LoginController : Controller
        {
            // GET: Admin/Login/Index
            [HttpGet]
            public ActionResult Index()
            {
                return View();
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Index(LoginModel model)
            {
                var result = new AccountModel().Login(model.UserName, model.Password);
                if (result && ModelState.IsValid)
                {
                    SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Tên Đăng Nhập Không Đúng.");
                }
                return View(model);
            }

        }


    }
