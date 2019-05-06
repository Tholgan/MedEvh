using BusinessService;
using MedEvh.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MedEvh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private ProduitServices _produitServices;

        public ProduitController(ProduitServices produitServices)
        {
            _produitServices = produitServices;
        }

        [HttpGet("{id}")]
        public ActionResult<ProduitModel> GetProduitById(int id)
        {
            return Ok(_produitServices.GetProduitById(id));
        }

        [HttpGet]
        public ActionResult<List<ProduitModel>> GetProduits()
        {
            return Ok( _produitServices.GetProduits());
        }
    }
}