using Microsoft.AspNetCore.Mvc.Rendering;
using PersonasFisicasPrueba.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonasFisicasPrueba.Datos.Repository
{
    public interface IPersonasFisicasRepository : IRepository<TbPersonasFisicas>
    {
        IEnumerable<SelectListItem> GetListaPersonasFisicas(); 

        void Update(TbPersonasFisicas perFisicas);
    }
}
