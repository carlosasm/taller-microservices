using CarMicroservice.Model;

namespace CarMicroservice.DataAccess.Interface
{
    public interface ICar
    {
        Task<List<Car>> GetAllCars();

        Task<List<Car>> GetCarById(Car car);

        Task<bool> CreateCar(Car car);

        Task<bool> UpdateCar(Car car);

        Task<bool> DeleteCar(Car car);

        //Task<IEnumerable<Car>> CrearVentaConsultora(Model.Venta venta);
        //IEnumerable<Car> ConsultarComisionConsultora(Model.Venta venta);
    }
}