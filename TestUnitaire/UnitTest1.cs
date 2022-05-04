using System;
using System.Collections.Generic;
using System.Linq;
using BusinessService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ressources.DTO;
using MedEvh.Models;
using MedEvh;

namespace TestUnitaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetProduitById_ShouldReturnCorrectProduct()
        {
            ProduitServices service = new ProduitServices();
            ProduitModel dto = new ProduitModel();
            dto = service.GetProduitById(1);

            Assert.IsNotNull(dto);
            Assert.AreEqual(dto, new ProduitModel() { Id = 1, Libelle = "Doliprane", PrixHt = 12, TauxTva = 2 });
        }
        [TestMethod]
        public void GetProduits_ShouldReturnCorrectProduct()
        {
            ProduitServices service = new ProduitServices();
            Controllers.ProduitController controller = new Controllers.ProduitController();
            var result = controller.GetProduits();
            List<ProduitDto> liste = new List<ProduitModel>();
            liste = service.GetProduits() as List<ProduitModel>;

            Assert.AreEqual(liste.Select(x => x.Id = 1), new ProduitModel() { Id = 1, Libelle = "Doliprane", PrixHt = 12, TauxTva = 2 });
            Assert.AreEqual(liste.Count, result.Count);
        }
    }
}
