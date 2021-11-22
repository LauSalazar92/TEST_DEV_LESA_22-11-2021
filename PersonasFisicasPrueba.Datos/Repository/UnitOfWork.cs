using PersonasFisicasPrueba.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonasFisicasPrueba.Datos.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        public IPersonasFisicasRepository PersonasFisicasR { get; set; }

        public readonly ApplicationDbContext contexto;

        public UnitOfWork(ApplicationDbContext ctx)
        {
            contexto = ctx;
            PersonasFisicasR = new PersonasFisicasRepository(contexto);
        }

        

        public void Save()
        {
            contexto.SaveChanges();
        }
    }
}
