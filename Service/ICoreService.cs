using Lena.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lena.Core.Service
{
    public interface ICoreService<T> where T:CoreEntity
    {
        T GetByID(int id);
        T GetByDefault(Expression<Func<T, bool>> exp);        
        bool Any(Expression<Func<T, bool>> exp);
        bool Add(T item);
        List<T> GetAll();
        List<T> GetContaining(Expression<Func<T, bool>> exp);
        int Save();
        
    }
}
