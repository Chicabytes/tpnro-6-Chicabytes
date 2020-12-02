using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using tp6.ViewModel;

namespace tp6.Models
{
    public class RepoPedidos
    { 
        public List<Pedido> GetAll(int _id)
        {
            List<Pedido> NPedidos = new List<Pedido>();
            PedidoViewModel PedidoVM = new PedidoViewModel();
            try
            {
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
                    ped.Numpedido = Convert.ToInt32(reader["idPedido"]);
                    ped.Obs = reader["Observacion"].ToString();
                    switch (Convert.ToInt32(reader["EstadoPedido"]))
                    {
                        case 0:
                            ped.Estado_actual = Estado.Recibido;
                            break;
                        case 1:
                            ped.Estado_actual = Estado.Preparado;
                            break;
                        case 2:
                            ped.Estado_actual = Estado.EnCamino;
                            break;
                        case 3:
                            ped.Estado_actual = Estado.Entregado;
                            break;
                    }
                    NPedidos.Add(ped);
                }
                reader.Close();
                return NPedidos;
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
                return NPedidos;
            }
        }
        public void Alta(Pedido _pe, int _idCad)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Insert Into Pedidos(Observacion, EstadoPedido, idCliente, idCadete) values (@Obs, @Estado, @idCli, @idCad)";
                command.Parameters.AddWithValue("@Obs", _pe.Obs);
                command.Parameters.AddWithValue("@Estado", _pe.Estado_actual);
                command.Parameters.AddWithValue("@idCli", _pe.NCliente.Id);
                command.Parameters.AddWithValue("@idCad", _idCad);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
            }
        }
        public void AgregarCadete(int _idCliente, int _idCadete)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "UPDATE Pedidos SET idCadete = @idCadete WHERE idCliente = @idCliente";
                command.Parameters.AddWithValue("@idCadete", _idCadete);
                command.Parameters.AddWithValue("@idCliente", _idCliente);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
            }
            
        }
        public void Modificacion()
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "UPDATE Pedidos SET NombreCliente = @Nombre, DireccionCliente = @Direccion, TelefonoCliente = @Telefono, TipoEnvio = @Tipo, Cupon = @Cupon, CostoTotal = @CostoTotal WHERE idCliente = @ID";
                
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception ex)
            {
                string excep = ex.ToString();
            }
        }
        public Cadete Cad(int _idCliente)
        {
            Cadete Cad = new Cadete();
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Select * from Pedidos where idCliente = @id;";
                command.Parameters.AddWithValue("@id", _idCliente);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Cad.Id = Convert.ToInt32(reader["idCadete"]);

                }
                reader.Close();
                command.CommandText = "Select * from Cadetes where idCadete = @id;";
                command.Parameters.AddWithValue("@id", Cad.Id);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cad.Nombre = reader["NombreCadete"].ToString();
                    Cad.Direccion = reader["DireccionCadete"].ToString();
                    Cad.Telefono = reader["TelefonoCadete"].ToString();
                    switch (Convert.ToInt32(reader["TipoTransporte"]))
                    {
                        case 0:
                            Cad.TipoT = TipoTransporte.Auto;
                            break;
                        case 1:
                            Cad.TipoT = TipoTransporte.Moto;
                            break;
                        case 2:
                            Cad.TipoT = TipoTransporte.Bicicleta;
                            break;
                    }
                }
                return Cad;
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
                return Cad;
            }
        }
        public int IDCad(int _idCliente)
        {
            int id = 0;
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Select * from Pedidos where idCliente = @id;";
                command.Parameters.AddWithValue("@id", _idCliente);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    id = Convert.ToInt32(reader["idCadete"]);

                }
                return id;
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
                return id;
            }
        }
    }
}
