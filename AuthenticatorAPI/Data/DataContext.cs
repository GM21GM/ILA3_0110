using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthenticatorAPI.Data
{
    public class DataContext : IdentityDbContext 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

    }
}
