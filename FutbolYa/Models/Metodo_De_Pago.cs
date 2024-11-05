namespace FutbolYa.Models
{
    public class Metodo_De_Pago
    {
        public int Id { get; set; }
        public bool MercadoPago { get; set; }
        public bool TarjetaDebito { get; set; }
        public bool Efectivo { get; set; }
        public Metodo_De_Pago(int id, bool mercadopago, bool tarjetadebito, bool efectivo) 
        {
            this.Id = id;
            this.MercadoPago = mercadopago;
            this.TarjetaDebito = tarjetadebito;
            this.Efectivo = efectivo;
        }
        public Metodo_De_Pago() { }
    }
}
