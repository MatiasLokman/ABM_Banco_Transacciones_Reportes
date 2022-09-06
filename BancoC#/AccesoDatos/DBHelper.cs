using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient; // Para poder utilizar SQL
using System.Data; // Soporta las data tables


namespace Banco
{
    class DBHelper
    {
        SqlConnection conexion = new SqlConnection(Properties.Resources.cnnString);
        SqlCommand comando = new SqlCommand();

        #region Conectar
        private void conectar()
        {
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
        }
        #endregion

        #region Desconectar
        public void desconectar()
        {
            conexion.Close();
        }
        #endregion

        #region Leer
        public DataTable consultarDB(string procedimientoAlmacenado)
        {
            conectar();
            comando.CommandText = procedimientoAlmacenado;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader()); // Para ejecutar el Select
            desconectar(); // Desconectamos antes de retornar tabla - trabaja desconectado
            return tabla;
        }
        #endregion

        #region Insertar
        public bool agregarDB(int dni, string nombre, string apellido, int cbu, int saldo, int tipoCuenta, int ultimoMovimiento)
        {
            conectar();

            bool ok = true;
            SqlTransaction transaction = null;
            try
            {
                transaction = conexion.BeginTransaction();
                comando.Transaction = transaction;
                comando.CommandText = "AgregarCuenta";
                comando.Parameters.AddWithValue("@cbuCuenta", SqlDbType.Int).Value = cbu;
                comando.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = saldo;
                comando.Parameters.AddWithValue("@tipoCuenta", SqlDbType.Int).Value = tipoCuenta;
                comando.Parameters.AddWithValue("@ultimoMovimiento", SqlDbType.Money).Value = ultimoMovimiento;
                comando.ExecuteNonQuery(); // ejecuta la sentencia
                comando.Parameters.Clear();

                comando.CommandText = "AgregarCliente";
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                comando.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                comando.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = apellido;
                comando.Parameters.AddWithValue("@cbuCliente", SqlDbType.Int).Value = cbu;
                comando.ExecuteNonQuery(); // ejecuta la sentencia
                comando.Parameters.Clear();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        #endregion

        #region Actualizar
        public bool actualizarDB(int dni, string nombre, string apellido, int cbu, int saldo, int tipoCuenta, int ultimoMovimiento)
        {
            conectar();

            bool ok = true;
            SqlTransaction transaction = null;
            try
            {
                transaction = conexion.BeginTransaction();
                comando.Transaction = transaction;
                comando.CommandText = "ActualizarCuenta";
                comando.Parameters.AddWithValue("@cbuCuenta", SqlDbType.Int).Value = cbu;
                comando.Parameters.AddWithValue("@saldo", SqlDbType.Money).Value = saldo;
                comando.Parameters.AddWithValue("@tipoCuenta", SqlDbType.Int).Value = tipoCuenta;
                comando.Parameters.AddWithValue("@ultimoMovimiento", SqlDbType.Money).Value = ultimoMovimiento;
                comando.ExecuteNonQuery(); // ejecuta la sentencia
                comando.Parameters.Clear();

                comando.CommandText = "ActualizarCliente";
                comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                comando.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                comando.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = apellido;
                comando.Parameters.AddWithValue("@cbuCliente", SqlDbType.Int).Value = cbu;
                comando.ExecuteNonQuery(); // ejecuta la sentencia
                comando.Parameters.Clear();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        #endregion

        #region Eliminar
        public bool eliminarDB(int dni, int cbu)
        {
            conectar();

            bool ok = true;
            SqlTransaction transaction = null;
            try
            {
                    transaction = conexion.BeginTransaction();
                    comando.Transaction = transaction;
                    comando.CommandText = "EliminarCliente";
                    comando.Parameters.AddWithValue("@dni", SqlDbType.Int).Value = dni;
                    comando.ExecuteNonQuery(); // ejecuta la sentencia
                    comando.Parameters.Clear();

                    comando.CommandText = "EliminarCuenta";
                    comando.Parameters.AddWithValue("@cbuCuenta", SqlDbType.Int).Value = cbu;
                    comando.ExecuteNonQuery(); // ejecuta la sentencia
                    comando.Parameters.Clear();
                    transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        #endregion

        #region Estado
        public bool estadoDB(string procedimientoAlmacenado,int cbu)
        {
            conectar();

            bool ok = true;
            SqlTransaction transaction = null;
            try
            {
                transaction = conexion.BeginTransaction();
                comando.Transaction = transaction;
                comando.CommandText = procedimientoAlmacenado;
                comando.Parameters.AddWithValue("@cbuCuenta", SqlDbType.Int).Value = cbu;
                comando.ExecuteNonQuery(); // ejecuta la sentencia
                comando.Parameters.Clear();
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                ok = false;
            }
            finally
            {
                desconectar();
            }
            return ok;
        }
        #endregion
    }
}
