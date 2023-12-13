using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar.Models
{
   public class PagamentoComCartao : TipoDePagamento
   {

       [Display(Name = "Numero do Cartao")]
       public string numeroDoCartao { get; set; }
       [Display(Name = "Bandeira")]
       public string bandeira { get; set; }

   }
}
