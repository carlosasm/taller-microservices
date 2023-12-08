using Microsoft.AspNetCore.Mvc;
using TallerMicroservice.Model;

namespace TallerMicroservice.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    public class CarFromTallerController : Controller
    {
        private readonly BusinessLogic.Interface.ICarFromTaller carFromTallerBusinessLogic;

        public CarFromTallerController(BusinessLogic.Interface.ICarFromTaller _carFromTallerBusinessLogic)
        {
            carFromTallerBusinessLogic = _carFromTallerBusinessLogic;
        }


        [HttpPost]
        public async Task<List<Model.Car>> GetAllCarFromTaller()
        {
            try
            {
                return await carFromTallerBusinessLogic.GetAllCarFromTaller();
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<bool> CreateCarFromTaller(Car car)
        {
            try
            {
                return await carFromTallerBusinessLogic.CreateCarFromTaller(car);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<bool> DeleteCarFromTaller(Car car)
        {
            try
            {
                return await carFromTallerBusinessLogic.DeleteCarFromTaller(car);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<bool> UpdateCarFromTaller(Car car)
        {
            try
            {
                return await carFromTallerBusinessLogic.UpdateCarFromTaller(car);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<List<Model.Car>> GetCarFromTallerById(Car car)
        {
            try
            {
                return await carFromTallerBusinessLogic.GetCarFromTallerById(car);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }
    }
}
