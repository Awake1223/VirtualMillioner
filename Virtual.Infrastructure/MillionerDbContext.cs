using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Virtual.Infrastructure.Entity;

namespace Virtual.Infrastructure
{
    public class MillionerDbContext : IdentityDbContext<MillionerUserEntity>
    {
        public MillionerDbContext(DbContextOptions<MillionerDbContext> options) : base(options)
        {
        }
    }
}
