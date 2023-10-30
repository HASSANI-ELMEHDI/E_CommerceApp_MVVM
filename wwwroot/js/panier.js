function ajouterProduitAuPanier(produitID, quantite) {
    // R�cup�rer le panier existant depuis le stockage local
    var panier = JSON.parse(localStorage.getItem("Panier")) || {};

    // Ajouter/Modifier la quantit� du produit dans le panier
    if (panier.hasOwnProperty(produitID)) {
        panier[produitID] += quantite;
    } else {
        panier[produitID] = quantite;
    }

    // Stocker le panier mis � jour dans le stockage local
    localStorage.setItem("Panier", JSON.stringify(panier));
}

function supprimerProduitDuPanier(produitID) {
    // R�cup�rer le panier existant depuis le stockage local
    var panier = JSON.parse(localStorage.getItem("Panier")) || {};

    // Supprimer le produit du panier
    delete panier[produitID];

    // Stocker le panier mis � jour dans le stockage local
    localStorage.setItem("Panier", JSON.stringify(panier));
}

function mettreAJourQuantiteProduit(produitID, nouvelleQuantite) {
    // R�cup�rer le panier existant depuis le stockage local
    var panier = JSON.parse(localStorage.getItem("Panier")) || {};

    // Mettre � jour la quantit� du produit dans le panier
    panier[produitID] = nouvelleQuantite;

    // Stocker le panier mis � jour dans le stockage local
    localStorage.setItem("Panier", JSON.stringify(panier));
}