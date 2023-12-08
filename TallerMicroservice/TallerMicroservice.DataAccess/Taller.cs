using Newtonsoft.Json;
using System.Data;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using Dapper;
using TallerMicroservice.DataAccess.Interface;
using TallerMicroservice.Model;

namespace TallerMicroservice.DataAccess
{
    public class Taller : ITaller
    {
        private readonly Interface.IConnectionManager connectionManager;

        public Taller(Interface.IConnectionManager _connectionManager)
        {
            connectionManager = _connectionManager;
        }


        IEnumerable<Model.Taller> ITaller.GetAllTaller()
        {
            using (var connection = connectionManager.CreateConnection("PruebaWCF"))
            {
                var talleres = connection.Query<Model.Taller>("usp_ListarCarrosEnTaller",
                    commandType: CommandType.StoredProcedure
                    );

                return talleres;
            }
        }

        public bool DeleteTaller(Model.Taller taller)
        {
            using (var connection = connectionManager.CreateConnection("PruebaWCF"))
            {
                var talleres = connection.Query<Model.Taller>("usp_EliminarCarroEnTaller",
                    param: new
                    {
                        Id = taller.Id
                    },
                    commandType: CommandType.StoredProcedure
                );

                return true;
            }
        }


        public IEnumerable<Model.Taller> GetTallerById(Model.Taller taller)
        {
            using (var connection = connectionManager.CreateConnection("PruebaWCF"))
            {
                var talleres = connection.Query<Model.Taller>("usp_ObtenerCarroEnTaller",
                    param: new
                    {
                        Id = taller.Id,
                        IdCarro = taller.IdCarro
                    },
                    commandType: CommandType.StoredProcedure
                    );

                return talleres;
            }
        }

        public bool UpdateTaller(Model.Taller taller)
        {
            using (var connection = connectionManager.CreateConnection("PruebaWCF"))
            {
                var talleres = connection.Query<Model.Taller>("usp_ActualizarCarroEnTaller",
                    param: new
                    {
                        Id = taller.Id,
                        Tipo = taller.Tipo,
                        Descripcion = taller.Descripcion,
                        IdCarro = taller.IdCarro,
                        Costo = taller.Costo,
                        FechaEntrega = taller.FechaEntrega,
                    },
                    commandType: CommandType.StoredProcedure
                );

                return true;
            }
        }

        IEnumerable<Model.Taller> ITaller.CreateTaller(Model.Taller taller)
        {
            using (var connection = connectionManager.CreateConnection("PruebaWCF"))
            {
                var talleres = connection.Query<Model.Taller>("usp_CrearCarroEnTaller",
                    param: new
                    {
                        Nombre = taller.Nombre,
                        Ubicacion = taller.Ubicacion,
                        Tipo = taller.Tipo,
                        Descripcion = taller.Descripcion,
                        IdCarro = taller.IdCarro,
                        Costo = taller.Costo,
                        FechaEntrega = taller.FechaEntrega
                    },
                    commandType: CommandType.StoredProcedure
                    );

                return talleres;
            }
        }

        IEnumerable<Model.Taller> ITaller.DeleteTaller(Model.Taller taller)
        {
            using (var connection = connectionManager.CreateConnection("PruebaWCF"))
            {
                var talleres = connection.Query<Model.Taller>("usp_EliminarCarroEnTaller",
                    param: new
                    {
                        Id = taller.Id
                    },
                    commandType: CommandType.StoredProcedure
                );

                return talleres;
            }
        }
    }
}