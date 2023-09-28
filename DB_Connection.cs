using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

interface ITabla
{

    bool VerTablaPrimero(string sp);
    bool VerTablaSiguiente();
    bool VerTablaFinalizar();

}

class ConfiguracionDB
{
    // es un singleton
    private string servidor, baseDeDatos, usuario, clave;

    private static ConfiguracionDB instancia = null;
    private ConfiguracionDB()
    {
        servidor = ConfigurationManager.AppSettings["BDServidor"];
        baseDeDatos = ConfigurationManager.AppSettings["BDBase"];
        usuario = ConfigurationManager.AppSettings["BDUsuario"];
        clave = ConfigurationManager.AppSettings["BDClave"];
    }

    public static string obtenerStringdeConexion()
    {
        crearInstancia();
        return "Data Source=" + instancia.servidor + ";Initial Catalog="
                    + instancia.baseDeDatos +
                    ";Persist Security Info=True;User ID=" +
                    instancia.usuario + ";Password=" + instancia.clave;
    }

    public static void crearInstancia()
    {
        if(instancia == null)
        {
            instancia = new ConfiguracionDB();
        }
    }
}

class accesoBD
{
    static SqlConnection sqlConnection1 = null;
    protected SqlDataReader reader1;
    public accesoBD()
    {
        if (sqlConnection1 == null)
        {
            try
            {
                sqlConnection1 = new SqlConnection(
                                        ConfiguracionDB.obtenerStringdeConexion());
                if (sqlConnection1.State != ConnectionState.Open)
                { sqlConnection1.Open(); }
            }
            catch (Exception ex)
            { throw new Exception(ex.Message); }
        }
    }
    public void Ejecutar(String strsql)
    {
        SqlCommand cmd1 = new SqlCommand(strsql, sqlConnection1);

        try
        {
            cmd1.ExecuteNonQuery();
        }
        catch (Exception ex)
        { throw new Exception(ex.Message); }
    }
    public void finalizar()
    {
        sqlConnection1.Close();
    }
}
class Tabla_Datos
{
    internal int uno;

    public int valor { get; set; }



}
class Tabla_DB : accesoBD, ITabla
{
    public Tabla_Datos datos;
    SqlCommand cmd1;

    public Tabla_DB() : base()
    {
        datos = new Tabla_Datos();
    }
    public bool VerTablaPrimero(string sp)
     {

         cmd1 = new SqlCommand(sp, ObtenerConexion());
         reader1 = cmd1.ExecuteReader();
         return VerTablaSiguiente();
     }

    private SqlConnection ObtenerConexion()
    {
        throw new NotImplementedException();
    }

    public bool VerTablaSiguiente()
        {
            if (reader1.Read())
            {
                IDataRecord registro;
                registro = (IDataRecord)reader1;
                datos.uno = Int32.Parse(registro["uno"].ToString());

                return true;

            }
            return false;
        }
        public bool VerTablaFinalizar()
        {
            reader1.Close();
            return true;
        }
}
    class TestClass
    {
        static void Main(string[] args)
        {
            try
            {
            accesoBD bd = new accesoBD();
            for (int i = 0; i < 10; i++)
                    bd.Ejecutar("insert into pru values (" + i.ToString() + ")");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Tabla_DB uno;
                uno = new Tabla_DB();
                bool sigo = uno.VerTablaPrimero("select * from pru");
                while (sigo)
                {
                    Console.WriteLine(uno.datos.uno.ToString());
                    sigo = uno.VerTablaSiguiente();
                }
                uno.VerTablaFinalizar();
            }
            catch (Exception e)
            { Console.WriteLine(e.Message); }
        }
    }    