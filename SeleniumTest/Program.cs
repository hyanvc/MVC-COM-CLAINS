using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {

        // LOGICA TERCEIRIZADA GPT //  CHATSONIC

        //IWebDriver driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("https://app.writesonic.com/pt-pt/login?with_password=true");
        //IWebElement login = driver.FindElement(By.Id("email"));
        //login.SendKeys("hyann1@hotmail.com");

        //IWebElement senhalogin = driver.FindElement(By.CssSelector("input[type='password']"));
        //senhalogin.SendKeys("hyan1020");
        //senhalogin.SendKeys(Keys.Enter);

        //driver.Navigate().GoToUrl("https://app.writesonic.com/pt-pt/template/06a38aa1-0dca-47ad-a506-be0fc31051ab/chatsonic/82b308a6-4e91-4f07-9045-6949b098ae6b");
        //IWebElement textarea = driver.FindElement(By.CssSelector("textarea[data-gramm_editor='false']"));
        //textarea.SendKeys("Musica do zeze de camargo é o amor" + Keys.Enter);
        //IWebElement chatsonicElement = driver.FindElement(By.CssSelector(".chatsonic p"));
        //string chatsonicText = chatsonicElement.Text;
        //driver.Navigate().GoToUrl("https://app.writesonic.com/pt-pt/template/06a38aa1-0dca-47ad-a506-be0fc31051ab/chatsonic/82b308a6-4e91-4f07-9045-6949b098ae1a");

        ////Random random = new Random();
        ////string letras = "abcdefghijklmnopqrstuvwxyz";
        ////string numero = "0123456789";

        ////string randomString = letras[random.Next(letras.Length)].ToString() +
        ////                      letras[random.Next(letras.Length)].ToString() +
        ////                      numero[random.Next(numero.Length)].ToString();


        //// LOGICA PRA REFAZER A PESQUISA NO CHAT //

        //char currentLetter = 'a';
        //currentLetter++;

        //driver.Navigate().GoToUrl("https://app.writesonic.com/pt-pt/template/9519563e-e02b-4232-b53b-b0b0df2ae171/chatsonic/d4f6474b-6c53-43bb-9838-c79f8545801" + currentLetter );



        //bool continuar = true;
        //while (continuar)
        //{
        //    Console.WriteLine("Oi seja bem vindo ao log automatico no instagram!");

        //    Console.WriteLine("Digite seu user:");
        //    var usuario = Console.ReadLine();

        //    Console.WriteLine("Digite sua senha");
        //    var senha = Console.ReadLine();
        //    senha = "Hyan2046";

        //    Console.WriteLine("agora digite o usuario pra quem você quer enviar mensagem:");
        //    var destinatario = Console.ReadLine();

        //    Console.WriteLine("a mensagem:");
        //    var mensagemdestinatario = Console.ReadLine();

        //    IWebDriver driver = new ChromeDriver();
        //    driver.Navigate().GoToUrl("https://www.instagram.com/");

        //    //logar no INSTAGRAM /
        //    Thread.Sleep(10000);
        //    IWebElement userinput = driver.FindElement(By.CssSelector("input[name='username']"));
        //    userinput.SendKeys(usuario);

        //    IWebElement senhaInput = driver.FindElement(By.CssSelector("input[name='password']"));
        //    senhaInput.SendKeys(senha);
        //    senhaInput.SendKeys(Keys.Enter);

        //    Thread.Sleep(10000);

        //    driver.Navigate().GoToUrl("https://www.instagram.com/" + destinatario);

        //    Thread.Sleep(7000);
        //    IWebElement enviarmensagembutton = driver.FindElement(By.CssSelector("div.x9f619.xjbqb8w.x78zum5.x168nmei.x13lgxp2.x5pf9jr.xo71vjh.x1i64zmx.x1n2onr6.x6ikm8r.x10wlt62.x1iyjqo2.x2lwn1j.xeuugli.xdt5ytf.xqjyukv.x1qjc9v5.x1oa3qoh.x1nhvcw1"));

        //    enviarmensagembutton.Click();
        //    Thread.Sleep(7000);

        //    Thread.Sleep(7000);

        //    IWebElement areadetexto = driver.FindElement(By.TagName("textarea"));
        //    areadetexto.SendKeys(mensagemdestinatario);
        //    areadetexto.SendKeys(Keys.Enter);

        //    Console.WriteLine("mensagem enviada... aperte enter para repetir o processo...caso não, aperte qualquer tecla");
        //    var key = Console.ReadKey();
        //    if (key.Key != ConsoleKey.Enter)
        //    {
        //        continuar = false;
        //    }
        //}




        //WHATS APP//
        //IWebDriver driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("https://web.whatsapp.com/");
        //Thread.Sleep(15000);
        //// Encontre a caixa de pesquisa e pesquise pelo usuário "nabaaau"
        //IWebElement searchBox = driver.FindElement(By.XPath("//div[@contenteditable='true']"));
        //searchBox.SendKeys("imbecil" + Keys.Enter);
        //Thread.Sleep(10000);

        //// Aguarde o chat do usuário carregar
        //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //Thread.Sleep(10000);
        //while (true)
        //{
        //    IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));
        //    messageBox.SendKeys(" vou te enviar mensagens a cada 10 secs, ok IMBE?" + Keys.Enter);
        //    //Thread.Sleep(1000);
        //}






        //WHATS APP COM LOGICA DE ULTIMA MENSAGEM// ++ INSTAGRAM
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://web.whatsapp.com/");
        Thread.Sleep(15000);
        // Encontre a caixa de pesquisa e pesquise pelo usuário "nabaaau"
        IWebElement searchBox = driver.FindElement(By.XPath("//div[@contenteditable='true']"));
        searchBox.SendKeys("nabaaau" + Keys.Enter);
        Thread.Sleep(10000);

        // Aguarde o chat do usuário carregar
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        Thread.Sleep(10000);



        //ENCONTRA A ULTIMA MENSAGEM ENVIADA NO WPP //

        string senha = null;
        string usuario = null;


        while (true)
        {
            IWebElement messageContainer = driver.FindElement(By.CssSelector("div[data-tab='8']"));
            List<IWebElement> listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
            IWebElement ultimamensagem = listademensagens.LastOrDefault();
            string ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;
            if (ultimamensagemdetexto != null && ultimamensagemdetexto == "quero logar no instagram")
            {
                IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));
                messageBox.SendKeys("você quer entrar no instagram? ok digite seu usuario:" + Keys.Enter);
                 listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
                 ultimamensagem = listademensagens.LastOrDefault();
                 ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;

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
                }




                driver.Navigate().GoToUrl("https://www.instagram.com/");

                //logar no INSTAGRAM /
                Thread.Sleep(10000);
                IWebElement userinput = driver.FindElement(By.CssSelector("input[name='username']"));
                userinput.SendKeys(usuario);

                IWebElement senhaInput = driver.FindElement(By.CssSelector("input[name='password']"));
                senhaInput.SendKeys(senha);
                senhaInput.SendKeys(Keys.Enter);
                Thread.Sleep(10000);
                driver.Navigate().GoToUrl("https://www.instagram.com/hyanvc");
                Thread.Sleep(600000);
                driver.Navigate().GoToUrl("https://web.whatsapp.com/");

            }
            Thread.Sleep(6000);

        }






        //driver.Quit();
    }
}
