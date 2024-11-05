namespace FutbolYa.Models
{
    public class PerfilUsuario
    {
        public int Id { get; set; }
        public int PartidoCancelado { get; set; }
        public int PartidoGanado { get; set; }
        public double Puntuacion {  get; set; }
        public int Ranking { get; set; }
        public String Posicion { get; set; }
        public int Usuario_id { get; set; }
        public Usuario usuario { get; set; }
        public PerfilUsuario(int id, int partidocancelado, int partidoganado, double puntuacion, int ranking, String posicion, int usuario_id)
        {
            this.Id = id;
            this.PartidoCancelado = partidocancelado;
            this.PartidoGanado = partidoganado;
            this.Ranking = ranking;
            this.Posicion = posicion;
            this.Usuario_id = usuario_id;
        }
        public PerfilUsuario(){ }
    }
}
