using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConnexioBD
{
    public class ClasseMain
    {
        public SqlConnection connexio;
        private String consulta;
        public DataSet dts;
        private SqlDataAdapter adaptador;

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

        public void PortarTaula(String choosen_table) //retorna un dataset amb els registres de la taula
        {
            Connectar();

            SqlDataAdapter adaptador;
            consulta = "Select * From " + choosen_table; //comprobar que no sigui amb dbo.+nomtaula
            adaptador = new SqlDataAdapter(consulta, connexio);

            connexio.Open();
            dts = new DataSet();
            adaptador.Fill(dts, "BD"); //el nom que volguem
            connexio.Close();
        }

        public void PortarperConsulta(String consulta) //Rep Consulta i torna DataSet
        {
            Connectar();

            SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(consulta, connexio);

            connexio.Open();
            dts = new DataSet();
            adaptador.Fill(dts, "BD"); //el nom que volguem
            connexio.Close();
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

        public bool comprobar_psswd(String Nom, String Psswd)
        {
            bool compare_values = false;

            //en el cas de que com a mínim hi hagi un resultats, es pot utilitzar la línia: dts != null && dts.Tables.Count == 1 && ds.Tables["BD"].Rows.Count > 0;

            if ((!String.IsNullOrEmpty(Nom) && !String.IsNullOrEmpty(Psswd)) && (dts.Tables["BD"].Rows.Count == 1))
            {
                compare_values = Nom.Equals(dts.Tables["BD"].Rows[0][0]) && Psswd.Equals(dts.Tables["BD"].Rows[0][1]);
            }

            return compare_values;
        }
    }

    public class ClassHederat : ClasseMain
    {
        public void PortarperConsulta(String consulta, String nomDataTable) //Rep Consulta, nom a la DataTable i torna DataSet
        {
            Connectar();

            SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(consulta, connexio);

            connexio.Open();
            dts = new DataSet();
            adaptador.Fill(dts, nomDataTable); //el nom que volguem
            connexio.Close();
        }
    }

}
