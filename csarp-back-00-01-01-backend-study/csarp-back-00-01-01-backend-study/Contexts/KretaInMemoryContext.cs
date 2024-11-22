﻿using Microsoft.EntityFrameworkCore;

namespace csarp_back_00_01_01_backend_study.Contexts
{
    public class KretaInMemoryContext : KretaContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}