using Microsoft.AspNetCore.Mvc.Rendering;
using PersonasFisicasPrueba.Data;
using PersonasFisicasPrueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonasFisicasPrueba.Datos.Repository
{
    public class PersonasFisicasRepository : Repository<TbPersonasFisicas>, IPersonasFisicasRepository
    {
        private readonly ApplicationDbContext cx;
        public PersonasFisicasRepository(ApplicationDbContext _cx) : base(_cx)
        {
            cx = _cx;
        }

        public IEnumerable<SelectListItem> GetListaPersonasFisicas()
        {
            return cx.TbPersonasFisicasV.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.IdPersonaFisica.ToString()
            });
        }

        public void Update(TbPersonasFisicas perFisicas)
        {
            TbPersonasFisicas insDesdeBd = cx.TbPersonasFisicasV.FirstOrDefault(s => s.IdPersonaFisica == perFisicas.IdPersonaFisica);
            insDesdeBd.Nombre = perFisicas.Nombre;
            insDesdeBd.FechaRegistro = perFisicas.FechaRegistro;
            insDesdeBd.FechaActualizacion = perFisicas.FechaActualizacion;
            insDesdeBd.ApellidoPaterno = perFisicas.ApellidoPaterno;
            insDesdeBd.ApellidoMaterno = perFisicas.ApellidoMaterno;
            insDesdeBd.Rfc = perFisicas.Rfc;
            insDesdeBd.FechaNacimiento = perFisicas.FechaNacimiento;
            insDesdeBd.UsuarioAgrega = perFisicas.UsuarioAgrega;
            insDesdeBd.Activo = perFisicas.Activo;
        }
    }
}
