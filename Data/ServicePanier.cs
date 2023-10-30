using E_CommerceApp.Models;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace E_CommerceApp.Data
{
    public class ServicePanier
    {
        private readonly IJSRuntime _jsRuntime;

        public ServicePanier(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task AjouterProduitAuPanier(Panier panier, int produitID, int quantite)
        {
            // Appeler une fonction JavaScript pour ajouter le produit au panier dans le stockage local
            await _jsRuntime.InvokeVoidAsync("ajouterProduitAuPanier", produitID, quantite);
        }

        public async Task SupprimerProduitDuPanier(Panier panier, int produitID)
        {
            // Appeler une fonction JavaScript pour supprimer le produit du panier dans le stockage local
            await _jsRuntime.InvokeVoidAsync("supprimerProduitDuPanier", produitID);
        }

        public async Task MettreAJourQuantiteProduit(Panier panier, int produitID, int nouvelleQuantite)
        {
            // Appeler une fonction JavaScript pour mettre à jour la quantité du produit dans le stockage local
            await _jsRuntime.InvokeVoidAsync("mettreAJourQuantiteProduit", produitID, nouvelleQuantite);
        }

        public async Task<Panier> GetPanierFromLocalStorage()
        {
            // Appeler une fonction JavaScript pour récupérer le panier depuis le stockage local
            var panierJson = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "Panier");

            if (!string.IsNullOrEmpty(panierJson))
            {
                // Désérialiser le panier depuis le stockage local
                return JsonConvert.DeserializeObject<Panier>(panierJson);
            }

            return null;
        }

        public async Task EnregistrerPanierInLocalStorage(Panier panier)
        {
            // Sérialiser le panier en JSON
            var panierJson = JsonConvert.SerializeObject(panier);

            // Appeler une fonction JavaScript pour stocker le panier dans le stockage local
            await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "Panier", panierJson);
        }
    }
}