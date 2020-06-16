using System;
using System.Collections.Generic;
using System.Text;

namespace bibliothequeData.Models
{
    public class Patron
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public DateTime DateDeN { get; set; }
        //public virtual BibliothequeCarte BibliothequeCarte { get; set; }
    }
}
