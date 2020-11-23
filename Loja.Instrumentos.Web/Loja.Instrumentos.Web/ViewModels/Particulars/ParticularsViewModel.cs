using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loja.Instrumentos.Web.ViewModels.Particulars
{
    public class ParticularsViewModel
    {
        [Required(ErrorMessage ="O ID é obrigatório")]
        public int Id { get; set; }
        
        [Display(Name = "Marca")]
        [Required(ErrorMessage = "A marca é obrigatória")]
        [MaxLength(50, ErrorMessage =("A marca tem que ter no maximo 500 caracteres"))]
        public string Marca { get; set; }
       
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(100, ErrorMessage = ("O nome tem que ter no maximo 100 caracteres"))]
        public string Nome { get; set; }
       
        
        [Display(Name = "Acordoamento")]
        public int Corda { get; set; }
        
        
        [Display(Name = "Descrição")]
        [MaxLength(2000, ErrorMessage = ("A descrição tem que ter no maximo 2000 caracteres"))]
        public string Descricao { get; set; }

    }
}