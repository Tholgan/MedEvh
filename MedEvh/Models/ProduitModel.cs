using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedEvh.Models
{
    public class ProduitModel
    {
        public int Id { get; set; }

        public string Libelle { get; set; }

        public float Prix { get; set; }
    }
}