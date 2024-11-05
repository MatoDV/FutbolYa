namespace FutbolYa.Models
{
    public class Establecimiento
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Capacidad { get; set; }
        public String Direccion { get; set; }
        public Establecimiento(int id, String nombre, int capacidad, String Direccion)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Capacidad = capacidad;
            this.Direccion = Direccion;
        }
        public Establecimiento() { }
    }
}
