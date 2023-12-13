using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar.Models
{
   public class Item : NotadeVenda
   {
      [Display(Name = "Preco")]
       public double Preco { get; set; }
       [Display(Name = "Percentual")]
       public int Percentual { get; set; }
       [Display(Name = "Quantidade")]
       public int Quantidade { get; set; }
   }
}
