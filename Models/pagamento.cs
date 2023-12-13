using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar.Models
{
   public class Pagamento : NotadeVenda
   {
       [Display(Name = "Data Limite")]
       public int dataLimite { get; set; }
       [Display(Name = "Valor")]
       public double Valor { get; set; }
       [Display(Name = "Pago")]
       public bool Pago { get; set; }
   }
}
