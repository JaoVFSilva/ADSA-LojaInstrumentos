using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loja.Instrumentos.Web.ViewModels.Particulars
{
    public class ParticularsIndexViewModel
    {
        public int Id { get; set; }
        [Display(Name="Marca")]
        public string Marca { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Acordoamento")]
        public int Corda { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }


    }
}