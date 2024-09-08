using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Consulta : Form
    {
        Controlador cn = new Controlador();
        string emp = "empleados";
        public Consulta()
        {
            InitializeComponent();
        }
        //Mostrar los datos CAPA VISTA
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            Dgv.DataSource = dt;

        }
        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
