using System.Collections.Generic;
using System.Xml.Schema;

namespace tp6
{
    public enum TipoTransporte
    {
        Auto = 0,
        Moto = 1,
        Bicicleta = 2
    }

    public class Cadete : Persona
    {
        //private List<Pedido> listaPedidos;
        private int cant_pedidos;
        private TipoTransporte tipoT;
        private int id;
        //internal List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
        public int Cant_pedidos { get => cant_pedidos; set => cant_pedidos = value; }
        public TipoTransporte TipoT { get => tipoT; set => tipoT = value; }
        public int Id { get => id; set => id = value; }

        public Cadete() : base(){
            TipoT = 0;
            Id = 0;
        }
        public Cadete(int _id, string _Nombre, string _Direccion, string _Telefono, int _tipo) : base(_Nombre, _Direccion, _Telefono)
        {
            Id = _id;
            /*this.ListaPedidos = new List<Pedido>();
            this.cant_pedidos = ListaPedidos.Count;
            foreach (var _Pedido in _ListaPedido)
            {
                ListaPedidos.Add(_Pedido);
            }*/
            switch (_tipo)
            {
                case 0:
                    TipoT = TipoTransporte.Auto;
                    break;
                case 1:
                    TipoT = TipoTransporte.Moto;
                    break;
                case 2:
                    TipoT = TipoTransporte.Bicicleta;
                    break;
            }
        }
        public int NumeroTransporte()
        {
            int NT = 0;
            switch (TipoT)
            {
                case TipoTransporte.Auto:
                    NT = 0;
                    break;
                case TipoTransporte.Moto:
                    NT = 1;
                    break;
                case TipoTransporte.Bicicleta:
                    NT = 2;
                    break;
            }
            return NT;
        }
        /*
        public int Canti_Pedido(List<Pedido> _ListaPedidos)
        {
            int canti = 0;
            foreach (var pedido in _ListaPedidos)
            {
                if (pedido.Estado_actual == Estado.Entregado)
                {
                    canti++;
                }
            }
            return canti;
        }

        public float Jornal(List<Pedido> _ListaPedidos)
        {
            float cantidad = Canti_Pedido(_ListaPedidos);
            float porcentaje = 0;
            switch (tipoT)
            {
                case TipoTransporte.Auto:
                    porcentaje = cantidad * 0.3f;
                    break;
                case TipoTransporte.Moto:
                    porcentaje = cantidad * 0.2f;
                    break;
                case TipoTransporte.Bicicleta:
                    porcentaje = cantidad * 0.05f;
                    break;
            }
            float total = cantidad * 100 + porcentaje;
            return total;
        }*/
    }
}
