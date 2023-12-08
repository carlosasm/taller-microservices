using Microsoft.AspNetCore.Mvc;
using TallerMicroservice.Model;

namespace TallerMicroservice.Controllers
{
    [ApiController]
    [Route("api/v1.0/[controller]/[action]")]
    public class TallerController : Controller
    {
        private readonly BusinessLogic.Interface.ITaller businessLogicTaller;

        public TallerController(BusinessLogic.Interface.ITaller _businessLogicTaller)
        {
            businessLogicTaller = _businessLogicTaller;
        }

        [HttpPost]
        public async Task<IEnumerable<Taller>> GetAllTaller()
        {
            try
            {
                return businessLogicTaller.GetAllTaller();
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<IEnumerable<Taller>> CreateTaller(Taller taller)
        {
            try
            {
                return businessLogicTaller.CreateTaller(taller);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<IEnumerable<Taller>> DeleteTaller(Taller taller)
        {
            try
            {
                return businessLogicTaller.DeleteTaller(taller);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<bool> UpdateTaller(Taller taller)
        {
            try
            {
                return businessLogicTaller.UpdateTaller(taller);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }

        [HttpPost]
        public async Task<IEnumerable<Taller>> GetTallerById(Taller taller)
        {
            try
            {
                return businessLogicTaller.GetTallerById(taller);
            }
            catch (Exception e)
            {
                Response.StatusCode = StatusCodes.Status500InternalServerError;
                throw;
            }
        }
    }
}
