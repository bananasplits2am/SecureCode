using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash
{
    public partial class HashForm : Form
    {
        public HashForm()
        {
            InitializeComponent();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            TextBoxHashCode.Text = GenerateSalt();

            TextBoxHashPsswd.Text = ComputeHash(TextBoxPsswd.Text, Convert.FromBase64String(TextBoxHashCode.Text));
        }

        private const int SaltByteSize = 24;
        private const int HashByteSize = 24;
        private const int HasingIterationsCount = 10101;

        public static String ComputeHash(string password, byte[] salt, int iterations = HasingIterationsCount, int hashByteSize = HashByteSize)
        {
            Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt);

            hashGenerator.IterationCount = iterations;

            return Convert.ToBase64String(hashGenerator.GetBytes(hashByteSize));
        }

        public static String GenerateSalt(int saltByteSize = SaltByteSize)
        {
            RNGCryptoServiceProvider saltGenerator = new RNGCryptoServiceProvider();

            byte[] salt = new byte[saltByteSize];

            saltGenerator.GetBytes(salt);

            return Convert.ToBase64String(salt);

            //Converter_byte_array(salt);

            //return salt;
        }

        /*public static String Converter_byte_array(byte[] salt)
        {
            String codi = "";

            for (int i = 0; i < salt.GetLength(0); i++)
            {
                codi = codi + Convert.ToBase64String(salt[i]); //)Convert.ToChar(salt[i])

            }

            return codi;
        }*/
    }
}
