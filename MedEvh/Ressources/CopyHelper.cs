using Ressources.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace MedEvh.Ressources
{
    public static class CopyHelper
    {

        public static ProduitModel ToDtoProduit(DataTable dataTable)
        {
            ProduitModel dtoProduit = new ProduitModel();
            DataRowCollection rows = dataTable.Rows;
            DataColumnCollection columns = dataTable.Columns;
            
            dtoProduit.Id = Convert.ToInt32(rows[0]["idProduit"]);
            dtoProduit.Libelle = rows[0]["libelleProduit"].ToString();
            dtoProduit.PrixHt = Convert.ToSingle(rows[0]["prixHtProduit"]);
            dtoProduit.TauxTva = Convert.ToSingle(rows[0]["tauxTva"]); 

            return dtoProduit;
        }

        public static List<ProduitModel> ToListDtoProduit(DataTable dataTable)
        {
            List<ProduitModel> listDtoProduit = new List<ProduitModel>();
            DataRowCollection rows = dataTable.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                ProduitModel produitDto = new ProduitModel();
                produitDto.Id = Convert.ToInt32(rows[i]["idProduit"]);
                produitDto.Libelle = rows[i]["libelleProduit"].ToString();
                produitDto.PrixHt = Convert.ToSingle(rows[i]["prixHtProduit"]);
                produitDto.TauxTva = Convert.ToSingle(rows[i]["tauxTva"]);
                listDtoProduit.Add(produitDto);
            }
            return listDtoProduit;
        }
    }
}
