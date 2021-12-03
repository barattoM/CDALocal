using GestionStocks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStocks.Data.Dtos
{
    public class ArticlesDTO
    {
        public string LibelleArticle { get; set; }
        public int QuantiteStockee { get; set; }
    }

    public class ArticlesDTOAvecLibelleCategorie
    {
        public int IdArticle { get; set; }
        public string LibelleArticle { get; set; }
        public int QuantiteStockee { get; set; }
        public int IdCategorie { get; set; }
        public string LibelleCategorie { get; set; }
    }

    public class ArticlesDTOAvecCategorie
    {
        public string LibelleArticle { get; set; }
        public int QuantiteStockee { get; set; }
        public Categorie Categorie { get; set; }
    }

    public class ArticlesDTOIn
    {
        public string LibelleArticle { get; set; }
        public int QuantiteStockee { get; set; }
        public int IdCategorie { get; set; }
    }

}
