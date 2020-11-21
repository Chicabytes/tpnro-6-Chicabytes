using System;
using System.Collections.Generic;
using System.Text;

namespace tp6
{
    public enum TipoPedido 
    {
        Delicado = 0,
        Express = 1,
        Ecologico = 2
    };
    public class Cliente : Persona
    {
        private int id;
        private bool cupon;
        private float costo_total;
        private TipoPedido tipo;
        //private List<Pedido> listaPedidos;

        public bool Cupon { get => cupon; set => cupon = value; }
        public float Costo_total { get => costo_total; set => costo_total = value; }
        public TipoPedido Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }

        public Cliente(int _id, string _Nombre, string _Direccion, string _Telefono, int _tipoenvio) : base(_Nombre, _Direccion, _Telefono)
        {
            //this.listaPedidos = new List<Pedido>();
            Id = _id;
            switch (_tipoenvio)
            {
                case 0: 
                    Tipo = TipoPedido.Delicado; 
                    break;
                case 1: 
                    Tipo = TipoPedido.Express; 
                    break;
                case 2: 
                    Tipo = TipoPedido.Ecologico; 
                    break;
            }
            /*foreach (var _Pedido in _listaPedidos)
            {
                listaPedidos.Add(_Pedido);
            }*/
        }

        public override string ToString()
        {
            return "  Nombre: " + this.Nombre + "\n  Direccion: " + this.Direccion + "\n  Telefono: " + this.Telefono + "\n  Tipo de envio: " + Tipo.ToString();
        }

        public float CostoTotal(int _cant_pedidos)
        {
            int costo = 150;
            float porcentaje = 0;
            float total;
            switch (Tipo)
            {
                case TipoPedido.Delicado: 
                    porcentaje =  0.3f;
                    break;
                case TipoPedido.Express:
                    porcentaje = 0.25f;
                    break;
                case TipoPedido.Ecologico: 
                    porcentaje = 0;
                    break;
            }
            if (cupon)
            {
                porcentaje += 0.1f;    
            }
            total = costo * _cant_pedidos + costo * porcentaje;
            return total;
        }
    }
}
