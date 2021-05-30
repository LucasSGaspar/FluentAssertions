using Business.Models;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ITagService
    {
        Task<Tag> Adicionar(Tag tag);
    }
}
