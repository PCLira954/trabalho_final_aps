using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar.Models
{
   public class Marca : Produto
   {
       [Display(Name = "Nome")]
       public string Nome { get; set; }
       [Display(Name = "Descricao")]
       public string Descricao { get; set; }
   }
}
