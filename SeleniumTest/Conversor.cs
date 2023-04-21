using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    public class Conversor
    {
        public void ConverterPdfToWord(IWebDriver driver, IWebElement messageContainer)
        {
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@contenteditable='true'][@data-tab='10']"));
            messageBox.SendKeys("Digite o nome do documento que se encontra na pasta Downloads:" + Keys.Enter);
            List<IWebElement> listademensagens = messageContainer.FindElements(By.ClassName("focusable-list-item")).ToList();
            var ultimamensagem = listademensagens.LastOrDefault();
            string ultimamensagemdetexto = ultimamensagem.FindElement(By.ClassName("_11JPr")).Text;
            while (ultimamensagemdetexto == "Digite o nome do documento que se encontra na pasta Downloads:")
            {
                Thread.Sleep(4000);

                IWebElement messageContainer4 = driver.FindElement(By.CssSelector("div[data-tab='8']"));
                List<IWebElement> listademensagens4 = messageContainer4.FindElements(By.ClassName("focusable-list-item")).ToList();
                IWebElement ultimamensagem4 = listademensagens4.LastOrDefault();
                ultimamensagemdetexto = ultimamensagem4.FindElement(By.ClassName("_11JPr")).Text;
            }


            string pdfpath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", ultimamensagemdetexto);
            //string pdfpath = @"C:\Users\victor\Downloads\DocumentoPDF.pdf";
            string wordpath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", System.IO.Path.GetFileNameWithoutExtension(pdfpath) + ".docx");
            using (var pdfReader = new PdfReader(pdfpath))
            {
                var wordDocument = new iTextSharp.text.Document();

                var wordWriter = new FileStream(wordpath, FileMode.Create);

                var wordTextWriter = new StreamWriter(wordWriter);
                // Ler cada linha do arquivo pdf e escrever no documento word

                for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                {
                    var pdfText = PdfTextExtractor.GetTextFromPage(pdfReader, page, new LocationTextExtractionStrategy());

                    wordTextWriter.WriteLine(pdfText);
                }

                wordTextWriter.Close();

                wordWriter.Close();

                // Encontre o botão "Anexar" e clique nele
                IWebElement attachButton = driver.FindElement(By.XPath("//div[@title='Anexar']"));
                attachButton.Click();

                // Encontre a opção "Documento" e clique nela
                IWebElement inputFile = driver.FindElement(By.XPath("//input[@type='file']"));
                inputFile.SendKeys(wordpath);

                // Aguarde alguns segundos antes de enviar o arquivo
                System.Threading.Thread.Sleep(3000);

                // Encontre o botão "Enviar" e clique nele
                IWebElement sendButton = driver.FindElement(By.CssSelector("span[data-testid='send']"));
                sendButton.Click();



            }
        }

        public void ConverterWordToPdf(string pdfFilePath, string wordFilePath)
        {
            wordFilePath = @"C:\Users\victor\Downloads\DocumentoWORD.docx";
            pdfFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", System.IO.Path.GetFileNameWithoutExtension(wordFilePath) + ".pdf");

            var wordReader = new StreamReader(wordFilePath);

            var pdfDocument = new iTextSharp.text.Document();

            var pdfWriter = PdfWriter.GetInstance(pdfDocument, new FileStream(pdfFilePath, FileMode.Create));

            pdfDocument.Open();

            // TEST DE ITERACAO
            while (!wordReader.EndOfStream)
            {
                var line = wordReader.ReadLine();
                pdfDocument.Add(new Paragraph(line));
            }

            wordReader.Close();

            pdfDocument.Close();
        }

    }
}
