namespace CasaDeApuestasMVC.Models
{
    public class UsuarioModel
    {
        public UsuarioModel()
        {
            Apuesta = new HashSet<ApuestaModel>();
            Promocion = new HashSet<PromocionModel>();
            UsuarioRol = new HashSet<UsuarioRolModel>();
        }

        public int Id { get; set; }
        public int? PaisId { get; set; }
        public string? Nombre { get; set; }
        public string? Paterno { get; set; }
        public string? Materno { get; set; }
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Genero { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Correo { get; set; }

        public virtual PaisModel? Pais { get; set; }
        public virtual ICollection<ApuestaModel> Apuesta { get; set; }
        public virtual ICollection<PromocionModel> Promocion { get; set; }
        public virtual ICollection<UsuarioRolModel> UsuarioRol { get; set; }


    }
}
