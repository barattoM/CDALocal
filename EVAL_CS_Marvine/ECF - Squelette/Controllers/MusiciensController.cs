using AutoMapper;
using ECF.Data;
using ECF.Data.Dtos;
using ECF.Data.Models;
using ECF.Data.Profiles;
using ECF.Data.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECF.Controllers
{
    class MusiciensController
    {

        private readonly MusiciensServices _service;
        private readonly IMapper _mapper;

        public MusiciensController(EcfContext _context)
        {
            _service = new MusiciensServices(_context);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MusiciensProfiles>();
                cfg.AddProfile<GroupesProfiles>();
                
            });
            _mapper = config.CreateMapper();
        }


        public IEnumerable<MusiciensDTOOut> GetAllMusiciens()
        {
            IEnumerable<Musicien> listeMusiciens = _service.GetAllMusiciens();
            return _mapper.Map<IEnumerable<MusiciensDTOOut>>(listeMusiciens);
        }

        public IEnumerable<MusiciensDTOOutAvecGroupe> GetAllMusiciensAvecGroupe()
        {
            IEnumerable<Musicien> listeMusiciens = _service.GetAllMusiciens();
            return _mapper.Map<IEnumerable<MusiciensDTOOutAvecGroupe>>(listeMusiciens);
        }

        public MusiciensDTOOut GetMusicienById(int id)
        {
            Musicien commandItem = _service.GetMusicienById(id);
            if (commandItem != null)
            {
                return _mapper.Map<MusiciensDTOOut>(commandItem);
            }
            return null;
        }

        public void CreateMusicien(MusiciensDTOIn objIn)
        {
            Musicien obj = _mapper.Map<Musicien>(objIn);
            _service.AddMusicien(obj);
        }

        
        public bool UpdateMusicien(int id, MusiciensDTOIn obj)
        {
            Musicien objFromRepo = _service.GetMusicienById(id);
            if (objFromRepo == null)
            {
                return true;
            }
            _mapper.Map(obj, objFromRepo);
            _service.UpdateMusicien(objFromRepo);
            return false;
        }

        
        public bool DeleteMusicien(int id)
        {
            Musicien obj = _service.GetMusicienById(id);
            if (obj == null)
            {
                return false;
            }
            _service.DeleteMusicien(obj);
            return true;
        }


    }
}
