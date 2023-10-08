using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Nombre es Obligatorio")]
        [MaxLength(60,ErrorMessage ="Nombre debe ser máximo 60 Caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Descripción es Obligatorio")]
        [MaxLength(60, ErrorMessage = "Descripción debe ser máximo 100 Caracteres")]
        public string Descripcion { get; set;}
        [Required(ErrorMessage = "Estado es Obligatorio")]
        public bool Estado { get; set;}
    }
}
