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
                    ped.Estado_actual = (EstadoPedido)Convert.ToInt32(reader["EstadoPedido"]);
                    ped.Tipo = (TipoPedido)Convert.ToInt32(reader["TipoEnvio"]);
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
                                        Inner Join Cadetes using (IdCadete)
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
                                        Inner Join Cadetes using (IdCadete)
                                        Inner Join Clientes using (IdCliente);";
                    command.Parameters.AddWithValue("@EstadoPedido", estado);
                }


                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var ped = new Pedido();
                    ped.Numpedido = Convert.ToInt32(reader["idPedido"]);

                    ped.Numpedido = Convert.ToInt32(reader["idPedido"]); 
                    ped.Obs = reader["Observacion"].ToString();
                    ped.Estado_actual = (EstadoPedido)(Convert.ToInt32(reader["EstadoPedido"])) ;
                    
                    ped.NCliente = new Cliente();
                    ped.NCliente.Nombre = reader["NombreCliente"].ToString();
                    
                    ped.Cadete = new Cadete();
                    ped.Cadete.Nombre = reader["NombreCadete"].ToString();


                    //switch (Convert.ToInt32(reader["EstadoPedido"]))
                    //{
                    //    case 0:
                    //        ped.Estado_actual = EstadoPedido.Recibido;
                    //        break;
                    //    case 1:
                    //        ped.Estado_actual = EstadoPedido.Preparado;
                    //        break;
                    //    case 2:
                    //        ped.Estado_actual = EstadoPedido.EnCamino;
                    //        break;
                    //    case 3:
                    //        ped.Estado_actual = EstadoPedido.Entregado;
                    //        break;
                    //}
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

        public void Alta(Pedido _pe, int _idCad)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Insert Into Pedidos(Observacion, TipoEnvio, EstadoPedido, idCliente, idCadete) values (@Obs, @TipoEnvio, @Estado, @idCli, @idCad)";
                command.Parameters.AddWithValue("@Obs", _pe.Obs);
                command.Parameters.AddWithValue("@Estado", _pe.Estado_actual);
                command.Parameters.AddWithValue("@TipoEnvio", _pe.Tipo);
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
        public void Modificacion(PedidoViewModel pe)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "UPDATE Pedidos SET Observacion = @Obs, EstadoPedido = @Estado WHERE idPedido = @ID";
                command.Parameters.AddWithValue("@Obs", pe.Observacion);
                command.Parameters.AddWithValue("@Estado", pe.Estado_actual);
                command.Parameters.AddWithValue("@ID", pe.IdPedido);
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
        /*
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
        }*/
    }
}
