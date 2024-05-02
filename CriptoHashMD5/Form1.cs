using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriptoHashMD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            CriptoMD5 md5 = new CriptoMD5();
            txtSaida.Text = md5.RetornarMD5(txtEntrada.Text);
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            string senhaBanco = "81DC9BDB52D04DC20036DBD8313ED055"; // 1234 SEHHA SIMULADA
            string senha = txtEntrada.Text;

            CriptoMD5 MD5 = new CriptoMD5();

            bool res = MD5.CompararMD5(senha, senhaBanco);

            if (res)
            {
                labelResultado.Text = "Senhas iguais";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Senhas diferentes";
                labelResultado.ForeColor = Color.Red;
            }
        }
    }
}
