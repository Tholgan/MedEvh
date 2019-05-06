using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessService.DataSet.DataSetTableAdapters;
using MedEvh; 
using Ressources.DTO;
using MedEvh.Models;

namespace BusinessService
{
    public class ProduitServices
    {
        public ProduitModel GetProduitById(int id)
        {
            ProduitTableAdapter produitTableAdapter = new ProduitTableAdapter();
            var produitDto = CopyHelper.ToDtoProduit(produitTableAdapter.GetById(id));
            return new ProduitModel()
            {
                Id = produitDto.Id,
                Libelle = produitDto.Libelle,
                Prix = produitDto.PrixHt * produitDto.TauxTva
            };

        }

        public List<ProduitModel> GetProduits()
        {
            ProduitTableAdapter produitTableAdapter = new ProduitTableAdapter();
            var produitsDto = CopyHelper.ToListDtoProduit(produitTableAdapter.GetWithTva());
            var produitsModel = new List<ProduitModel>();

            foreach(ProduitDto produitDto in produitsDto)
            {
                var produitModel = new ProduitModel()
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
