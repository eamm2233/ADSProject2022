using ADSProject.Data;
using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Repository
{
    public class ProfesorRepository : IProfesorRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ProfesorRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public int agregarProfesor(ProfesorViewModel profesorViewModel)
        {
            try
            {
                applicationDbContext.Profesores.Add(profesorViewModel);
                applicationDbContext.SaveChanges();
                return profesorViewModel.idProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int actualizarProfesor(int idProfeosr, ProfesorViewModel profesorViewModel)
        {
            try
            {
                var item = applicationDbContext.Profesores.SingleOrDefault(x => x.idProfesor == x.idProfesor);
                applicationDbContext.Entry(item).CurrentValues.SetValues(profesorViewModel);
                applicationDbContext.SaveChanges();
                return profesorViewModel.idProfesor;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool eliminarProfesor(int idProfesor)
        {
            try
            {
                var item = applicationDbContext.Profesores.SingleOrDefault(x => x.idProfesor == x.idProfesor);
                //applicationDbContext.Profesores.Remove(item);
                item.estado = false;
                applicationDbContext.Entry(item).Property(x => x.estado).IsModified = true;
                applicationDbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProfesorViewModel> obtenerProfesor()
        {
            try
            {
                return applicationDbContext.Profesores.Where(x => x.estado == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ProfesorViewModel obtenerProfesorPorID(int idProfesor)
        {
            try
            {
                var item = applicationDbContext.Profesores.SingleOrDefault(x => x.idProfesor == idProfesor);
                return item;
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
