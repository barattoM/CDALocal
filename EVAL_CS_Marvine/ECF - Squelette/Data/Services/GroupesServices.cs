using ECF.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Data.Services
{
    class GroupesServices
    {

        private readonly EcfContext _context;

        public GroupesServices(EcfContext context)
        {
            _context = context;
        }

        public void AddGroupe(Groupe obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Groupes.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteGroupe(Groupe obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Groupes.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Groupe> GetAllGroupes()
        {
            return _context.Groupes.ToList();
        }

        public Groupe GetGroupeById(int id)
        {
            return _context.Groupes.FirstOrDefault(obj => obj.IdGroupe == id);
        }

        public void UpdateGroupe(Groupe obj)
        {
            _context.SaveChanges();
        }


    }
}
