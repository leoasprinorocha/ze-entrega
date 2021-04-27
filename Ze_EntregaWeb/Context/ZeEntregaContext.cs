using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ze_EntregaWEB.Domain.Models;

namespace Ze_EntregaWeb.Context
{
    public class ZeEntregaContext : DbContext
    {
        public ZeEntregaContext(DbContextOptions<ZeEntregaContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }



    }
}
