using System;
using System.Web.UI;

namespace Test01
{
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //    string localFile = $"D:\\pdf\\{Guid.NewGuid()}.pdf";
            //    try
            //    {
            //        DateTime a = DateTime.Now;
            //        PdfConvert.ConvertHtmlToPdf(new PdfDocument
            //        {
            //            Url = "https://www.google.com.ve/"

            //        }, new PdfOutput
            //        {
            //            OutputFilePath = localFile
            //        });
            //        DateTime b = DateTime.Now;

            //        var diferencia = b - a;
            //        Label1.Text = $"{diferencia.TotalMilliseconds:n2}";

            //        byte[] bytes01 = File.ReadAllBytes(localFile);
            //        var stringBase64Serialize = Convert.ToBase64String(bytes01);

            //        byte[] bytes02 = Convert.FromBase64String(stringBase64Serialize);
            //        File.WriteAllBytes(@"D:\asdasdasdasdasdasdasasdasd.pdf", bytes02);
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine(exception);
            //    }
        }
    }
}