// See https://aka.ms/new-console-template for more information
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

Console.WriteLine("Hello, World!");
string pdfFilePath = @"C:\Users\victor\Downloads\Documento.pdf";
string wordFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", System.IO.Path.GetFileNameWithoutExtension(pdfFilePath) + ".docx");
ConvertWordToPdf(wordFilePath, pdfFilePath);
//ConvertPdfToWord(wordFilePath, pdfFilePath);
void ConvertPdfToWord(string wordFilePath, string pdfFilePath)
{
    pdfFilePath = @"C:\Users\victor\Downloads\DocumentoPDF.pdf";
    wordFilePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", System.IO.Path.GetFileNameWithoutExtension(pdfFilePath) + ".docx");
    using (var pdfReader = new PdfReader(pdfFilePath))
    {
        var wordDocument = new iTextSharp.text.Document();

        var wordWriter = new FileStream(wordFilePath, FileMode.Create);

        var wordTextWriter = new StreamWriter(wordWriter);
        // Ler cada linha do arquivo pdf e escrever no documento word

        for (int page = 1; page <= pdfReader.NumberOfPages; page++)
        {
            var pdfText = PdfTextExtractor.GetTextFromPage(pdfReader, page, new LocationTextExtractionStrategy());

            wordTextWriter.WriteLine(pdfText);
        }

        wordTextWriter.Close();

        wordWriter.Close();
    }

}

void ConvertWordToPdf(string wordFilePath, string pdfFilePath)
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


