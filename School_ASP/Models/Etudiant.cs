using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_ASP.Models {
    public class Etudiant {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public Classe classe { get; set; }
    }
}