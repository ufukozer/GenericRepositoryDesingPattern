using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly XContext _xContext;

        public Repository(XContext xContext)
        {
            _xContext = xContext;
        }

        public void Add(T model)
        {
            throw new NotImplementedException();
        }

        public T Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
