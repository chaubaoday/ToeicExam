using System;
using System.Threading;
using System.Threading.Tasks;


namespace Examination.Domain.SeedWork
{
    //quna lys giao dich xac nhan du lieu 1 cach nhat quan
    public interface IUnitOfWork : IDisposable
    {
        Task SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}