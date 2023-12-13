using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar.Models
{
   public class Vendedor : NotadeVenda
   {
       [Display(Name = "Nome")]
       public string Nome { get; set; }

   }
}
