using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ressources.DTO
{
    public class ProduitModel
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public float PrixHt { get; set; }
        public float TauxTva { get; set; }
    }
}
