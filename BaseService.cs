using Lena.Core.Entity;
using Lena.Core.Service;
using LenaProject.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lena.Service.Base
{
    public class BaseService<T> : ICoreService<T> where T: CoreEntity
    {
        private static ProjectContext _context;

        public ProjectContext context
        {
            get {
                if (_context == null)               
                    _context = new ProjectContext();
                    return _context;
            }
            set
            {
                _context = value;
            }
        }

        public bool Add(T item) 
        {
            context.Set<T>().Add(item);
            return Save()>0;
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return context.Set<T>().Any(exp);
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

       public T GetByDefault(Expression<Func<T, bool>> exp)
         {
           return context.Set<T>().Where(exp).FirstOrDefault();
         }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetContaining(Expression<Func<T, bool>> exp)
        {
            return context.Set<T>().Where(exp).ToList();
        }

        public int Save()
        {
            return context.SaveChanges();
        }
    }
}
