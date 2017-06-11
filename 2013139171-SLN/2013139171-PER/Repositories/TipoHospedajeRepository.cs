using _2013139171_ENT;
using _2013139171_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_PER.Repositories
{
    public class TipoHospedajeRepository : Repository<TipoHospedaje>, ITipoHospedajeRepository
    {
        public TipoHospedajeRepository(_2013139171DbContext _context): base (_context)
            {

        }
    }
}
