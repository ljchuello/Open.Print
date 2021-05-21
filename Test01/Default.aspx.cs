using System;
using System.Web.UI;
using Codaxy.WkHtmlToPdf;

namespace Test01
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime a = DateTime.Now;
                PdfConvert.ConvertHtmlToPdf(new PdfDocument
                {
                    Url = "https://github.com/"

                }, new PdfOutput
                {
                    OutputFilePath = $"D:\\pdf\\{Guid.NewGuid()}.pdf"
                });
                DateTime b = DateTime.Now;

                var diferencia = b - a;
                Label1.Text = $"{diferencia.TotalMilliseconds:n2}";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}