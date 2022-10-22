using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reportes2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string parametro { get; set; }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            parametro = "";
            // TODO: esta línea de código carga datos en la tabla 'conjuntoDatos.VerArticulos' Puede moverla o quitarla según sea necesario.
            this.verArticulosTableAdapter.Fill(this.conjuntoDatos.VerArticulos, parametro);
            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            parametro = txtParam.Text;

            this.verArticulosTableAdapter.Fill(this.conjuntoDatos.VerArticulos, parametro);
            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
