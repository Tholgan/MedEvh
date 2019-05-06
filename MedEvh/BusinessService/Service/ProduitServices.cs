using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessService.DataSet.DataSetTableAdapters;
using MedEvh; 
using MedEvh.Models;
using MedEvh.Ressources;


namespace BusinessService
{
    public class ProduitServices
    {
        public ProduitModel GetProduitById(int id)
        {
            ProduitTableAdapter produitTableAdapter = new ProduitTableAdapter();
            var produitDto = CopyHelper.ToDtoProduit(produitTableAdapter.GetById(id));
            return new MedEvh.Models.ProduitModel()
            {
                Id = produitDto.Id,
                Libelle = produitDto.Libelle,
                Prix = produitDto.PrixHt * produitDto.TauxTva
            };

        }

        public List<MedEvh.Models.ProduitModel> GetProduits()
        {
            ProduitTableAdapter produitTableAdapter = new ProduitTableAdapter();
            var produitsDto = CopyHelper.ToListDtoProduit(produitTableAdapter.GetWithTva());
            var produitsModel = new List<MedEvh.Models.ProduitModel>();

            foreach(Ressources.DTO.ProduitModel produitDto in produitsDto)
            {
                var produitModel = new MedEvh.Models.ProduitModel()
                {
                    Id = produitDto.Id,
                    Libelle = produitDto.Libelle,
                    Prix = produitDto.PrixHt * produitDto.TauxTva
                };
                produitsModel.Add(produitModel);
            }

            return produitsModel;
        }
    }
}
