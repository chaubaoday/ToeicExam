using System.Threading;
using System.Threading.Tasks;

namespace Examination.Domain.SeedWork
{
    //cung cap cac phuon thuc co ban thuc hien CRUD
    public interface IRepositoryBase<T> where T : IAggregateRoot
    {
        Task InsertAsync(T obj);

        Task UpdateAsync(T obj);

        Task DeleteAsync(string id);

    }
}