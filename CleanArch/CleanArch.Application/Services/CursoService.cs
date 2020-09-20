using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Services
{
    public class CursoService : ICursoService
    {
        private ICursoRepository _cursoRepository;
        public CursoService(ICursoRepository cursoRepository)
        {
            _cursoRepository = cursoRepository;
        }
        public CursoViewModel GetCursos()
        {
            return new CursoViewModel()
            {
                Cursos = _cursoRepository.GetCursos()
            };
        }
    }
}
