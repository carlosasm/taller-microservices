using CarMicroservice.Model;
using System.Reflection;

namespace CarMicroservice.BusinessLogic.Interface
{
    public interface ICar
    {
        Task<List<Car>> GetAllCars();

        Task<List<Car>> GetCarById(Car car);

        Task<bool> CreateCar(Car car);

        Task<bool> UpdateCar(Car car);

        Task<bool> DeleteCar(Car car);

        //Task<IEnumerable<Car>> CreateCar(Model.Car car);
        //IEnumerable<Car> GetCarById(Model.Car car);
    }
}