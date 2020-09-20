using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Repository
{
    public class CursoRepository : ICursoRepository
    {
        private readonly UniversidadDbContext _universidadDbContext;
        public CursoRepository(UniversidadDbContext universidadDbContext)
        {
            _universidadDbContext = universidadDbContext;
        }
        public IEnumerable<Curso> GetCursos()
        {
            return _universidadDbContext.Cursos;
        }
    }
}
