using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;

namespace ConnexioBD
{
    public class ClasseMain
    {
        public SqlConnection connexio;
        private String consulta;
        public DataSet dts;
        public SqlDataAdapter adaptador;

        private ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["BananaSplit"];

        /*private String _ConnectionString;
        public String ConnectionString
        {
            get { return _ConnectionString; }
            set
            {
                _ConnectionString = value;
            }
        }*/

        public void Connectar()   //es deixa en public ja que sino la funcio que es troba en public class ClassHederat : ClasseMain no ens dona accés
        {
            if (conf != null)
            {
                String cnx = conf.ConnectionString;
                connexio = new SqlConnection(cnx);
            }
        }

        public DataSet PortarTaula(String choosen_table) //retorna un dataset amb els registres de la taula
        {
            Connectar();

            //SqlDataAdapter adaptador;
            consulta = "Select * From " + choosen_table; //comprobar que no sigui amb dbo.+nomtaula
            adaptador = new SqlDataAdapter(consulta, connexio);

            connexio.Open();
            dts = new DataSet();
            adaptador.Fill(dts, "BD"); //el nom que volguem
            connexio.Close();

            return dts;
        }

        public DataSet PortarperConsulta(String consulta) //Rep Consulta i torna DataSet
        {
            Connectar();

            //SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(consulta, connexio);

            connexio.Open();
            dts = new DataSet();
            adaptador.Fill(dts, "BD"); //el nom que volguem
            connexio.Close();

            return dts;
        }

        public void Actualitzar()
        {
            connexio.Open();

            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adaptador);

            if (dts.HasChanges())
            {
                adaptador.Update(dts.Tables["BD"]);
            }

            connexio.Close();
        }

        public void Executar(String consulta)      //insert into users values (1, 'Guti')
        {
            Connectar();

            connexio.Open();

            SqlCommand cmd = new SqlCommand(consulta, connexio);
            int registresAfectats = cmd.ExecuteNonQuery();
            cmd.Dispose();

            connexio.Close();
        }

        //XIFRAR
        //private const int SaltByteSize = 24;
        private const int HashByteSize = 24;
        private const int HasingIterationsCount = 10101;
        public String ComputeHash(string password, int iterations = HasingIterationsCount, int hashByteSize = HashByteSize)
        {
            byte[] salt = Convert.FromBase64String((String)dts.Tables["BD"].Rows[0][2]);

            Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt);

            hashGenerator.IterationCount = iterations;

            return Convert.ToBase64String(hashGenerator.GetBytes(hashByteSize));
        }
        //---------

        public bool comprobar_psswd(String Nom, String Psswd)
        {
            bool compare_values = false;

            //en el cas de que com a mínim hi hagi un resultats, es pot utilitzar la línia: dts != null && dts.Tables.Count == 1 && ds.Tables["BD"].Rows.Count > 0;

            if (dts.Tables["BD"].Rows.Count >= 1)
            {
                compare_values = Nom.Equals(dts.Tables["BD"].Rows[0][0]) && Psswd.Equals(dts.Tables["BD"].Rows[0][1]);
            }

            return compare_values;
        }

        public String[] DatosUsuario(String user)
        {
            String consulta = "Select idUserRank, idUserCategory, UserName from Users Where Login like ('" + user + "')";

            PortarperConsulta(consulta);
            String[] DatoUser = new string[3];

            DatoUser[0] = dts.Tables["BD"].Rows[0][2].ToString(); //Guardamos el nombre del usuario
            DatoUser[1] = dts.Tables["BD"].Rows[0][1].ToString(); //Guardamos el idCategory
            DatoUser[2] = dts.Tables["BD"].Rows[0][0].ToString(); //Guardamos el idRank


            return DatoUser;
        }

        public String RangoUsuarioNombre(String IdRango)
        {
            String consulta = "Select idUserRank, DescRank from UserRanks Where idUserRank = " + IdRango + "";
            String RangoNombre;

            PortarperConsulta(consulta);
            RangoNombre = dts.Tables["BD"].Rows[0][1].ToString();

            return RangoNombre;
             
        }

        public int CategoriaUsuariNumero(String IdCategory)
        {
            String consulta = "Select idUserCategory, AccessLevel from UserCategories Where idUserCategory = " + IdCategory + "";
            String SAccesLevel;
            int IAccesLevel;

            PortarperConsulta(consulta);
            SAccesLevel = dts.Tables["BD"].Rows[0][1].ToString();
            IAccesLevel = Int32.Parse(SAccesLevel);

            return IAccesLevel;
        }

        public String FotoUsuario(String user)
        {
            String consulta = "Select photo from Users Where Login like ('" + user + "')";
            String FotoUsuario;

            PortarperConsulta(consulta);
            FotoUsuario = dts.Tables["BD"].Rows[0][0].ToString();

            return FotoUsuario;
        } 

        public int row_count(String consulta)
        {
            int contador = 0;

            PortarperConsulta(consulta);
            foreach (DataRow dts in dts.Tables["BD"].Rows)
            {
                contador++;
            }

            return contador;
        }

        public int column_count(String consulta)
        {
            int contador = 0;

            PortarperConsulta(consulta);
            foreach (DataColumn dts in dts.Tables["BD"].Columns)
            {
                contador++;
            }

            return contador;
        }
        public String[,] store_dts_to_array(String[,] DadesBoto)
        {
            for (int i = 0; i < DadesBoto.GetLength(0); i++)
            {
                for (int j = 0; j < DadesBoto.GetLength(1); j++)
                {
                    DadesBoto[i,j] = dts.Tables["BD"].Rows[i][j].ToString();
                }
            }
            
            //DadesBoto[0] = dts.Tables["BD"].Rows[0][2].ToString();

            return DadesBoto;
        }

    }

    public class ClassHederat : ClasseMain
    {
        public DataSet PortarperConsulta(String consulta, String nomDataTable) //Rep Consulta, nom a la DataTable i torna DataSet
        {
            Connectar();

            //SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(consulta, connexio);

            connexio.Open();
            dts = new DataSet();
            adaptador.Fill(dts, nomDataTable); //el nom que volguem
            connexio.Close();

            return dts;
        }
    }

}
