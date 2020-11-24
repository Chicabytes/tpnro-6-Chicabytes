using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace tp6.Models
{
    public class RepoPedidos
    { 
        public List<Pedido> GetAll(int _id)
        {
            List<Pedido> NPedidos = new List<Pedido>();
            string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
            var conexion = new SQLiteConnection(cadena);
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = "Select * from Pedidos where idCliente = @id;";
            command.Parameters.AddWithValue("@id", _id);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var ped = new Pedido();
                NPedidos.Add(ped);
            }
            reader.Close();
            return NPedidos;
        }

        public void Alta()
        {
            string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
            var conexion = new SQLiteConnection(cadena);
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = "Insert Into Clientes(NombreCliente, DireccionCliente, TelefonoCliente, TipoEnvio, Cupon, CostoTotal) values (@NombreCliente, @DireccionCliente, @TelefonoCliente, @TipoEnvio, @Cupon, @CostoTotal)";
            command.Parameters.AddWithValue("@NombreCliente", Cli.Nombre);
            command.Parameters.AddWithValue("@DireccionCliente", Cli.Direccion);
            command.Parameters.AddWithValue("@TelefonoCliente", Cli.Telefono);
            command.Parameters.AddWithValue("@TipoEnvio", Cli.Tipo);
            command.Parameters.AddWithValue("@Cupon", Cli.Cupon);
            command.Parameters.AddWithValue("@CostoTotal", Cli.Costo_total);
            command.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
