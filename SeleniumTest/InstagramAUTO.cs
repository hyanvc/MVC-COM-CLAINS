using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class InstagramAUTO
    {
        Program p = new Program();
        string usuario = string.Empty;
        string senha = string.Empty;

        public void instagramAUTO(IWebDriver driver, IWebElement messageContainer)

        {
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));
            messageBox.SendKeys("você quer entrar no instagram? ok digite seu usuario:" + Keys.Enter);
            List<IWebElement> listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
           var ultimamensagem = listademensagens.LastOrDefault();
            string ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;


            while (ultimamensagemdetexto == "você quer entrar no instagram? ok digite seu usuario:")
            {
                Thread.Sleep(4000);

                IWebElement messageContainer4 = driver.FindElement(By.CssSelector("div[data-tab='8']"));
                List<IWebElement> listademensagens4 = messageContainer4.FindElements(By.ClassName("focusable-list-item")).ToList();
                IWebElement ultimamensagem4 = listademensagens4.LastOrDefault();
                ultimamensagemdetexto = ultimamensagem4.FindElement(By.ClassName("_11JPr")).Text;
                usuario = ultimamensagemdetexto;
            }



            IWebElement messageContainer2 = driver.FindElement(By.CssSelector("div[data-tab='8']"));
            List<IWebElement> listademensagens2 = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
            IWebElement ultimamensagem2 = listademensagens2.LastOrDefault();
            usuario = ultimamensagem2.FindElement(By.ClassName("_11JPr")).Text;

            messageBox.SendKeys("digite sua senha:" + Keys.Enter);
            listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
            ultimamensagem = listademensagens.LastOrDefault();
            ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;
            while (ultimamensagemdetexto == "digite sua senha:")
            {
                IWebElement messageContainer3 = driver.FindElement(By.CssSelector("div[data-tab='8']"));
                List<IWebElement> listademensagens3 = messageContainer3.FindElements(By.ClassName("focusable-list-item")).ToList();
                IWebElement ultimamensagem3 = listademensagens3.LastOrDefault();
                ultimamensagemdetexto = ultimamensagem3.FindElement(By.ClassName("_11JPr")).Text;
                senha = ultimamensagemdetexto;
                Thread.Sleep(5000);

                while (ultimamensagemdetexto != "digite sua senha")
                {
                    driver.Navigate().GoToUrl("https://www.instagram.com/");
                    //logar no INSTAGRAM /
                    Thread.Sleep(10000);
                    IWebElement userinput = driver.FindElement(By.CssSelector("input[name='username']"));
                    userinput.SendKeys(usuario);

                    IWebElement senhaInput = driver.FindElement(By.CssSelector("input[name='password']"));
                    senha = "Hyan2046";
                    senhaInput.SendKeys(senha);
                    senhaInput.SendKeys(Keys.Enter);
                    Thread.Sleep(8000);
                    driver.Navigate().GoToUrl("https://www.instagram.com/direct/inbox/");

                     // ESSE WHILE EXCLUI CONVERSAS DO INSTAGRAM.
                    while (true)
                    {
                        //driver.Navigate().GoToUrl("https://www.instagram.com/direct/inbox/");
                        Thread.Sleep(5000);
                        IList<IWebElement> conversas = driver.FindElements(By.CssSelector("div[role='listitem']"));
                        // Encontre a primeira conversa na lista
                        IWebElement primeiraConversa = conversas[1];
                        primeiraConversa.Click();
                        Thread.Sleep(1000);
                        IWebElement informacoesConversa = driver.FindElement(By.CssSelector("svg[aria-label='Informações da conversa']"));
                        Thread.Sleep(2000);
                        informacoesConversa.Click();
                        Thread.Sleep(2000);
                        IWebElement botaoExcluir = driver.FindElement(By.XPath("//*[text()='Excluir bate-papo']"));
                        botaoExcluir.Click();
                        Thread.Sleep(2000);
                        IWebElement botaooExcluir = driver.FindElement(By.CssSelector("button.xvs91rp"));
                        Thread.Sleep(1000);
                        botaooExcluir.Click();
                    }
                   


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
    }
}
