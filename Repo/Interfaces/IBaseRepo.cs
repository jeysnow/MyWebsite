using System;
using System.Collections.Generic;
using System.Text;

namespace Repo.Interfaces
{
    public interface IBaseRepo<T> where T:class
    {
        ICollection<T> FindAll();
        T FindById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Save();
        bool IsExists(int id);
    }
}
