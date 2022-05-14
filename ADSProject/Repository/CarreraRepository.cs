using ADSProject.Data;
using ADSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProject.Repository
{
    public class CarreraRepository : ICarreraRepository
    {
        private readonly ApplicationDbContext applicationDbContext;
        public CarreraRepository(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public int agregarCarrera(CarreraViewModel carreraViewModel)
        {
            try
            {
                applicationDbContext.Carreras.Add(carreraViewModel);
                applicationDbContext.SaveChanges();
                return carreraViewModel.idCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public int actualizarCarrera(int idCarrera, CarreraViewModel carreraViewModel)
        {
            try
            {
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == x.idCarrera);
                applicationDbContext.Entry(item).CurrentValues.SetValues(carreraViewModel);
                applicationDbContext.SaveChanges();
                return carreraViewModel.idCarrera;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool eliminarCarrera(int idCarrera)
        {
            try
            {
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == x.idCarrera);
                //applicationDbContext.Carreras.Remove(item);
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

        public List<CarreraViewModel> obtenerCarrera()
        {
            try
            {
                return applicationDbContext.Carreras.Where(x => x.estado == true).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CarreraViewModel obtenerCarreraPorID(int idCarrera)
        {
            try
            {
                var item = applicationDbContext.Carreras.SingleOrDefault(x => x.idCarrera == idCarrera);
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
