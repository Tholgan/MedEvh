using System;
using System.Collections.Generic;
using System.Linq;
using BusinessService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ressources.DTO;

namespace TestUnitaire
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetProduitById_ShouldReturnCorrectProduct()
        {
            ProduitServices service = new ProduitServices();
            ProduitDto dto = new ProduitDto();
            dto = service.GetProduitById(1);

            Assert.IsNotNull(dto);
            Assert.AreEqual(dto, new ProduitDto() { Id = 1, Libelle = "Doliprane", PrixHt = 12, TauxTva = 2 });
        }
        [TestMethod]
        public void GetProduits_ShouldReturnCorrectProduct()
        {
            ProduitServices service = new ProduitServices();
            var result = "coucouc";
            List<ProduitDto> liste = new List<ProduitDto>();
            liste = service.GetProduits() as List<ProduitDto>;

            Assert.AreEqual(liste.Select(x => x.Id = 1), new ProduitDto() { Id = 1, Libelle = "Doliprane", PrixHt = 12, TauxTva = 2 });
            Assert.AreEqual(liste.Count, result.Count);
        }
    }
}
