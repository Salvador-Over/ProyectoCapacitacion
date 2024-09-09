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
        private void LlenarComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add("Seleccionar");
            comboBox.Items.Add("Activo");
            comboBox.Items.Add("Inactivo");
            comboBox.SelectedIndex = 0;
        }
        public Consulta()
        {
            InitializeComponent();
            LlenarComboBox(cboEstadoEmp);
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

        private void eliminarEmp_Click(object sender, EventArgs e)
        {
            /*  if (Dgv.SelectedRows.Count > 0)
  {
      // Obtener el ID del registro seleccionado
      int id = Convert.ToInt32(Dgv.SelectedRows[0].Cells["id"].Value);

      // Confirmar la eliminación
      DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);

      if (result == DialogResult.Yes)
      {
          //bool eliminado = Controlador.EliminarRegistro(id);

         if (eliminado)
          {
              MessageBox.Show("Registro marcado como inactivo.");
              CargarDatosEnVista(); // Volver a cargar los datos después de la eliminación
          }
          else
          {
              MessageBox.Show("No se pudo eliminar el registro.");
          }
      }
  }
  else
  {
      MessageBox.Show("Por favor selecciona un registro.");
  }*/
        }
        private void CargarDatosEnVista()
        {
            // Llama al método del controlador para obtener los datos
            //DataTable data = Controlador.CargarDatos();

            // Asigna los datos al DataGridView
            //Dgv.DataSource = data;
        }
    }
}
