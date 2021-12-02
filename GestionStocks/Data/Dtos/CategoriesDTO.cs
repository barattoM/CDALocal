using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStocks.Data.Dtos
{
    class CategoriesDTO
    {
        public string LibelleCategorie { get; set; }
    }

    class CategoriesDTOIn
    {
        public string LibelleCategorie { get; set; }
        public int IdTypeProduit { get; set; }
    }
}
