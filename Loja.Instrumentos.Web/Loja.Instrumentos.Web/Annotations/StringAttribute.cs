using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loja.Instrumentos.Web.Annotations
{
    public class StringAttribute : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            return value.ToString().EndsWith("elixir");
        }

    }
}