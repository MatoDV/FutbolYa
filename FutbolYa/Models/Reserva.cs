namespace FutbolYa.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime Horario { get; set; }
        public int Precio { get; set; }
        public int Usuario_id { get; set; }
        public Usuario usuario { get; set; }
        public int Metodo_De_Pago_id { get; set; }
        public Metodo_De_Pago Metodo_De_Pago { get; set; }
        public Reserva(int id, DateTime horario, int precio, int usuario_id, int metodo_de_pago) 
        {
        this.Id = id;
        this.Horario = horario;
        this.Precio = precio;
        this.Usuario_id = usuario_id;
        this.Metodo_De_Pago_id = metodo_de_pago;
        }
        public Reserva() { }
    }
}
