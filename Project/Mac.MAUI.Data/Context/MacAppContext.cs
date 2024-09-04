using Mac.MAUI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mac.MAUI.Data.Context
{
    public class MacAppContext : DbContext
    {
        public MacAppContext(DbContextOptions<MacAppContext> options)
            : base(options)
        {
        }

        public DbSet<Contrato> Contrato { get; set; }  
    }

}
