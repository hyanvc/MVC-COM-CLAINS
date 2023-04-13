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



        //// Obter identificadores de janela
        //var windowHandles = driver.WindowHandles;

        //// Trocar para a segunda aba
        //driver.SwitchTo().Window(windowHandles[1]);

        driver.Quit();
    }
}
