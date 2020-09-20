using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
    public class UniversidadDbContext : DbContext
    {
        public  UniversidadDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Curso> Cursos { get; set; }


    }
}
