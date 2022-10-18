using Microsoft.EntityFrameworkCore;

namespace CadastroDeContato.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Contato> Contatos { get; set; }
    }
}
