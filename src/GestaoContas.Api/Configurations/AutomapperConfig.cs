﻿using AutoMapper;
using GestaoContas.Api.V1.ViewModels.Categorias;
using GestaoContas.Api.V1.ViewModels.Orcamento;
using GestaoContas.Api.V1.ViewModels.Transacao;
using GestaoContas.Api.V1.ViewModels.Usuarios;
using GestaoContas.Shared.Domain;

namespace GestaoContas.Api.Configurations
{
    public class AutomapperConfig:Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Usuario,UsuarioViewModel>().ReverseMap();
            CreateMap<Categoria, CategoriaViewModel>().ForMember(c => c.Ativo, ca => ca.MapFrom(x => x.Padrao)).ReverseMap();
            CreateMap<Categoria, CategoriaCriarViewModel>().ReverseMap();
            CreateMap<Categoria, CategoriaEditarViewModel>().ReverseMap();
            CreateMap<Transacao, TransacaoViewModel>().ReverseMap();
            CreateMap<Orcamento, OrcamentoViewModel>()
            .ForMember(dest => dest.CategoriaNome, opt => opt.MapFrom(src => src.Categoria.Nome))
            .ForMember(dest => dest.UsuarioNome, opt => opt.MapFrom(src => src.Usuario.Nome));

            CreateMap<OrcamentoCriarViewModel, Orcamento>();
            CreateMap<OrcamentoEditarViewModel, Orcamento>();


        }
    }
}
