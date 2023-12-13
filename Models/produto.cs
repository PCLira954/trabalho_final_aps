using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar.Models
{
   public class Produto : Item 
   {
       [Display(Name = "Nome")]
       public string Nome { get; set; }
       [Display(Name = "Descricao")]
       public string Descricao { get; set; }
       [Display(Name = "Quantidade")]
       public int Quantidade { get; set; }
       [Display(Name = "Preco")]
       public double Preco { get; set; }
   }
}
