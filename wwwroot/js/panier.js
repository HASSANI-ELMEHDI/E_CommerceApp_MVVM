function ajouterProduitAuPanier(produitID, quantite) {
    // Récupérer le panier existant depuis le stockage local
    var panier = JSON.parse(localStorage.getItem("Panier")) || {};

    // Ajouter/Modifier la quantité du produit dans le panier
    if (panier.hasOwnProperty(produitID)) {
        panier[produitID] += quantite;
    } else {
        panier[produitID] = quantite;
    }

    // Stocker le panier mis à jour dans le stockage local
    localStorage.setItem("Panier", JSON.stringify(panier));
}

function supprimerProduitDuPanier(produitID) {
    // Récupérer le panier existant depuis le stockage local
    var panier = JSON.parse(localStorage.getItem("Panier")) || {};

    // Supprimer le produit du panier
    delete panier[produitID];

    // Stocker le panier mis à jour dans le stockage local
    localStorage.setItem("Panier", JSON.stringify(panier));
}

function mettreAJourQuantiteProduit(produitID, nouvelleQuantite) {
    // Récupérer le panier existant depuis le stockage local
    var panier = JSON.parse(localStorage.getItem("Panier")) || {};

    // Mettre à jour la quantité du produit dans le panier
    panier[produitID] = nouvelleQuantite;

    // Stocker le panier mis à jour dans le stockage local
    localStorage.setItem("Panier", JSON.stringify(panier));
}