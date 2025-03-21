﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD.Modals;

namespace CRUD.Data
{
    public class CRUDContext : DbContext
    {
        public CRUDContext (DbContextOptions<CRUDContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD.Modals.Product> Product { get; set; } = default!;
    }
}
