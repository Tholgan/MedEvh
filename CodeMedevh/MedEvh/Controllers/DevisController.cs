using Microsoft.AspNetCore.Mvc;

namespace MedEvh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevisController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetDevis()
        {
            //pour transformer une page Html en pdf 
            //HtmlToPdf converter = new HtmlToPdf();
            //PdfDocument doc = converter.ConvertUrl("monUrl");
            //doc.Save("test.pdf");

            //doc.Close();
            string coucou = "coucou";
            if (coucou == "")
            {
                return NotFound();
            }
            return Ok(coucou);
        }
    }
}