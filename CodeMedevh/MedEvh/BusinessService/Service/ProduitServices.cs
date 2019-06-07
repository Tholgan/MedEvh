using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using MedEvh; 
using MedEvh.Models;
using MedEvh.Ressources;
using MySql.Data.MySqlClient;
using Ressources.DTO;

namespace BusinessService
{
    public class ProduitServices
    {
        private ProduitDAO produitDAO;

        private void Init()
        {
            produitDAO = new ProduitDAO();
        }
        public ProduitModel GetProduitById(int id)
        {
            var reader = produitDAO.GetProduitById(id);
            ProduitModel produitModel = new ProduitModel();
            while (reader.Read())
            {
                produitModel.Id = Convert.ToInt32(reader[0]);
                produitModel.Libelle = reader[1].ToString();
                produitModel.Prix = float.Parse(reader[2].ToString()) * float.Parse(reader[3].ToString()); 
            }
            produitDAO.connection.Close(); 

            return produitModel;
        }

        public List<ProduitModel> GetProduits()
        {
            var reader = produitDAO.GetProduits(); 
            List<ProduitModel> listProduits = new List<ProduitModel>();
            while (reader.Read())
            {
                var produitModel = new ProduitModel()
                {
                    Id = Convert.ToInt32(reader[0]),
                    Libelle = reader[1].ToString(),
                    Prix = float.Parse(reader[2].ToString()) * float.Parse(reader[3].ToString())
                };
                listProduits.Add(produitModel);
            }
            produitDAO.connection.Close();
            
            return listProduits; 
        }
    }
}
