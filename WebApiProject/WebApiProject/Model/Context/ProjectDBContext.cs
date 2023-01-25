using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApiProject.Model.Context
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options): base(options)
        {
        }

       public DbSet<AssetsDetail> AssetsDetail { get; set; } = null!;
    }
}
