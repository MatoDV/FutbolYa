namespace FutbolYa.Models
{
    public class Ranking
    {
        public int Id { get; set; }
        public String Puestos { get; set; }
        public int Establecimiento_id { get; set; }
        public Establecimiento establecimiento { get; set; }
        public Ranking (int id, String puestos, int establecimiento_id) 
        {
            this.Id = id;
            this.Puestos = puestos;
            this.Establecimiento_id = establecimiento_id;
        }
        public Ranking() { }
    }
}
