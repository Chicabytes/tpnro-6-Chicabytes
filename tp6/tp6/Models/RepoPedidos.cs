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
        public List<Pedido> GetAll(EstadoPedido estado = EstadoPedido.Todos)
        {
            List<Pedido> NPedidos = new List<Pedido>();
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                if (estado == EstadoPedido.Todos)
                {
                    command.CommandText = @"Select 
                                        IdPedido,
                                        NombreCliente,
                                        Observacion,
                                        NombreCadete,
                                        EstadoPedido
                                        From Pedidos
                                        Left Join Cadetes using (IdCadete)
                                        Inner Join Clientes using (IdCliente);";
                }
                else
                {
                    command.CommandText = @"Select 
                                        IdPedido,
                                        NombreCliente,
                                        Observacion,
                                        NombreCadete,
                                        EstadoPedido
                                        From Pedidos
                                        Left Join Cadetes using (IdCadete)
                                        Inner Join Clientes using (IdCliente);";
                    command.Parameters.AddWithValue("@EstadoPedido", estado);
                }


                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var ped = new Pedido();
                    ped.Numpedido = Convert.ToInt32(reader["idPedido"]);
                    ped.Obs = reader["Observacion"].ToString();
                    ped.Estado_actual = (EstadoPedido)(Convert.ToInt32(reader["EstadoPedido"]));
                    
                    ped.NCliente = new Cliente();
                    ped.NCliente.Nombre = reader["NombreCliente"].ToString();
                    
                    ped.Cadete = new Cadete();
                    ped.Cadete.Nombre = reader["NombreCadete"].ToString();

                    NPedidos.Add(ped);
                }
                reader.Close();
                conexion.Close();
                return NPedidos;
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
                return NPedidos;
            }
        }

        public void Alta(Pedido _pe)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Insert Into Pedidos(Observacion, TipoEnvio, EstadoPedido, idCliente) values (@Obs, @TipoEnvio, @Estado, @idCli)";
                command.Parameters.AddWithValue("@Obs", _pe.Obs);
                command.Parameters.AddWithValue("@Estado", _pe.Estado_actual);
                command.Parameters.AddWithValue("@TipoEnvio", _pe.Tipo);
                command.Parameters.AddWithValue("@idCli", _pe.NCliente.Id);
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
        public void Modificacion(Pedido pe)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "UPDATE Pedidos SET Observacion = @Obs, EstadoPedido = @Estado WHERE idPedido = @ID";
                command.Parameters.AddWithValue("@Obs", pe.Obs);
                command.Parameters.AddWithValue("@Estado", pe.Estado_actual);
                command.Parameters.AddWithValue("@ID", pe.Numpedido);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch(Exception ex)
            {
                string excep = ex.ToString();
            }
        }
        public void Baja(int idPedido)
        {
            string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
            var conexion = new SQLiteConnection(cadena);
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = "Delete From Pedidos Where idPedido = @idPedido";
            command.Parameters.AddWithValue("@idPedido", idPedido);
            command.ExecuteNonQuery();
            conexion.Close();
        }
        public Cadete CadeteAsignado(int IDPedido)
        {
            Cadete Cad = new Cadete();
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = @"Select
                                        idCadete,
                                        NombreCadete,
                                        DireccionCadete,
                                        TelefonoCadete,
                                        TipoTransporte,
                                        From Pedidos
                                        Inner Join Cadetes using (idCadete);
                                        Where idPedido = IDPedido";
                command.Parameters.AddWithValue("@IDPedido", IDPedido);
                SQLiteDataReader reader = command.ExecuteReader();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cad.Id = Convert.ToInt32(reader["idCadete"]);
                    Cad.Nombre = reader["NombreCadete"].ToString();
                    Cad.Direccion = reader["DireccionCadete"].ToString();
                    Cad.Telefono = reader["TelefonoCadete"].ToString();
                    Cad.TipoT = (TipoTransporte)Convert.ToInt32(reader["TipoTransporte"]);
                }
                reader.Close();
                conexion.Close();
                return Cad;
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
                return Cad;
            }
        }
    }
}
