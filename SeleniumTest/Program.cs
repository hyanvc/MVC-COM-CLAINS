using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://web.whatsapp.com/");

        Thread.Sleep(15000);
        // Encontre a caixa de pesquisa e pesquise pelo usuário "nabaaau"
        IWebElement searchBox = driver.FindElement(By.XPath("//div[@contenteditable='true']"));
        searchBox.SendKeys("orkut" + Keys.Enter);
        Thread.Sleep(10000);

        // Aguarde o chat do usuário carregar
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        Thread.Sleep(10000);
        while (true)
        {
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));
            messageBox.SendKeys(" vou te enviar mensagens a cada 10 secs." + Keys.Enter);
            Thread.Sleep(10000);
        }


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
