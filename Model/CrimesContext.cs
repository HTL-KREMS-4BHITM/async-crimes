using Microsoft.EntityFrameworkCore;

namespace Model;

public class CrimesContext:DbContext
{
    public CrimesContext(DbContextOptions<CrimesContext> context): base(context)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}