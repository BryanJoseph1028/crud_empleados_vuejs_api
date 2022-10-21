
using System.ComponentModel.DataAnnotations;

namespace web_api_empleados.Models{
   public class Empleados{
     [Key]
        public int id_empleado { get; set; }
        public string nit { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int id_puesto { get; set; }
        public string dpi { get; set; }
        public string fecha_nacimiento { get; set; }

   }
}