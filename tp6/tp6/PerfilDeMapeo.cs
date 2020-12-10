using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tp6.ViewModel;

namespace tp6
{
    public class PerfilDeMapeo : Profile
    {
        public PerfilDeMapeo()
        {
            CreateMap<Cadete, CadeteViewModel>().ReverseMap();
            CreateMap<Cliente, ClienteViewModel>().ReverseMap();
            CreateMap<Pedido, PedidoViewModel>();
        }
    }
}
