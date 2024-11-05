namespace FutbolYa.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public int Precio { get; set; }
        public int Usuario_id { get; set; }
        public Usuario usuario { get; set; }
        public int Metodo_De_Pago_id { get; set; }
        public Metodo_De_Pago metodo_de_pago { get; set; }
        public ICollection<Partido> Partidos { get; set; }
        public Inscripcion(int id, int precio, int usuario_id, int metodo_de_pago_id) 
        {
            this.Id = id;
            this.Precio = precio;
            this.Usuario_id = usuario_id;
            this.Metodo_De_Pago_id = metodo_de_pago_id;
        }
        public Inscripcion(){ }
    }
}
