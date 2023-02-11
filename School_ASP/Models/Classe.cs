using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_ASP.Models
{
    public class Classe
    {
        public int id { get; set; }
        public string libelle { get; set; }
        public ICollection<Etudiant> etudiants { get; set; }
    }
}