using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnexioBD
{
    public class Class1
    {
        public SqlConnection connexio;
        private String consulta;
        public DataSet dts;

        private String _ConnectionString;
        public String ConnectionString
        {
            get { return _ConnectionString; }
            set
            {
                _ConnectionString = value;
            }
        }

        public void Connectar(String codiBD)
        {
            connexio = new SqlConnection(codiBD);
        }

        public void PortarTaula()
        {
            Connectar();

            SqlDataAdapter adaptador;
            consulta = "Select * From Agencies";
            adaptador = new SqlDataAdapter(consulta, connexio);

            connexio.Open();
            dts = new DataSet();
            adaptador.Fill(dts, "Chamo"); //el nom que volguem
            connexio.Close();

            //DataGridView.DataSource = dts.Tables[0];
            //DataGridView.Columns[0].Visible = false;
        }
    }
}
