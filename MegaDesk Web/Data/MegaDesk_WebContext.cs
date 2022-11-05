using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Web.Models;

namespace MegaDesk_Web.Data
{
    public class MegaDesk_WebContext : DbContext
    {
        public MegaDesk_WebContext (DbContextOptions<MegaDesk_WebContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk_Web.Models.Desk> Desk { get; set; } = default!;
    }
}
