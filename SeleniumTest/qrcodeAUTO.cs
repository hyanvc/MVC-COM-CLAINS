using OpenQA.Selenium;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class qrcodeAUTO
    {
        string qrcode = null;
        public void QrcodeAUTO(IWebDriver driver,string ultimamensagemdetexto, IWebElement messageContainer )
            
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


            var listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
            var ultimamensagem = listademensagens.LastOrDefault();
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
            Program.Reset2(driver);
            Program.Mainreset(driver);

        }
    }
}
