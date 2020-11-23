using AutoMapper;
using Loja.Instrumentos.Web.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Loja.Instrumentos.Web.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configuration()
        {
            Mapper.AddProfile<BusinessToViewModelProfile>();
            Mapper.AddProfile<ViewModelToBusinessProfile>();
        }

    }
}