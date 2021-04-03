using System;
using System.Threading.Tasks;

namespace ReactNetVanilla.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
