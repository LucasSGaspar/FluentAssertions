using Business.Interfaces;
using Business.Models;
using Data.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class TagRepository : ITagRepository
    {
        private readonly ApplicationContext _context;

        public TagRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Tag>> ObterTodos()
        {
            return await _context.Tags.AsNoTracking().ToListAsync();
        }

        public async Task<Tag> Adicionar(Tag tag)
        {
            _context.Tags.Add(tag);
            await _context.SaveChangesAsync();
            return tag;
        }

        public Task<bool> ExistTagWithName(string nome)
        {
            return _context.Tags.AnyAsync(t => t.Nome == nome);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
