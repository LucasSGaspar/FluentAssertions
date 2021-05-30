using Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ITagRepository
    {
        Task<List<Tag>> ObterTodos();

        Task<Tag> Adicionar(Tag tag);

        Task<bool> ExistTagWithName(string nome);
    }
}
