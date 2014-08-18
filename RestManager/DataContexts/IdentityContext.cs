using Microsoft.AspNet.Identity.EntityFramework;
using RestManager.Models;

namespace RestManager.DataContexts
{
    public class IdentityContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static IdentityContext Create()
        {
            return new IdentityContext();
        }
    }
}