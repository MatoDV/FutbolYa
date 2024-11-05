namespace FutbolYa.Models
{
    public class Torneo
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Premio { get; set; }
        public String Puestos { get; set; }
        public int Establecimiento_id { get; set; }
        public Establecimiento Establecimiento { get; set; }
        public Torneo(int id, String nombre, String premio, String puestos, int establecimiento_id)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Premio = premio;
            this.Puestos = puestos;
            this.Establecimiento_id = establecimiento_id;
        }
        public Torneo() { }
    }
}
