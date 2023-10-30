// Fonction pour obtenir le panier depuis le stockage local
function getPanierFromLocalStorage() {
    var panierJson = localStorage.getItem('panier');
    if (panierJson) {
        return JSON.parse(panierJson);
    } else {
        return [];
    }
}

// Fonction pour enregistrer le panier dans le stockage local
function enregistrerPanierDansLocalStorage(panier) {
    var panierJson = JSON.stringify(panier);
    localStorage.setItem('panier', panierJson);
}

// Fonction pour ajouter un produit au panier
function ajouterProduitAuPanier(produit) {
    var panier = getPanierFromLocalStorage();
    panier.push(produit);
    enregistrerPanierDansLocalStorage(panier);
}

// Fonction pour supprimer un produit du panier
function supprimerProduitDuPanier(produitID) {
    var panier = getPanierFromLocalStorage();
    var index = -1;
    for (var i = 0; i < panier.length; i++) {
        if (panier[i].ProduitID === produitID) {
            index = i;
            break;
        }
    }
    if (index !== -1) {
        panier.splice(index, 1);
        enregistrerPanierDansLocalStorage(panier);
    }
}