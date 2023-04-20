using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using QRCoder;
using SeleniumTest;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        Reset(driver);
        Mainreset(driver);
    }

    public static void Mainreset(IWebDriver driver)
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
                InstagramAUTO iauto = new InstagramAUTO();
                iauto.instagramAUTO(driver, messageContainer);
            }

            if (ultimamensagemdetexto != null && ultimamensagemdetexto == "2")
            {
                qrcodeAUTO qrc = new qrcodeAUTO();
                qrc.QrcodeAUTO(driver,ultimamensagemdetexto,messageContainer);
            }


            if (ultimamensagemdetexto != null && ultimamensagemdetexto == "3")
            {
                InstagramSeguidores instagramSeguidores = new InstagramSeguidores();
                instagramSeguidores.instagramAUTO(driver, messageContainer);
            }


            Thread.Sleep(6000);

        }

    }

    public static void Reset2(IWebDriver driver)
    {
        //driver.Navigate().GoToUrl("https://web.whatsapp.com/");
        //Thread.Sleep(15000);
        // Encontre a caixa de pesquisa e pesquise pelo usuário "nabaaau"
        Thread.Sleep(15000);
        IWebElement searchBox = driver.FindElement(By.XPath("//div[@contenteditable='true']"));
        searchBox.SendKeys("nabaaau" + Keys.Enter);
        IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));

        messageBox.SendKeys("Oi seja bem vindo " + Keys.Enter);
        Thread.Sleep(1000);
        messageBox.SendKeys("aqui temos algumas opções de automações " + Keys.Enter);
        Thread.Sleep(1000);
        messageBox.SendKeys("como por exemplo, logar no instagram(1) ( indisponivel).... gerar qrcode(2), ganhar um seguidor(3) basta digitar o número que acompanha cada função para realiza-la.  " + Keys.Enter);
        Thread.Sleep(1000);
        messageBox.SendKeys(Keys.Enter);

    }

    public static void Reset(IWebDriver driver)
    {

        driver.Navigate().GoToUrl("https://web.whatsapp.com/");
        Thread.Sleep(15000);
        // Encontre a caixa de pesquisa e pesquise pelo usuário "nabaaau"
        IWebElement searchBox = driver.FindElement(By.XPath("//div[@contenteditable='true']"));
        searchBox.SendKeys("nabaaau" + Keys.Enter);
        Thread.Sleep(10000);
        IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));

        messageBox.SendKeys("Oi seja bem vindo! " + Keys.Enter);
        Thread.Sleep(1000);
        messageBox.SendKeys("aqui temos algumas opções de automações " + Keys.Enter);
        Thread.Sleep(1000);
        messageBox.SendKeys("como por exemplo, logar no instagram(1) ( indisponivel).... gerar qrcode(2), ganhar um seguidor(3) basta digitar o número que acompanha cada função para realiza-la.  " + Keys.Enter);
        Thread.Sleep(1000);
        messageBox.SendKeys(Keys.Enter);
    }

}
