using System;
using System.Collections.Generic;
using System.Text;

namespace PersonasFisicasPrueba.Datos.Repository
{
    public interface IUnitOfWork
    {
        public IPersonasFisicasRepository PersonasFisicasR { get; set; }

        void Save();
    }
}
