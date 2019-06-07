using AutoMapper;
using Ressources.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace MedEvh.Ressources
{
    public static class CopyHelper
    {

        public static ProduitDto ToDtoProduit(DataTable dataTable)
        {
            ProduitDto dtoProduit = new ProduitDto();
            DataRowCollection rows = dataTable.Rows;
            DataColumnCollection columns = dataTable.Columns;
            
            dtoProduit.Id = Convert.ToInt32(rows[0]["idProduit"]);
            dtoProduit.Libelle = rows[0]["libelleProduit"].ToString();
            dtoProduit.PrixHt = Convert.ToSingle(rows[0]["prixHtProduit"]);
            dtoProduit.TauxTva = Convert.ToSingle(rows[0]["tauxTva"]); 

            return dtoProduit;
        }

        public static List<ProduitDto> ToListDtoProduit(DataTable dataTable)
        {
            List<ProduitDto> listDtoProduit = new List<ProduitDto>();
            DataRowCollection rows = dataTable.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                ProduitDto produitDto = new ProduitDto();
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
