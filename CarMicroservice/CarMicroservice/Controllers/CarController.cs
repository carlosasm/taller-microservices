using CarMicroservice.Authentication;
using CarMicroservice.Model;
using CarService;
using Microsoft.AspNetCore.Mvc;

namespace CarMicroservice.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    //[ServiceFilter(typeof(ApiKeyAuthFilter))]
    public class CarController : Controller
    {

        private readonly BusinessLogic.Interface.ICar businessLogicCar;

        public CarController(BusinessLogic.Interface.ICar _businessLogicCar)
        {
            businessLogicCar = _businessLogicCar;
        }

        [HttpPost]
        public async Task<bool> CreateCar(Model.Car car)
        {
            try
            {
                return await businessLogicCar.CreateCar(car);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<List<Model.Car>> GetAllCars()
        {
            try
            {
                return await businessLogicCar.GetAllCars();
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<List<Model.Car>> GetCarById(Model.Car car)
        {
            try
            {
                return await businessLogicCar.GetCarById(car);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<bool> UpdateCar(Model.Car car)
        {
            try
            {
                return  await businessLogicCar.UpdateCar(car);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<bool> DeleteCar(Model.Car car)
        {
            try
            {
                return await businessLogicCar.DeleteCar(car);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }
    }
}
