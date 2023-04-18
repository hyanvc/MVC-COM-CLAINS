using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QRCoder;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        Reset(driver);
        Mainreset(driver);

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
        //IWebDriver driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("https://web.whatsapp.com/");
        //Thread.Sleep(15000);
        //// Encontre a caixa de pesquisa e pesquise pelo usuário "nabaaau"
        //IWebElement searchBox = driver.FindElement(By.XPath("//div[@contenteditable='true']"));
        //searchBox.SendKeys("nabaaau" + Keys.Enter);
        //Thread.Sleep(10000);

        //// Aguarde o chat do usuário carregar
        //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        //Thread.Sleep(10000);



        ////ENCONTRA A ULTIMA MENSAGEM ENVIADA NO WPP //

        //string senha = null;
        //string usuario = null;


        //while (true)
        //{
        //    IWebElement messageContainer = driver.FindElement(By.CssSelector("div[data-tab='8']"));
        //    List<IWebElement> listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
        //    IWebElement ultimamensagem = listademensagens.LastOrDefault();
        //    string ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;
        //    if (ultimamensagemdetexto != null && ultimamensagemdetexto == "quero logar no instagram")
        //    {
        //        IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));
        //        messageBox.SendKeys("você quer entrar no instagram? ok digite seu usuario:" + Keys.Enter);
        //        listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
        //        ultimamensagem = listademensagens.LastOrDefault();
        //        ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;


        //        while (ultimamensagemdetexto == "você quer entrar no instagram? ok digite seu usuario:")
        //        {
        //            Thread.Sleep(4000);

        //            IWebElement messageContainer4 = driver.FindElement(By.CssSelector("div[data-tab='8']"));
        //            List<IWebElement> listademensagens4 = messageContainer4.FindElements(By.ClassName("focusable-list-item")).ToList();
        //            IWebElement ultimamensagem4 = listademensagens4.LastOrDefault();
        //            ultimamensagemdetexto = ultimamensagem4.FindElement(By.ClassName("_11JPr")).Text;
        //            usuario = ultimamensagemdetexto;
        //        }



        //        IWebElement messageContainer2 = driver.FindElement(By.CssSelector("div[data-tab='8']"));
        //        List<IWebElement> listademensagens2 = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
        //        IWebElement ultimamensagem2 = listademensagens2.LastOrDefault();
        //        usuario = ultimamensagem2.FindElement(By.ClassName("_11JPr")).Text;

        //        messageBox.SendKeys("digite sua senha:" + Keys.Enter);
        //        listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
        //        ultimamensagem = listademensagens.LastOrDefault();
        //        ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;
        //        while (ultimamensagemdetexto == "digite sua senha:")
        //        {
        //            IWebElement messageContainer3 = driver.FindElement(By.CssSelector("div[data-tab='8']"));
        //            List<IWebElement> listademensagens3 = messageContainer3.FindElements(By.ClassName("focusable-list-item")).ToList();
        //            IWebElement ultimamensagem3 = listademensagens3.LastOrDefault();
        //            ultimamensagemdetexto = ultimamensagem3.FindElement(By.ClassName("_11JPr")).Text;
        //            senha = ultimamensagemdetexto;
        //        }

        //        Thread.Sleep(5000);


        //        driver.Navigate().GoToUrl("https://www.instagram.com/");

        //        //logar no INSTAGRAM /
        //        Thread.Sleep(14000);
        //        IWebElement userinput = driver.FindElement(By.CssSelector("input[name='username']"));
        //        userinput.SendKeys(usuario);

        //        IWebElement senhaInput = driver.FindElement(By.CssSelector("input[name='password']"));
        //        senha = "Hyan2046";
        //        senhaInput.SendKeys(senha);
        //        senhaInput.SendKeys(Keys.Enter);
        //        Thread.Sleep(10000);
        //        driver.Navigate().GoToUrl("https://www.instagram.com/hyanvc");
        //        Thread.Sleep(600000);
        //        driver.Navigate().GoToUrl("https://web.whatsapp.com/");

        //    }
        //    Thread.Sleep(6000);

        //}






        //WPP COM FUNÇÃO DE ENVIAR QRCODE//
        //IWebDriver driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("https://web.whatsapp.com/");
        //Thread.Sleep(15000);
        //// Encontre a caixa de pesquisa e pesquise pelo usuário "nabaaau"
        //IWebElement searchBox = driver.FindElement(By.XPath("//div[@contenteditable='true']"));
        //searchBox.SendKeys("abraola" + Keys.Enter);
        //Thread.Sleep(10000);
        //IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));
        //messageBox.SendKeys("oi aqui é o bot, digite um link pra q seja QRCODE:" + Keys.Enter);


        //// Define o link que será codificado no QR Code
        //string link = "https://www.gsuplementos.com.br/";

        //// Cria o QR Code
        //var qrGenerator = new QRCodeGenerator();
        //var qrCodeData = qrGenerator.CreateQrCode(link, QRCodeGenerator.ECCLevel.Q);
        //var qrCode = new BitmapByteQRCode(qrCodeData);
        //var qrCodeImage = qrCode.GetGraphic(10);
        //byte[] fileBytes = qrCodeImage;
        //string tempFilePath = Path.GetTempFileName();
        //tempFilePath = Path.ChangeExtension(tempFilePath, ".png");
        //File.WriteAllBytes(tempFilePath, fileBytes);
        //IWebElement attachButton = driver.FindElement(By.CssSelector("span[data-testid='clip'][data-icon='clip']"));
        //attachButton.Click();
        //IWebElement fileInput = driver.FindElement(By.CssSelector("input[type='file']"));
        //fileInput.SendKeys(tempFilePath);
        //IWebElement sendButton = driver.FindElement(By.CssSelector("span[data-testid='send']"));
        //sendButton.Click();















        //driver.Quit();
    }

    static void Mainreset(IWebDriver driver)
    {
        string senha = null;
        string usuario = null;
        string qrcode = null;


        while (true)
        {
            IWebElement messageContainer = driver.FindElement(By.CssSelector("div[data-tab='8']"));
            List<IWebElement> listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
            IWebElement ultimamensagem = listademensagens.LastOrDefault();
            string ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;
            if (ultimamensagemdetexto != null && ultimamensagemdetexto == "1")
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
                        driver.Navigate().GoToUrl("https://www.instagram.com/hyanvc");
                        Thread.Sleep(12000);
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
                        Reset2(driver);
                    }
                }



            }

            if (ultimamensagemdetexto != null && ultimamensagemdetexto == "2")
            {
                IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));
                messageBox.SendKeys("QRCODE: digite o link para ser gerado:" + Keys.Enter);

                while (!ultimamensagemdetexto.Contains("http://"))
                {
                    Thread.Sleep(4000);

                    IWebElement messageContainer4 = driver.FindElement(By.CssSelector("div[data-tab='8']"));
                    List<IWebElement> listademensagens4 = messageContainer4.FindElements(By.ClassName("focusable-list-item")).ToList();
                    IWebElement ultimamensagem4 = listademensagens4.LastOrDefault();
                    ultimamensagemdetexto = ultimamensagem4.FindElement(By.ClassName("_11JPr")).Text;
                    qrcode = ultimamensagemdetexto;
                }


                listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
                ultimamensagem = listademensagens.LastOrDefault();
                ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;


                //// Define o link que será codificado no QR Code
                string link = ultimamensagemdetexto;
                messageBox.SendKeys("Gerando qrcode......" + Keys.Enter);

                // Cria o QR Code
                var qrGenerator = new QRCodeGenerator();
                var qrCodeData = qrGenerator.CreateQrCode(link, QRCodeGenerator.ECCLevel.Q);
                var qrCode = new BitmapByteQRCode(qrCodeData);
                var qrCodeImage = qrCode.GetGraphic(10);
                byte[] fileBytes = qrCodeImage;
                string tempFilePath = Path.GetTempFileName();
                messageBox.SendKeys("quase la....." + Keys.Enter);
                tempFilePath = Path.ChangeExtension(tempFilePath, ".png");
                File.WriteAllBytes(tempFilePath, fileBytes);
                Thread.Sleep(2000);
                IWebElement attachButton = driver.FindElement(By.CssSelector("span[data-testid='clip'][data-icon='clip']"));
                Thread.Sleep(2000);
                attachButton.Click();
                Thread.Sleep(2000);
                IWebElement fileInput = driver.FindElement(By.CssSelector("input[type='file']"));
                Thread.Sleep(2000);
                fileInput.SendKeys(tempFilePath);
                Thread.Sleep(4000);
                IWebElement sendButton = driver.FindElement(By.CssSelector("span[data-testid='send']"));
                sendButton.Click();
                Thread.Sleep(4000);
                messageBox.SendKeys("QRCODE GERADO!" + Keys.Enter);
                Thread.Sleep(5000);
                Reset2(driver);
            }







            Thread.Sleep(6000);

        }

    }

    static void Reset2(IWebDriver driver)
    {
        //driver.Navigate().GoToUrl("https://web.whatsapp.com/");
        //Thread.Sleep(15000);
        // Encontre a caixa de pesquisa e pesquise pelo usuário "nabaaau"
        Thread.Sleep(15000);
        IWebElement searchBox = driver.FindElement(By.XPath("//div[@contenteditable='true']"));
        searchBox.SendKeys("nabaaau" + Keys.Enter);
        IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));

        messageBox.SendKeys("Oi seja bem vindo ao bot bil! " + Keys.Enter);
        messageBox.SendKeys("aqui temos algumas opções de automações " + Keys.Enter);
        messageBox.SendKeys("como por exemplo, logar no instagram(1).... gerar qrcode(2),basta digitar o número que acompanha cada função para realiza-la.  " + Keys.Enter);
        messageBox.SendKeys(Keys.Enter);
        Thread.Sleep(15000);

    }

    static void Reset(IWebDriver driver)
    {

        driver.Navigate().GoToUrl("https://web.whatsapp.com/");
        Thread.Sleep(8000);
        // Encontre a caixa de pesquisa e pesquise pelo usuário "nabaaau"
        IWebElement searchBox = driver.FindElement(By.XPath("//div[@contenteditable='true']"));
        searchBox.SendKeys("nabaaau" + Keys.Enter);
        Thread.Sleep(10000);
        IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));
        messageBox.SendKeys("Oi seja bem vindo ao bot bil! " + Keys.Enter);
        messageBox.SendKeys("aqui temos algumas opções de automações " + Keys.Enter);
        messageBox.SendKeys("como por exemplo, logar no instagram(1).... gerar qrcode(2),basta digitar o número que acompanha cada função para realiza-la.  " + Keys.Enter);
        messageBox.SendKeys(Keys.Enter);
        Thread.Sleep(8000);

    }

}
