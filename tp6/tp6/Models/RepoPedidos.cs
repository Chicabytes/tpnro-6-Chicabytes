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

        public void Alta(Pedido _pe)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Insert Into Pedidos(Observacion, EstadoPedido, idCliente) values (@Obs, @Estado, @idCli)";
                command.Parameters.AddWithValue("@Obs", _pe.Obs);
                command.Parameters.AddWithValue("@Estado", _pe.Estado_actual);
                command.Parameters.AddWithValue("@idCli", _pe.NCliente.Id);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                string asd = ex.ToString();
            }
        }

        public void Modificacion()
        {
            string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
            var conexion = new SQLiteConnection(cadena);
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = "UPDATE Pedidos SET NombreCliente = @Nombre, DireccionCliente = @Direccion, TelefonoCliente = @Telefono, TipoEnvio = @Tipo, Cupon = @Cupon, CostoTotal = @CostoTotal WHERE idCliente = @ID";
            
            command.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
