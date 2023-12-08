using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMicroservice.Model
{
    public class Car
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Marca { set; get; }
        public string Anio { set; get; }
        public string Color { set; get; }
        public int Precio { set; get; }
    }
}
