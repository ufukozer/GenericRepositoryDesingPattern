using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8
{
    public class PencilRepository : Repository<Pencil>, IPencilRepository
    {
        private readonly XContext _xContext;
        public PencilRepository(XContext xContext) : base(xContext)
        {
            _xContext = xContext;
        }
    }
}
