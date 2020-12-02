using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using tp6.ViewModel;

namespace tp6.Models
{
    public class RepoCadetes
    {
        public List<Cadete> GetAll()
        {
            List<Cadete> NCadetes = new List<Cadete>();
            try
            {

            string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
            var conexion = new SQLiteConnection(cadena);
            conexion.Open();
            var command = conexion.CreateCommand();
            command.CommandText = "Select * from Cadetes;";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                var cad = new Cadete(Convert.ToInt32(reader["idCadete"]), reader["NombreCadete"].ToString(), reader["DireccionCadete"].ToString(), reader["TelefonoCadete"].ToString(), Convert.ToInt32(reader["TipoTransporte"]));
                NCadetes.Add(cad);
            }
            reader.Close();
            return NCadetes;
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
                return NCadetes;
            }
            
        }
        public void Alta(Cadete _cad)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Insert Into Cadetes(NombreCadete, DireccionCadete, TelefonoCadete, TipoTransporte) values (@NombreCadete, @DireccionCadete, @TelefonoCadete, @TipoTransporte)";
                command.Parameters.AddWithValue("@NombreCadete", _cad.Nombre);
                command.Parameters.AddWithValue("@DireccionCadete", _cad.Direccion);
                command.Parameters.AddWithValue("@TelefonoCadete", _cad.Telefono);
                command.Parameters.AddWithValue("@TipoTransporte", _cad.TipoT);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
            }
            
        }
        public void Baja(int ID)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "DELETE FROM Cadetes WHERE idCadete = @_id";
                command.Parameters.AddWithValue("@_id", ID);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
            }
            
        }
        public void Modificar(Cadete cad)
        {
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "UPDATE Cadetes SET NombreCadete = @Nombre, DireccionCadete = @Direccion, TelefonoCadete = @Telefono, TipoTransporte = @TipoT WHERE idCadete = @ID";
                command.Parameters.AddWithValue("@ID", cad.Id);
                command.Parameters.AddWithValue("@Nombre", cad.Nombre);
                command.Parameters.AddWithValue("@Direccion", cad.Direccion);
                command.Parameters.AddWithValue("@Telefono", cad.Telefono);
                int Transporte = cad.NumeroTransporte();
                command.Parameters.AddWithValue("@TipoT", Transporte);
                command.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
            }
            
        }

        public Cadete Buscar(int _id)
        {
            var Cad = new Cadete();
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Select * from Cadetes where idCadete = @_id;";
                command.Parameters.AddWithValue("@_id", _id);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                
                    Cad.Id = Convert.ToInt32(reader["idCadete"]);
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
        public List<Cadete> Buscar(TipoPedido _Pedido)
        {
            var Cad = new Cadete();
            CadeteViewModel LCadetes = new CadeteViewModel();
            TipoTransporte _transporte = new TipoTransporte();
            LCadetes.ListaCadetes = new List<Cadete>();
            switch (_Pedido)
            {
                case TipoPedido.Delicado:
                    _transporte = TipoTransporte.Auto;
                    break;
                case TipoPedido.Express:
                    _transporte = TipoTransporte.Moto;
                    break;
                case TipoPedido.Ecologico:
                    _transporte = TipoTransporte.Bicicleta;
                    break;
                default:
                    break;
            }
            try
            {
                string cadena = "Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\tp6.db");
                var conexion = new SQLiteConnection(cadena);
                conexion.Open();
                var command = conexion.CreateCommand();
                command.CommandText = "Select * from Cadetes where TipoTransporte = @_transporte;";
                command.Parameters.AddWithValue("@_transporte", _transporte);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    Cad.Id = Convert.ToInt32(reader["idCadete"]);
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
                    LCadetes.ListaCadetes.Add(Cad);
                }
                return LCadetes.ListaCadetes;
            }
            catch (Exception ex)
            {
                string excep = ex.ToString();
                return LCadetes.ListaCadetes;
            }
        }
    }
}
