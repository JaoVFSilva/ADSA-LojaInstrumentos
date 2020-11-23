using AutoMapper;
using Loja.Instrumentos.Business;
using Loja.Instrumentos.Web.ViewModels.Particulars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Instrumentos.Web.AutoMapper
{
    public class BusinessToViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Particulars, ParticularsIndexViewModel>()
                .ForMember(p => p.Nome, opt => {

                    opt.MapFrom(src =>
                        string.Format("{0} {4}", src.Nome, src.Marca)
                        );

                });
            Mapper.CreateMap<Particulars, ParticularsViewModel>();
        }
    }
}