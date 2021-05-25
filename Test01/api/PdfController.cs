using System;
using System.IO;
using System.Web.Http;

namespace Test01.api
{
    public class PdfController : ApiController
    {
        public Resultado Post(string url)
        {
            string directorio = $"C:\\PdfGen\\{DateTime.Now:yyyy-MM-dd}";
            string pdfBase64 = $"{directorio}\\{Guid.NewGuid()}.pdf";
            try
            {
                // Validamosdirectorio
                if (!Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }

                // Convertimos
                PdfConvert.ConvertHtmlToPdf(new PdfDocument
                {
                    Url = url

                }, new PdfOutput
                {
                    OutputFilePath = pdfBase64
                });

                // Pasamso a base64
                byte[] bytes = File.ReadAllBytes(pdfBase64);
                pdfBase64 = Convert.ToBase64String(bytes);

                return Resultado.Si(pdfBase64);
            }
            catch (Exception ex)
            {
                return Resultado.No($"Ah ocurrido un error; {ex.Message}");
            }
        }
    }
}
