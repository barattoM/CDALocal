using ECF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Data.Dtos
{
    public class GroupesDTOOut
    {
        public int IdGroupe { get; set; }
        public string NomDuGroupe { get; set; }
        public int NombreDeFollowers { get; set; }
        public string Logo { get; set; }
    }

    public class GroupesDTOOutAvecMusiciens
    {
        public int IdGroupe { get; set; }
        public virtual ICollection<Musicien> ListeMusiciens { get; set; }
        public string NomDuGroupe { get; set; }
        public int NombreDeFollowers { get; set; }
        public string Logo { get; set; }
    }

    public class GroupesDTOIn
    {
        public string NomDuGroupe { get; set; }
        public int NombreDeFollowers { get; set; }
        public string Logo { get; set; }
    }
}
