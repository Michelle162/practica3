using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practica3.Models
{
    public class equipos
    {
        [Key]

        public int id_equipo {  get; set; }
        public string? nombre { get; set; }
        public string? Tipo_equipo { get; set; }
        public string? marca_id {  get; set; }
        public int anio_compra {  get; set; }
        public string? vida_util {  get; set; }
        public string? descripcion { get; set; }
        public string? modelo {  get; set; } 
        public int Costo {  get; set; } 
        public string? Estado_equipo { get; set; }  

    }
}
