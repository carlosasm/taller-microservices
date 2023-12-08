using CarMicroservice.DataAccess.Interface;
using CarMicroservice.Model;
using Newtonsoft.Json;
using ServiceReference1;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using System.Text;

namespace CarMicroservice.DataAccess
{
    public class Car : ICar
    {
        /*
        private readonly Interface.IConnectionManager connectionManager;

        public Car(Interface.IConnectionManager _connectionManager)
        {
            connectionManager = _connectionManager;
        }
        */

        public async Task<List<Model.Car>> GetAllCars()
        {
            CarServiceClient carWCFService = new CarServiceClient();
            var cars = await carWCFService.GetAllCarsAsync();
            List<Model.Car> carList = new List<Model.Car>();

            foreach (var car in cars) {
                Model.Car myCar = new Model.Car();
                myCar.Id = car.Id;
                myCar.Placa = car.Placa;
                myCar.Nombre = car.Nombre;
                myCar.Precio = car.Precio;
                myCar.Marca = car.Marca;
                myCar.Anio = car.Anio;
                myCar.Color = car.Color;
                carList.Add(myCar);
            }
            return carList;
        }



        public async Task<bool> CreateCar(Model.Car car)
        {
            CarServiceClient carWCFService = new CarServiceClient();
            ServiceReference1.Car serviceCar = convertCarToCar(car);
            var cars = await carWCFService.CreateCarAsync(serviceCar);

            if(cars != null)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteCar(Model.Car car)
        {
            CarServiceClient carWCFService = new CarServiceClient();
            ServiceReference1.Car serviceCar = convertCarToCar(car);
            var cars = await carWCFService.DeleteCarAsync(serviceCar);

            if (cars != null)
            {
                return true;
            }
            return false;
        }

        

        public async Task<List<Model.Car>> GetCarById(Model.Car car)
        {
            CarServiceClient carWCFService = new CarServiceClient();
            ServiceReference1.Car serviceCar = convertCarToCar(car);
            var cars = await carWCFService.GetCarByIdAsync(serviceCar);
            List<Model.Car> carList = new List<Model.Car>();
            
            if(cars != null)
            {
                foreach (var carVar in cars)
                {
                    Model.Car myCar = new Model.Car();
                    myCar.Id = cars[0].Id;
                    myCar.Placa = cars[0].Placa;
                    myCar.Nombre = cars[0].Nombre;
                    myCar.Precio = cars[0].Precio;
                    myCar.Marca = cars[0].Marca;
                    myCar.Anio = cars[0].Anio;
                    myCar.Color = cars[0].Color;
                    carList.Add(myCar);
                }
                return carList;
            }
            return null;
        }

        public async Task<bool> UpdateCar(Model.Car car)
        {
            CarServiceClient carWCFService = new CarServiceClient();
            ServiceReference1.Car serviceCar = convertCarToCar(car);
            var cars = await carWCFService.UpdateCarAsync(serviceCar);

            if (cars != null)
            {
                return true;
            }
            return false;
        }

        private ServiceReference1.Car convertCarToCar(Model.Car myCar)
        {
            ServiceReference1.Car carService = new ServiceReference1.Car();
            carService.Id = myCar.Id;
            carService.Placa = myCar.Placa;
            carService.Nombre = myCar.Nombre;
            carService.Anio = myCar.Anio;
            carService.Color = myCar.Color;
            carService.Marca = myCar.Marca;
            carService.Precio = myCar.Precio;
            return carService;
        }
    }
}