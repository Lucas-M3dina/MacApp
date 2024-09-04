using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace Mac.MAUI.Data.Context
{
    public class MacAppContextFactory : IDesignTimeDbContextFactory<MacAppContext>
    {
        public MacAppContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MacAppContext> optionsBuilder = new();

            optionsBuilder.UseSqlServer("Server=192.168.1.107;Database=MacApp;User Id=sa;Password=mac123;TrustServerCertificate=True;");


            return new MacAppContext(optionsBuilder.Options);
        }
    }
}
