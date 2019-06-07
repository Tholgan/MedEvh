using MySql.Data.MySqlClient;
using Ressources.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProduitDAO
    {
        public MySqlConnection connection = new Connection().GetConnection();

        public MySqlDataReader GetProduitById(int id)
        { 
            connection.Open();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "SELECT Produit.idProduit, Produit.libelleProduit, Produit.prixHtProduit, Tva.tauxTva FROM Produit INNER JOIN Tva ON Tva.idTva = Produit.idTvaProduit WHERE Produit.idProduit=" + id;
            return query.ExecuteReader(); 
        }

        public MySqlDataReader GetProduits()
        { 
            connection.Open();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "SELECT Produit.idProduit, Produit.libelleProduit, Produit.prixHtProduit, Tva.tauxTva FROM Produit INNER JOIN Tva ON Tva.idTva = Produit.idTvaProduit ";
            return query.ExecuteReader();
        }
    }
}
