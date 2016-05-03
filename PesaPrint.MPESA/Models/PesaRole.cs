using Microsoft.AspNet.Identity.EntityFramework;

namespace PesaPrint.MPESA.Models
{
    public class PesaRole : IdentityRole
    {
        public PesaRole()
        {
        }

        public PesaRole(string name) : base(name)
        {
        }

        public string Description { get; set; }
    }
}