using TallerMicroservice.Model;

namespace TallerMicroservice.DataAccess.Interface
{
    public interface ITaller
    {

        public IEnumerable<Model.Taller> GetAllTaller();

        public IEnumerable<Model.Taller> GetTallerById(Model.Taller taller);

        public IEnumerable<Model.Taller> CreateTaller(Model.Taller taller);

        public bool UpdateTaller(Model.Taller taller);

        public IEnumerable<Model.Taller> DeleteTaller(Model.Taller taller);

    }
}