using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReactNetVanilla.Core.Models;

namespace ReactNetVanilla.Core
{
    public interface ICommentRepository
    {
        Task<IList<Comment>> GetComments();
    }
}
