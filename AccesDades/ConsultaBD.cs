using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AccesDades
{

    public partial class Formulari : Form
    {
        private SqlConnection connexio;
        private String consulta;
        private bool check_nou;
        DataSet dts;

        public Formulari()
        {
            InitializeComponent();
        }

        private void Connectar()
        {
            String codi;
            codi = "Data Source=DESKTOP-1NA7VLL\\SQLEXPRESS;Initial Catalog=bdBannanaSplit;Integrated Security=True";
            connexio = new SqlConnection(codi);
        }

        private void Portardades()
        {
            Connectar();

            SqlDataAdapter adaptador;
            consulta = "Select * From Agencies";
            adaptador = new SqlDataAdapter(consulta, connexio);

            connexio.Open();
            dts = new DataSet();
            adaptador.Fill(dts, "Chamo"); //el nom que volguem
            connexio.Close();

            DataGridView.DataSource = dts.Tables[0];
            DataGridView.Columns[0].Visible = false;
        }

        private void Formulari_Load(object sender, EventArgs e)
        {
            Portardades();
            Binding();
        }

        private void ButtonVeureDataSet_Click(object sender, EventArgs e)
        {
            String XMLbd = dts.GetXml();
            RichTextBoxXML.Text = XMLbd;
        }

        private void Actualitza()
        {
            connexio.Open();

            SqlDataAdapter adaptador;
            adaptador = new SqlDataAdapter(consulta, connexio);

            //SqlDataAdapter cmdBuilder;
            //cmdBuilder = new SqlDataAdapter(adaptador);

            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adaptador);

            if (dts.HasChanges())
            {
                int resultat = adaptador.Update(dts.Tables[0]);
                MessageBox.Show("Canvis totals: " + resultat.ToString());
            }

            connexio.Close();
        }

        private void Binding()
        {
            //netejar el enllaç
            TextBoxCodi.DataBindings.Clear();
            //el primer valor, el de text és el del filtre es la propietat que vlem importar, el segon la base de dades a la que fem referència, i el últim el valor que ha d tindre a la base de dades
            TextBoxCodi.DataBindings.Add("Text", dts.Tables[0], "CodeAgency");
            //crear el event de validar que es relaciona amb la línia de sota
            TextBoxCodi.Validated += new System.EventHandler(this.ValidarTextBox);

            TextBoxDescripcio.DataBindings.Clear();
            TextBoxDescripcio.DataBindings.Add("Text", dts.Tables[0], "DescAgency");
            TextBoxDescripcio.Validated += new System.EventHandler(ValidarTextBox);
        }

        private void ValidarTextBox(object sender, EventArgs e)
        {
            if (!check_nou)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //this for a reason i can not understand explodes every time
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        }

        private void ButtonActualitzar_Click(object sender, EventArgs e)
        {
            if (check_nou)
            {
                DataRow dr = dts.Tables[0].NewRow();

                dr["CodeAgency"] = TextBoxCodi.Text;
                dr["DescAgency"] = TextBoxDescripcio.Text;

                dts.Tables[0].Rows.Add(dr);

                check_nou = false;
            }

            Actualitza();
            Portardades();
            Binding();
        }

        private void ButtonNou_Click(object sender, EventArgs e)
        {
            TextBoxCodi.DataBindings.Clear();
            TextBoxDescripcio.DataBindings.Clear();

            TextBoxCodi.Text = "";
            TextBoxDescripcio.Text = "";

            check_nou = true;
        }
    }
}
