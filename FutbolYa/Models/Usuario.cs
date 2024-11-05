namespace FutbolYa.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Mail { get; set; }
        public String Contrasenia { get; set; }
        public bool TipoUsuario { get; set; }
        public Usuario(int id, String nombre, String apellido, String mail, String contrasenia, bool tipousuario) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Mail = mail;
            this.Contrasenia = contrasenia;
            this.TipoUsuario = tipousuario;
        }
        public Usuario() { }
    }
}
