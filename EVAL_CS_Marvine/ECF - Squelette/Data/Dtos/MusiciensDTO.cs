using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Data.Dtos
{
    public class MusiciensDTOOut
    {
        public int IdMusicien { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Instrument { get; set; }
        public int IdGroupe { get; set; }
    }
    public class MusiciensDTOOutAvecGroupe
    {
        public int IdMusicien { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Instrument { get; set; }
        public int IdGroupe { get; set; }
        public string NomDuGroupe { get; set; }
    }
    public class MusiciensDTOIn
    {
        public int IdMusicien { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Instrument { get; set; }
        public int IdGroupe { get; set; }
    }
}
