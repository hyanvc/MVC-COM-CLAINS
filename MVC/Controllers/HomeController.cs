using System.Data.SqlClient;
using System.Diagnostics;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Configuration;
using System.Numerics;
using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace MVC.Controllers
{
    [Authorize(Policy = "teste")]


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        VMOperador VMOperador = new VMOperador();
       
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(VMOperador model)
         {
            model.ListaOperadores = (List<VMOperador>)GetListaAniversariantes();
            //using var con = new SqlConnection("");
            //con.Open();
            //if(VMOperador.t != null)
            //{
            //    model.NM_NOME = VMOperador.t;
            //}
            // model.ListaOperadores = (List<VMOperador>)con.Query<VMOperador>("select  top 10 *  from TB_USUARIO");
            return View(model);
        }


        private IEnumerable<VMOperador> GetListaAniversariantes()
        {
            yield return new VMOperador { NM_NOME = "Carlos Henrique" };
            yield return new VMOperador { NM_NOME = "Carlos Andrade" };
            yield return new VMOperador { NM_NOME = "Carlos Alexandre" };
            yield return new VMOperador { NM_NOME = "Carlos Viana" };
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Login");

        }
    }
}