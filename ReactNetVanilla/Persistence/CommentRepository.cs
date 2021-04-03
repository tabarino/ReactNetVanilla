using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReactNetVanilla.Core;
using ReactNetVanilla.Core.Models;

namespace ReactNetVanilla.Persistence
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ReactNetDbContext _context;

        public CommentRepository(ReactNetDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Comment>> GetComments()
        {
            return await _context.Comments.ToListAsync();
        }

        public void Add(Comment vehicle)
        {
            _context.Comments.Add(vehicle);
        }

        public void Remove(Comment vehicle)
        {
            _context.Remove(vehicle);
        }
    }
}
