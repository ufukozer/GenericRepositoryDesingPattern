using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8
{
    public class BoardRepository : Repository<Board>, IBoardRepository
    {
        private readonly XContext _xContext;
        public BoardRepository(XContext xContext) : base(xContext)
        {
            _xContext = xContext;
        }
    }
}
