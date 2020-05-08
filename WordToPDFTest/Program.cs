using System;
using DocXToPdfConverter;
using WordToPDF;

namespace WordToPDFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string locationOfLibreOfficeSoffice =
                @"C:\Users\Hasan\Downloads\Programs\LibreOfficePortable\App\libreoffice\program\soffice.exe";

            var test = new ReportGenerator(locationOfLibreOfficeSoffice);

            test.Convert(@"‪C:\Users\Hasan\Desktop\dummy.docx", @"‪C:\Users\Hasan\Desktop\dummy.pdf");
        }
    }
}