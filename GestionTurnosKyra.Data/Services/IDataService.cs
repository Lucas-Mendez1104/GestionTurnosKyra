using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionTurnosKyra.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Get(int id);
        Task<IEnumerable<T>> Create(T entity);
        Task<IEnumerable<T>> Update(int id, T entity);
        Task<bool> Delete(int id);
    }
}
