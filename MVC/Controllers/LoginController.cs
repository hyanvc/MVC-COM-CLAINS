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
using OpenRasta.Collections;
using OpenRasta.TypeSystem;
using System.Diagnostics.Metrics;
using System.Net;
using RestSharp;
using Newtonsoft.Json;
using Twilio;
using Twilio.Types;
using Twilio.Rest.Api.V2010.Account;
using System.Net.Mail;
using Twilio.TwiML.Messaging;
using Microsoft.VisualBasic;
using QRCoder;
using ZXing;
using OpenRasta.Web;
using ZXing.QrCode.Internal;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

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

        public byte[] methodpix()
        {
            string nomeBeneficiario = "hyan";
            string cidadeBeneficiario = "Fortaleza";
            string chavePix = "00888609302";

            // Valor da transação em centavos
            int valor = 5000;

            // Monta o payload do QR Code
            string payload = "000201" +
                "26330014BR.GOV.BCB.PIX0119" + chavePix + "52040000" + valor.ToString("D10") +
                "5802BR" +
                "5911" + nomeBeneficiario + "6009" + cidadeBeneficiario +
                "62070503***" +
                "6304";

            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new BitmapByteQRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(10);

            VMOperador model = new VMOperador();

            //string filename = "hyan.pdf";
            //var physicalPath = $"./{filename}";
            //var pdfBytes = System.IO.File.ReadAllBytes(physicalPath);
            //var ms = new MemoryStream(pdfBytes);
            model.ByteArray = qrCodeImage;

            return qrCodeImage;
        }

        public byte[] LinksSiteQRCODE(string qrcodelink)
        {

            // Define o link que será codificado no QR Code
            string link = qrcodelink;

            // Cria o QR Code
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(link, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new BitmapByteQRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(10);

            return qrCodeImage;
        }
        public JsonResult LinksSiteQRCODEJson()
        {

            // Define o link que será codificado no QR Code
            string link = "https://www.mulherpelada.com.br/";

            // Cria o QR Code
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(link, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new BitmapByteQRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(10);

            return Json(new { qrcodelink = qrCodeImage });
        }

        public IActionResult Curriculo()
        {
            VMOperador model = new VMOperador();

            string filename = "hyan.pdf";
            var physicalPath = $"./{filename}";
            var pdfBytes = System.IO.File.ReadAllBytes(physicalPath);
            //var ms = new MemoryStream(pdfBytes);
            model.ByteArray = pdfBytes;

            return View(model);
        }

        //public ActionResult GerarLinkQRCODEs(string qrcodelink)
        //{
        //    // lógica para encurtar a URL
        //    string urlEncurtada = "http://minhaurlencurtada.com/" + qrcodelink;

        //    // redireciona para a ação "GerarLinkQRCODE" no mesmo controlador, passando a URL encurtada como parâmetro
        //    return RedirectToAction("GerarLinkQRCODE", new { qrcodelink = urlEncurtada });
        //}

        //public ActionResult GerarLinkQRCODE(string qrcodelink)
        //{
        //    // lógica para exibir a página com o link encurtado
        //    return View();
        //}


        public IActionResult GerarLinkQRCODE(string qrcodelink)
        {
            // Define o link que será codificado no QR Code
            string link = qrcodelink;

            // Cria o QR Code
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(link, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new BitmapByteQRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(10);
            VMOperador view = new VMOperador();
            view.ByteArray = qrCodeImage;
            return View(view);
        }


        public IActionResult EntradasqrCode()
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


        //ZENVIA ENVIO DE SMS//
        public  JsonResult Send(SMSBuilder builder)
        {
            var blz = "ok";
            //SendEmail(blz);
            builder.To = "5585988190112";
            builder.From = "5585988190112";
            builder.text = "teste!";
            var tel = "text";

            List<SMSBuilder> contents = new List<SMSBuilder>
            {
                new SMSBuilder {text = builder.text, type = tel}

            };
            var tall = new { from = builder.From, to = builder.To, contents };
            var body = JsonConvert.SerializeObject(tall);
            var client = new RestClient("https://api.zenvia.com/v2/channels/sms/messages");
            var request = new RestRequest(Method.POST);
            request.AddHeader("X-API-TOKEN", "hL7Jxb8-4ma9GqZzvwRnvCxx2NHMUADoxeZq");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //verificar pois tem que ser tls12.
            var response = client.Execute(request);
            var resultados = response.StatusCode;

            return Json(new { re = resultados });


        }

        public string estruturaConsumirAPI()
        {
            ////var tall = new { from = builder.From, to = builder.To, contents };
            //var tall = "ok";
            //var body = JsonConvert.SerializeObject(tall);
            //var client = new RestClient("https://api.zenvia.com/v2/channels/sms/messages");
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("X-API-TOKEN", "hL7Jxb8-4ma9GqZzvwRnvCxx2NHMUADoxeZq");
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", body, ParameterType.RequestBody);
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //verificar pois tem que ser tls12.
            //var response = client.Execute(request);
            //var resultados = response.StatusCode;

            return "cel";
        }
        //TWILLO SMS//https://console.twilio.com/us1/develop/sms/try-it-out/send-an-sms
        //HyanVictorCunhaGomes
        static MessageResource SendSMS(string message)
        {
            message = "OI";
            var accountSid = "AC75a01835c9897135ed1f2d77b954cc15";
            var authToken = "6f5310d40d6992ffe79c17ca2506af60";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
                new PhoneNumber("+5585988190112"));
            messageOptions.MessagingServiceSid = "MGccd362e20e68bf8b17d6d6e10a53be39";
            messageOptions.From = new PhoneNumber("+15177900641");
            messageOptions.Body = message;

           var T = MessageResource.Create(messageOptions);
            var k = T.Status;
            return T;
        }

        public JsonResult obteridade(string txtData)
        {

            SMSBuilder builder = new SMSBuilder();
            SendSMS(txtData);

            var l = new List<string>();
            var y = txtData.Split();
            string[] strg;
            foreach (var i in y)
            {
                if (i == "b")
                {
                    l.Add(i);
                }
            }

            var splitado = l;

            var t = txtData.Substring(0, 100);
            DateTime dataNascimento = Convert.ToDateTime(txtData);

            int anos = DateTime.Today.Year - dataNascimento.Year;

            if (dataNascimento.Month > DateTime.Today.Month || dataNascimento.Month == DateTime.Today.Month && dataNascimento.Day > DateTime.Today.Day)
                anos--;


            return Json(new { anos = anos });
        }


        //ESTRUTURA DE ENVIAR EMAIL EM DESENVOLVIMENTO //
        public static void SendEmail(string e2mail)
        { // Configurar as credenciais do remetente
            //var fromAddress = new MailAddress("hyancunha@gmail.com", "Hyan");
            //var fromPassword = "hyan1234";

            //// Configurar as informações do destinatário
            //var toAddress = new MailAddress("hyann1@hotmail.com", "Destinatário");

            //// Configurar o corpo do e-mail
            //const string subject = "Assunto ";
            //const string body = "Conteúdo";

            //// Configurar o cliente SMTP do Gmail
            //var smtp = new SmtpClient
            //{
            //    Host = "smtp.gmail.com",
            //    Port = 587,
            //    EnableSsl = true,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            //};

            //// Enviar o e-mail
            //using (var message = new MailMessage(fromAddress, toAddress)
            //{
            //    Subject = subject,
            //    Body = body
            //})
            //{
            //    smtp.Send(message);
            //}

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

    // futura AUTENTICAÇÃO //
    //[HttpPost]
    //public async Task<IActionResult> Login(string username, string password)
    //{
    //    // Verificar o nome de usuário e a senha aqui ...

    //    var claims = new List<Claim>
    //    {
    //        new Claim(ClaimTypes.Name, username),
    //        new Claim("custom_claim_type", "value")
    //    };
    //    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
    //    var principal = new ClaimsPrincipal(identity);

    //    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

    //    return RedirectToAction("MyAction");
    //}

    //[ServiceFilter(typeof(CustomAuthorizationFilter), Arguments = new object[] { "custom_claim_type" })]
    //public IActionResult MyAction()
    //{
    //    // Ação somente permitida para usuários com a reivindicação personalizada "custom_claim_type"
    //    return View();
    //}
}