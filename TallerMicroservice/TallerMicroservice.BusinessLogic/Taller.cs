using TallerMicroservice.BusinessLogic.Interface;
using TallerMicroservice.Model;

namespace TallerMicroservice.BusinessLogic
{
    public class Taller : ITaller
    {
        private readonly DataAccess.Interface.ITaller tallerDataAccess;

        public Taller(DataAccess.Interface.ITaller _tallerDataAccess) {
            tallerDataAccess = _tallerDataAccess;
        }

        public IEnumerable<Model.Taller> CreateTaller(Model.Taller taller)
        {
            return tallerDataAccess.CreateTaller(taller);
        }

        public IEnumerable<Model.Taller> GetAllTaller()
        {
            return tallerDataAccess.GetAllTaller();
        }

        public IEnumerable<Model.Taller> DeleteTaller(Model.Taller taller)
        {
            return tallerDataAccess.DeleteTaller(taller);
        }

        public IEnumerable<Model.Taller> GetTallerById(Model.Taller taller)
        {
            return tallerDataAccess.GetTallerById(taller);
        }

        public bool UpdateTaller(Model.Taller taller)
        {
            return tallerDataAccess.UpdateTaller(taller);
        }
    }
}