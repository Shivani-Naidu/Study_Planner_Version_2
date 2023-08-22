using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ST10084788_PROG6212_POE.DatabaseContext
{
    public class AuthDbContext:IdentityDbContext
    {

        // Database context for the users table in the database
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        { 
        
        }
    }
}
