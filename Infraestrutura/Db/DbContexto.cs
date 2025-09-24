using dio_minimal_api.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace dio_minimal_api.Infraestrutura.Db;

public class DbContexto(IConfiguration configuration) : DbContext
{
    public DbSet<Administrador> Administradores { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var stringConnection = configuration.GetConnectionString("mysql")!.ToString();
        if (!string.IsNullOrEmpty(stringConnection))
        {
            optionsBuilder.UseMySql(stringConnection, ServerVersion.AutoDetect(stringConnection));
        }
    }
}