using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TallerMicroservice.Model;

namespace TallerMicroservice.DataAccess.Interface
{
    public interface ICarFromTaller
    {
        Task<List<Model.Car>> GetAllCarFromTaller();

        Task<List<Car>> GetCarFromTallerById(Car car);

        Task<bool> CreateCarFromTaller(Car car);

        Task<bool> UpdateCarFromTaller(Car car);

        Task<bool> DeleteCarFromTaller(Car car);
    }
}
