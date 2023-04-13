using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Oi seja bem vindo ao log automatico no instagram!");

            Console.WriteLine("Digite seu user:");
            var usuario = Console.ReadLine();

            Console.WriteLine("Digite sua senha");
            var senha = Console.ReadLine();
            senha = "Hyan2046";

            Console.WriteLine("agora digite o usuario pra quem você quer enviar mensagem:");
            var destinatario = Console.ReadLine();

            Console.WriteLine("a mensagem:");
            var mensagemdestinatario = Console.ReadLine();

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.instagram.com/");

            //logar no INSTAGRAM /
            Thread.Sleep(10000);
            IWebElement userinput = driver.FindElement(By.CssSelector("input[name='username']"));
            userinput.SendKeys(usuario);

            IWebElement senhaInput = driver.FindElement(By.CssSelector("input[name='password']"));
            senhaInput.SendKeys(senha);
            senhaInput.SendKeys(Keys.Enter);

            Thread.Sleep(10000);

            driver.Navigate().GoToUrl("https://www.instagram.com/" + destinatario);

            Thread.Sleep(7000);
            IWebElement enviarmensagembutton = driver.FindElement(By.CssSelector("div.x9f619.xjbqb8w.x78zum5.x168nmei.x13lgxp2.x5pf9jr.xo71vjh.x1i64zmx.x1n2onr6.x6ikm8r.x10wlt62.x1iyjqo2.x2lwn1j.xeuugli.xdt5ytf.xqjyukv.x1qjc9v5.x1oa3qoh.x1nhvcw1"));

            enviarmensagembutton.Click();
            Thread.Sleep(7000);

            Thread.Sleep(7000);

            IWebElement areadetexto = driver.FindElement(By.TagName("textarea"));
            areadetexto.SendKeys(mensagemdestinatario);
            areadetexto.SendKeys(Keys.Enter);

            Console.WriteLine("mensagem enviada... aperte enter para repetir o processo...caso não, aperte qualquer tecla");
            var key = Console.ReadKey();
            if (key.Key != ConsoleKey.Enter)
            {
                continuar = false;
            }
        }












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


        // LOGICA PRA UMA ALTERNATIVA DE CHAT GPT



        //// Adiciona uma nova aba
        //driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");

        //// Navega para o Google na nova aba
        //driver.SwitchTo().Window(driver.WindowHandles.Last());
        //driver.Navigate().GoToUrl("https://app.writesonic.com/"); 
        //IWebElement btnEnviar =  driver.FindElement(By.XPath("//p[@class='text-sm text-gray-6 group-hover:text-navy-1 whitespace-normal min-h-17']"));
        //btnEnviar.Click();

        ////enviar mensagem no chat gpt alternativo
        //IWebElement messageBox = driver.FindElement(By.CssSelector("textarea"));
        //messageBox.SendKeys("orkut" + Keys.Enter);


        ////PEGAR O TEXTO
        //IWebElement chatsonicDiv = driver.FindElement(By.CssSelector("div.chatsonic"));
        //string chatsonicText = chatsonicDiv.Text;
        //// APAGAR HISTORICO//
        //IWebElement btnEnviar2 = driver.FindElement(By.XPath("//button[contains(., 'New Chat')]"));

        //btnEnviar2.Click();





        //driver.Quit();
    }
}
