using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8
{
    public class PenRepository : Repository<Pen>, IPenRepository
    {
        private readonly XContext _xContext;
        public PenRepository(XContext xContext) : base(xContext)
        {
            _xContext = xContext;
        }
    }
}
