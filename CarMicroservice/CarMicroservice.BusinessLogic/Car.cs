using CarMicroservice.BusinessLogic.Interface;

namespace CarMicroservice.BusinessLogic
{
    public class Car : ICar
    {
        private readonly DataAccess.Interface.ICar carDataAccess;

        public Car(DataAccess.Interface.ICar _carDataAccess) { 
            this.carDataAccess = _carDataAccess;
        }

        public Task<bool> CreateCar(Model.Car car)
        {
            return carDataAccess.CreateCar(car);
        }

        public Task<bool> DeleteCar(Model.Car car)
        {
            return carDataAccess.DeleteCar(car);
        }

        public Task<List<Model.Car>> GetAllCars()
        {
            return carDataAccess.GetAllCars();
        }

        public Task<List<Model.Car>> GetCarById(Model.Car car)
        {
            return carDataAccess.GetCarById(car);
        }

        public Task<bool> UpdateCar(Model.Car car)
        {
            return carDataAccess.UpdateCar(car);
        }
    }
}