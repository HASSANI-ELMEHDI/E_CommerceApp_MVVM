namespace E_CommerceApp.Models
{
    public class Panier
    {
        public int PanierID { get; set; }
        public Dictionary<int, int> Produits { get; set; } // Clé: ID du produit, Valeur: Quantité
        // Autres propriétés du panier

        public Panier()
        {
            Produits = new Dictionary<int, int>();
        }
    }
}
