using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMicroservice.BusinessLogic.Interface;
using TallerMicroservice.Model;

namespace TallerMicroservice.BusinessLogic
{
    public class CarFromTaller : ICarFromTaller
    {
        private readonly DataAccess.Interface.ICarFromTaller carFromTallerrDataAccess;

        public CarFromTaller(DataAccess.Interface.ICarFromTaller _carFromTallerDataAccess)
        {
            carFromTallerrDataAccess = _carFromTallerDataAccess;
        }

        public Task<bool> CreateCarFromTaller(Car car)
        {
            return carFromTallerrDataAccess.CreateCarFromTaller(car);
        }

        public Task<bool> DeleteCarFromTaller(Car car)
        {
            return carFromTallerrDataAccess.DeleteCarFromTaller(car);
        }

        public Task<List<Car>> GetAllCarFromTaller()
        {
            return carFromTallerrDataAccess.GetAllCarFromTaller();
        }

        public Task<List<Car>> GetCarFromTallerById(Car car)
        {
            return carFromTallerrDataAccess.GetCarFromTallerById(car);
        }

        public Task<bool> UpdateCarFromTaller(Car car)
        {
            return carFromTallerrDataAccess.UpdateCarFromTaller(car);
        }
    }
}
