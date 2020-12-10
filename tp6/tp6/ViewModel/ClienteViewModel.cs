using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp6.ViewModel
{
    public class ClienteViewModel
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Cupon { get; set; }
        public int CostoTotal { get; set; }
    
    }
}
