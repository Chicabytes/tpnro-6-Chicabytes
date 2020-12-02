using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace tp6.Models
{
    public class RepoClientes
    {
        public List<Cliente> GetAll()
        {
            List<Cliente> NClientes = new List<Cliente>();
            try
            {
                
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Select * from Clientes;";
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var cli = new Cliente(Convert.ToInt32(reader["idCliente"]), reader["NombreCliente"].ToString(), reader["DireccionCliente"].ToString(), reader["TelefonoCliente"].ToString(), Convert.ToInt32(reader["TipoEnvio"]), Convert.ToBoolean(reader["Cupon"]), Convert.ToDouble(reader["CostoTotal"]));
                    NClientes.Add(cli);
                }
                reader.Close();
                return NClientes;
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
                return NClientes;
            }
            
        }
        public void Alta(Cliente Cli)
        {
            try
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
            catch (Exception ex)
            {
                string excep = ex.ToString();
            }
        }

        public void Baja(int _id)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "DELETE FROM Clientes WHERE idCliente = @_id";
                command.Parameters.AddWithValue("@_id", _id);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
            }
            
        }

        public Cliente Buscar(int _id)
        {
            var Cli = new Cliente();
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Select * from Clientes where idCliente = @_id;";
                command.Parameters.AddWithValue("@_id", _id);
                
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Cli.Id = Convert.ToInt32(reader["idCliente"]);
                    Cli.Nombre = reader["NombreCliente"].ToString();
                    Cli.Direccion = reader["DireccionCliente"].ToString();
                    Cli.Telefono = reader["TelefonoCliente"].ToString();
                    switch (Convert.ToInt32(reader["TipoEnvio"]))
                    {
                        case 0:
                            Cli.Tipo = TipoPedido.Delicado;
                            break;
                        case 1:
                            Cli.Tipo = TipoPedido.Express;
                            break;
                        case 2:
                            Cli.Tipo = TipoPedido.Ecologico;
                            break;
                    }
                    Cli.Cupon = Convert.ToBoolean(reader["Cupon"]);
                    Cli.Costo_total = Convert.ToDouble(reader["CostoTotal"]);
                }
                return Cli;
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
                return Cli;
            }
            
        }
        public void Modificar(Cliente Cli)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "UPDATE Clientes SET NombreCliente = @Nombre, DireccionCliente = @Direccion, TelefonoCliente = @Telefono, TipoEnvio = @Tipo, Cupon = @Cupon, CostoTotal = @CostoTotal WHERE idCliente = @ID";
                command.Parameters.AddWithValue("@ID", Cli.Id);
                command.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                command.Parameters.AddWithValue("@Direccion", Cli.Direccion);
                command.Parameters.AddWithValue("@Telefono", Cli.Telefono);
                int tipoenvio = Cli.NumeroEnvio();
                command.Parameters.AddWithValue("@Tipo", tipoenvio);
                command.Parameters.AddWithValue("@Cupon", Cli.Cupon);
                command.Parameters.AddWithValue("@CostoTotal", Cli.Costo_total);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
            }
            
        }
    }
}
