using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar.Models
{
   public class TipoDePagamento : NotadeVenda
   {
       [Display(Name = "Nome do Cobrado")]
       public string nomeDoCobrado { get; set; }
       [Display(Name = "Informacoes Adicionais")]
       public string informacoesAdicionais { get; set; }
   }
}
