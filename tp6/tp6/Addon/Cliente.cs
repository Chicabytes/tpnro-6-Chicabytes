﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tp6
{
    
    public class Cliente : Persona
    {
        private int id;
        private bool cupon;
        private double costo_total;
        
        //private List<Pedido> listaPedidos;

        public bool Cupon { get => cupon; set => cupon = value; }
        public double Costo_total { get => costo_total; set => costo_total = value; }
        public int Id { get => id; set => id = value; }

        public Cliente() : base()
        {
            id = 0;
            cupon = false;
            costo_total = 0;
        }

        public Cliente(int _id, string _Nombre, string _Direccion, string _Telefono, bool _cupon, double _costo) : base(_Nombre, _Direccion, _Telefono)
        {
            //this.listaPedidos = new List<Pedido>();
            Id = _id;
            /*foreach (var _Pedido in _listaPedidos)
            {
                listaPedidos.Add(_Pedido);
            }*/
            Cupon = _cupon;
            Costo_total = _costo;
        }

        public override string ToString()
        {
            return "  Nombre: " + this.Nombre + "\n  Direccion: " + this.Direccion + "\n  Telefono: " + this.Telefono + "\n  Tipo de envio: " + Tipo.ToString();
        }

        /*public float CostoTotal(int _cant_pedidos)
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
        public int NumeroEnvio()
        {
            int NT = 0;
            switch (Tipo)
            {
                case TipoPedido.Delicado:
                    NT = 0;
                    break;
                case TipoPedido.Express:
                    NT = 1;
                    break;
                case TipoPedido.Ecologico:
                    NT = 2;
                    break;
            }
            return NT;
        }*/
    }
}
