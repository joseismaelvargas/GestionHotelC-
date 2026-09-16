using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formgestion : Form
    { 
        public List<Huespedes> huespedesregistrados;
        int filaEditando = -1;
        public Formgestion(List <Huespedes> huespedesregistrados)
        {
            InitializeComponent();
            this.huespedesregistrados = huespedesregistrados;
            
        }
        public void LimpiarCampos()
        {
            textDni.Text = "";
            textEmail.Text = "";
            texttelefono.Text = "";
            txtnombre.Text = "";
        }

        private void Formgestion_Load(object sender, EventArgs e)
        {

        }
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            int dniconvet = int.Parse(textDni.Text);
            int telefonoconvert = int.Parse(texttelefono.Text);

            if (filaEditando != -1)
            {
                // Modificar el objeto de la lista
                huespedesregistrados[filaEditando].Nombre = txtnombre.Text;
                huespedesregistrados[filaEditando].Dni = dniconvet;
                huespedesregistrados[filaEditando].Telefono = telefonoconvert;
                huespedesregistrados[filaEditando].Email = textEmail.Text;

                // Modificar la fila del DataGridView
                dataGridHuespedes.Rows[filaEditando].Cells[0].Value = txtnombre.Text;
                dataGridHuespedes.Rows[filaEditando].Cells[1].Value = dniconvet;
                dataGridHuespedes.Rows[filaEditando].Cells[2].Value = telefonoconvert;
                dataGridHuespedes.Rows[filaEditando].Cells[3].Value = textEmail.Text;

                MessageBox.Show("Huésped editado correctamente");

                filaEditando = -1;
            }
            else
            {
                // Crear nuevo huésped
                Huespedes nuevoHuespedes = new Huespedes(
                    txtnombre.Text,
                    dniconvet,
                    textEmail.Text,
                    telefonoconvert
                );

                huespedesregistrados.Add(nuevoHuespedes);

                dataGridHuespedes.Rows.Add(
                    nuevoHuespedes.Nombre,
                    nuevoHuespedes.Dni,
                    nuevoHuespedes.Telefono,
                    nuevoHuespedes.Email
                );

                MessageBox.Show("Se agregó correctamente el huésped");
            }

            LimpiarCampos();
        }
        //EventOpcode  para datagrid

        private void listView1_SelectedIndexChanged(  object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void listahuesped_Click(object sender, EventArgs e)
        {

        }

        private void sm(object sender, EventArgs e)
        {

        }

        private void dataGridHuespedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridHuespedes.Columns[e.ColumnIndex].Name == "Editar")
            {
                filaEditando = e.RowIndex;

                txtnombre.Text = dataGridHuespedes.Rows[e.RowIndex].Cells[0].Value.ToString();
                textDni.Text = dataGridHuespedes.Rows[e.RowIndex].Cells[1].Value.ToString();
                texttelefono.Text = dataGridHuespedes.Rows[e.RowIndex].Cells[2].Value.ToString();
                textEmail.Text = dataGridHuespedes.Rows[e.RowIndex].Cells[3].Value.ToString();

                MessageBox.Show("Ahora podés modificar los datos");

            }

            if (dataGridHuespedes.Columns[e.ColumnIndex].Name == "buttonborrar")
            {
                DialogResult resultado = MessageBox.Show(
           "¿Querés eliminar este huésped?",
           "Confirmar eliminación",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);
                
                if (resultado == DialogResult.Yes)
            {
                // Eliminar de la lista
                huespedesregistrados.RemoveAt(e.RowIndex);

                // Eliminar del DataGridView
                dataGridHuespedes.Rows.RemoveAt(e.RowIndex);

                MessageBox.Show("Huésped eliminado correctamente");
            }
            }

            
        }
    }
}
