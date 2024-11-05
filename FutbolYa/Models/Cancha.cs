namespace FutbolYa.Models
{
    public class Cancha
    {
        public int Id { get; set; }
        public int Capacidad { get; set; }
        public int Tamaño { get; set; }
        public int Establecimiento_id { get; set; }
        public Establecimiento establecimiento { get; set; }
        public Cancha(int id, int capacidad, int tamaño, int establecimiento_id) {
            this.Id = id;
            this.Capacidad = capacidad;
            this.Tamaño = tamaño;
            this.Establecimiento_id = establecimiento_id;
        }
        public Cancha() { }
    }
}
