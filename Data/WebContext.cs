﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web.Data
{
    public class WebContext : DbContext
    {
        public WebContext (DbContextOptions<WebContext> options)
            : base(options)
        {
        }

        public DbSet<Web.Models.Pedido> Pedido { get; set; } = default!;
        public DbSet<Web.Models.Usuario> Usuario { get; set; } = default!;
        public DbSet<Web.Models.Inventario> Inventario { get; set; } = default!;
    }
}
