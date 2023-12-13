using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar.Models
{
   public class PagamentocomCheque : TipoDePagamento
   {
       [Display(Name = "Banco")]
       public int banco { get; set; }
       [Display(Name = "Nome do Banco")]
       public string nomedoBanco { get; set; }
   }
}
