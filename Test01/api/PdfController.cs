using System.Web.Http;

namespace Test01.api
{
    public class PdfController : ApiController
    {


        // GET: api/Pdf/5
        public string Get(string url)
        {
            return $"Haz metio {url}";
        }
    }
}
