using ETicaretApi.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ETicaretApi.Persistence
{
    //Powershell/cmd üzerinden migration yapmak için
    //Daha sonra connection string global alana taaşınacak
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ETicaretApiDbContext>
    {
        public ETicaretApiDbContext CreateDbContext(string[] args)
        {           
            DbContextOptionsBuilder<ETicaretApiDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
