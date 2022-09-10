using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        /// <summary>
        /// Referencia al contexto de Veterinario
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Veterinario AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinario.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        public void DeleteVeterinario(int idVeterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinario.FirstOrDefault(v => v.Id == idVeterinario);
            if (veterinarioEncontrado == null)
                return;
            _appContext.Veterinario.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<Veterinario> GetAllVeterinarios()
        {
            return GetAllVeterinarios_();
        }

        public IEnumerable<Veterinario> GetVeterinariosPorFiltro(string filtro)
        {
            var veterinarios = GetAllVeterinarios(); // Obtiene todos los saludos
            if (veterinarios != null)  //Si se tienen saludos
            {
                if (!String.IsNullOrEmpty(filtro)) // Si el filtro tiene algun valor
                {
                    veterinarios = veterinarios.Where(s => s.Nombres.Contains(filtro));
                }
            }
            return veterinarios;
        }

        public IEnumerable<Veterinario> GetAllVeterinarios_()
        {
            return _appContext.Veterinario;
        }

        public Veterinario GetVeterinario(int idVeterinario)
        {
            return _appContext.Veterinario.FirstOrDefault(v => v.Id == idVeterinario);
        }

        public Veterinario UpdateVeterinario(Veterinario veterinario)
        {
            var VeterinarioEncontrado = _appContext.Veterinario.FirstOrDefault(d => d.Id == veterinario.Id);
            if (VeterinarioEncontrado != null)
            {
                VeterinarioEncontrado.Nombres = veterinario.Nombres;
                VeterinarioEncontrado.Apellidos = veterinario.Apellidos;
                VeterinarioEncontrado.Direccion = veterinario.Direccion;
                VeterinarioEncontrado.Telefono = veterinario.Telefono;
                VeterinarioEncontrado.TarjetaProfesional = veterinario.TarjetaProfesional;
                _appContext.SaveChanges();
            }
            return VeterinarioEncontrado;
        }     
    }
}