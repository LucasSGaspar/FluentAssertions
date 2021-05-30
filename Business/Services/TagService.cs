using Business.Interfaces;
using Business.Models;
using Business.Models.Validations;
using System.Threading.Tasks;

namespace Business.Services
{
    public class TagService : BaseService, ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository, INotificador notificador) : base(notificador)
        {
            _tagRepository = tagRepository;
        }

        public async Task<Tag> Adicionar(Tag tag)
        {
            if (!ExecutarValidacao(new TagValidation(), tag))
                return null;

            if (await _tagRepository.ExistTagWithName(tag.Nome))
            {
                Notificar("Já existe uma tag com esse nome cadastrada");
                return null;
            }

            return await _tagRepository.Adicionar(tag);
        }
    }
}
