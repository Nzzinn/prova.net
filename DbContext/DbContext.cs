using Microsoft.EntityFrameworkCore;

namespace APIExemplo.DbContext{
    public class MedicamentoDbContext : DbContext{
        public MedicamentoDbContext(DbContextOptions<MedicamentoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Medicamento> Medicamentos { get; set; }
    }
}
