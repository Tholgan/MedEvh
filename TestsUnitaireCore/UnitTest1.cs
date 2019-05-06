using BusinessService;
using MedEvh.Controllers;
using MedEvh.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace TestsUnitaireCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetProduitById()
        {
            ProduitServices service = new ProduitServices();
            ProduitModel model = new ProduitModel();
            model = service.GetProduitById(1);

            Assert.IsNotNull(model);
            //Assert.AreEqual(dto, new ProduitModel() { Id = 1, Libelle = "Doliprane", Prix = 12});
        }
        [TestMethod]
        public void TestGetProduits()
        {
            ProduitServices service = new ProduitServices();
            ProduitController controller = new ProduitController(service);
            var result = controller.GetProduits();
            List<ProduitModel> liste = new List<ProduitModel>();
            liste = service.GetProduits() as List<ProduitModel>;

            //Assert.AreEqual(liste.Select(x => x.Id = 1), new ProduitModel() { Id = 1, Libelle = "Doliprane", Prix = 12 });
            Assert.AreEqual(liste.Count, 4);
        }
    }
}
