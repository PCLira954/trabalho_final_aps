using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace paulocesar.Models
{
   public class NotadeVenda
   {
       [Display(Name = "Data")]
       public int Data { get; set; }
       [Display(Name = "Tipo")]
       public bool Tipo { get; set; }
       [Display(Name = "Cancelar")]
       public bool Cancelar { get; set; }
       [Display(Name = "Devolver")]
       public bool Devolver { get; set; }
   }
}
