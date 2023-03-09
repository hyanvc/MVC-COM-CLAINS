using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Configuration;
using System.Numerics;
using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using System.Xml.Linq;
using System.Net.Sockets;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Hosting.Server;
using Grpc.Core;
using System.IO;
using OpenRasta.Configuration.Fluent;

namespace MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        VMOperador VMOperador = new VMOperador();

        public LoginController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            ClaimsPrincipal claimsuser = HttpContext.User;
            if (claimsuser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View();
        }

        public JsonResult Nomes()
        {
            string name;
            ClaimsPrincipal claimsuser = HttpContext.User;
            if (claimsuser.Identity.IsAuthenticated)
            {
                name = "Hyan SEJA BEM VINDO!";
            }
            else
            {
                name = null;
            }
            return Json(new { name = name });

        }

        public IActionResult denied()
        {
            return View();
        }


        public IActionResult graficos()
        {
            return View();
        }

        public IActionResult cadastro()
        {
            return View();
        }

        public IActionResult idade()
        {
            return View();
        }
        public string generarReportePDF(string nombre)
        {
            string filename = "hyan.pdf";
            var physicalPath = $"./{filename}";
            var pdfBytes = System.IO.File.ReadAllBytes(physicalPath);
            var ms = new MemoryStream(pdfBytes);
            return Convert.ToBase64String(ms.ToArray());
        }


        public JsonResult obteridade(string txtData)
        {
            DateTime dataNascimento = Convert.ToDateTime(txtData);

            int anos = DateTime.Today.Year - dataNascimento.Year;

            if (dataNascimento.Month > DateTime.Today.Month || dataNascimento.Month == DateTime.Today.Month && dataNascimento.Day > DateTime.Today.Day)
                anos--;


            return Json(new { anos = anos });
        }


        [HttpPost]
        public async Task<IActionResult> Login(VMOperador model)
        {
            if (model.Email == "hyan@gmail.com"
                && model.PassWord == "hyan123")
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,model.Email),
                    new Claim("Role", "Role")
                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = model.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme
                    , new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Home");
            }

            return View();
        }

    }
}