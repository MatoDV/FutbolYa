namespace FutbolYa.Models
{
    public class Partido
    {
        public int Id { get; set; }
        public int Cupo { get; set; }
        public DateTime Horario { get; set; }
        public int Reserva_id { get; set; }
        public Reserva reserva { get; set; }
        public int Establecimiento_id { get; set; }
        public Establecimiento establecimiento { get; set; }
        public int Cancha_id { get; set; }
        public Cancha cancha { get; set; }
        public ICollection<Inscripcion> Inscripciones { get; set; }
        public Partido(int id, int cupo, DateTime horario, int reserva_id, int establecimiento_id, int cancha_id) 
        {
            this.Id = id;
            this.Cupo = cupo;
            this.Horario = horario;
            this.Reserva_id = reserva_id;
            this.Establecimiento_id = establecimiento_id;
            this.Cancha_id = cancha_id;
        }
        public Partido(){ }
    }
}
