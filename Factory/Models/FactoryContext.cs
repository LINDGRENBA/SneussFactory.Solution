using Microsoft.EntityFrameworkCore;

namespace NAMESPACE.Models
{
  public class PROJECTNAMEContext : DbContext
  {
    public virtual DbSet<ClassNameOneSingular> ClassNameOnePlural { get; set; }
    public DbSet<ClassNameTwoSingular> ClassNameTwoPlural { get; set; }
    public DbSet<JoinTableSingular> JoinTablePlural /*singular or plural?*/ {get; set; }
    
    public PROJECTNAMEContext(DbContextOptions options) : base(options) { }
  }
}