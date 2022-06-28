namespace CasaDeApuestasMVC.Models
{
    public class RolModel
    {
        public Rol()
        {
            UsuarioRol = new HashSet<UsuarioRolModel>();
        }

        public int Id { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<UsuarioRolModel> UsuarioRol { get; set; }
    }
}
