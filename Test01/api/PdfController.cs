using System;
using System.IO;
using System.Web.Http;

namespace Test01.api
{
    public class PdfController : ApiController
    {
        //public actionre Get(string key)
        //{

        //}
        
        [HttpPost]
        public Resultado Post(string url)
        {
            string directorio = $"D:\\PdfGen\\{DateTime.Now:yyyy-MM-dd}";
            string key = $"{Guid.NewGuid()}";
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
                    OutputFilePath = $"{directorio}\\{key}.pdf"
                });

                // Pasamso a base64
                //byte[] bytes = File.ReadAllBytes(pdfBase64);
                //pdfBase64 = Convert.ToBase64String(bytes);

                return Resultado.Si(key);
            }
            catch (Exception ex)
            {
                return Resultado.No($"Ah ocurrido un error; {ex.Message}");
            }
        }
    }
}
