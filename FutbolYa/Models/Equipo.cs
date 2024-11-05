namespace FutbolYa.Models
{
    public class Equipo
    {
        public int Id{ get; set; }
        public String Nombre { get; set; }
        public int Jugadores { get; set; }
        public String Estado { get; set; }
        public int Cupo { get; set; }
        public int Cancha_id { get; set; }
        public Cancha Cancha { get; set; }
        public int Ranking_id { get; set; }
        public Ranking Ranking { get; set; }
        public int Torneo_id { get; set; }
        public Torneo Torneo { get; set; }
        public Equipo(int id, String nombre, int jugadores, String estado, int cupo, int cancha_id, int ranking_id, int torneo_id)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Jugadores = jugadores;
            this.Estado = estado;
            this.Cupo = cupo;
            this.Cancha_id= cancha_id;
            this.Ranking_id = ranking_id;
            this.Torneo_id = torneo_id;
        }
        public Equipo() { }


    }
}
