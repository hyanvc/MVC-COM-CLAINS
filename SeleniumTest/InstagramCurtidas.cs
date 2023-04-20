using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class InstagramCurtidas
    {
        Program p = new Program();
        string usuario = string.Empty;
        string senha = string.Empty;

        public void instagramAUTO(IWebDriver driver, IWebElement messageContainer)
        {
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));
            messageBox.SendKeys("digite a conta pra ganhar seguidor:" + Keys.Enter);
            List<IWebElement> listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
            var ultimamensagem = listademensagens.LastOrDefault();
            string ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;
            while (ultimamensagemdetexto == "digite a conta pra ganhar seguidor:")
            {
                Thread.Sleep(4000);

                IWebElement messageContainer4 = driver.FindElement(By.CssSelector("div[data-tab='8']"));
                List<IWebElement> listademensagens4 = messageContainer4.FindElements(By.ClassName("focusable-list-item")).ToList();
                IWebElement ultimamensagem4 = listademensagens4.LastOrDefault();
                ultimamensagemdetexto = ultimamensagem4.FindElement(By.ClassName("_11JPr")).Text;
            }
            driver.Navigate().GoToUrl("https://www.instagram.com/");
            //logar no INSTAGRAM /
            Thread.Sleep(5000);

            List<listadecontas> listaDeUsuarios = new List<listadecontas>();

            listadecontas listadecontas = new listadecontas();
            listadecontas.NomeDeUsuario = "hy4nvictor";
            listadecontas.Senha = "Hyan2046";
            listadecontas listadecontas2 = new listadecontas();
            listadecontas.NomeDeUsuario = "sheyla_cck";
            listadecontas.Senha = "88491205";
            listaDeUsuarios.Add(listadecontas);
            listaDeUsuarios.Add(listadecontas2);

            foreach (var i in listaDeUsuarios)
            {
                IWebElement userinput = driver.FindElement(By.CssSelector("input[name='username']"));
                userinput.SendKeys(i.NomeDeUsuario);
                IWebElement senhaInput = driver.FindElement(By.CssSelector("input[name='password']"));
                senhaInput.SendKeys(i.Senha);
                senhaInput.SendKeys(Keys.Enter);
                driver.Navigate().GoToUrl("https://www.instagram.com/" + ultimamensagemdetexto);
                // Localizar o botão de seguir usando o seletor CSS
                // localiza o botão "Seguir" pelo XPath
                Thread.Sleep(4000);
                IWebElement seguirButton = driver.FindElement(By.XPath("//button[contains(., 'Seguir')]"));

                seguirButton.Click();
                Thread.Sleep(2000);

                driver.Navigate().GoToUrl("https://www.instagram.com/accounts/logout");


            }



            Thread.Sleep(8000);
            // Abre uma nova aba




            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.open()");

            // Navega para a nova aba
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Navigate().GoToUrl("https://web.whatsapp.com/");

            // Volta para a primeira aba
            //driver.SwitchTo().Window(driver.WindowHandles[0]);
            //Console.WriteLine(driver.Url);
            //driver.Navigate().GoToUrl("https://www.instagram.com/hyanvc");
            Program.Reset2(driver);
            Program.Mainreset(driver);
        }
    }
}

