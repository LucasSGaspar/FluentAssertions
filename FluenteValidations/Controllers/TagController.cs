using AutoMapper;
using Business.Interfaces;
using Business.Models;
using FluenteValidations.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FluenteValidations.Controllers
{
    [Route("api/[controller]")]
    public class TagController : MainController
    {
        private readonly IMapper _mapper;
        private readonly ITagRepository _tagRepository;
        private readonly ITagService _tagService;

        public TagController(IMapper mapper, ITagRepository tagRepository, ITagService tagService, INotificador notificador) : base(notificador)
        {
            _mapper = mapper;
            _tagRepository = tagRepository;
            _tagService = tagService;
        }

        [HttpGet]
        public async Task<ActionResult<List<TagViewModel>>> BuscarTodos()
        {
            // Como um obter todos é muito simples, não é necessário passar pela camada de negócio. Basta apenas chamar o repositório
            return _mapper.Map<List<TagViewModel>>(await _tagRepository.ObterTodos());
        }

        [HttpPost]
        public async Task<ActionResult<TagViewModel>> Adicionar(TagViewModel tagViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            var tag = await _tagService.Adicionar(_mapper.Map<Tag>(tagViewModel));

            return CustomResponse(_mapper.Map<TagViewModel>(tag));
        }
    }
}
