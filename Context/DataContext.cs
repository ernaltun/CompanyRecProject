﻿using CompanyRecProject.Data;
using Microsoft.EntityFrameworkCore;

namespace CompanyRecProject.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Support> Supports { get; set; }
    }
}
