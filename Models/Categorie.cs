﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_CommerceApp.Models
{
    [Table("CATEGORIES")]
    public class Categorie
    {
        [Key]
        public int CategorieID { get; set; }
        [Required]
        public string NomCategorie { get; set; }
        public virtual ICollection<Produit>? Produits { get; set; }
    }
}
