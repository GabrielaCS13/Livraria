using Livro.Models;
using Microsoft.EntityFrameworkCore;

namespace Livro.Data
{
    public class ApplicationDBCntext: DbContext
    {
        public ApplicationDBCntext(DbContextOptions<ApplicationDBCntext> options) : base(options) 
        {
        }

        // aqui são criadas as tabelas 

        public DbSet<EmprestimoModel> Emprestimo { get; set; }
    }
}
