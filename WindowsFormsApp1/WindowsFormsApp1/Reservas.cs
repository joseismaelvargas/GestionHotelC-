using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Reservas : Form
    {
        //variable para editar 
        int varedit = -1;
        public List<Reserva> reservas;
        public  List<Habitacion> habitaciones;
        public List<Huespedes> huespedes;
        
        public Reservas(  List<Habitacion> habitaciones,List<Huespedes > huespedes,List<Reserva> reserva )
        {
            
            InitializeComponent();
            this.reservas = reserva;
            this.huespedes = huespedes;
            this.habitaciones = habitaciones;
            DatosRegistros();
            Cargaritem( habitaciones);
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void Cargaritem( List<Habitacion > habitacions)
        {
            if(comboBoxhabitacion.Text ==""||comboBoxhuesped.Text == "")
            {
                comboBoxhabitacion.Text = "Seleciones una Habitacion";

                comboBoxhuesped.Text = "Seleciones un huesped";
            }
            for(int i=0; i < huespedes.Count; i++)

            {
                comboBoxhuesped.Items.Add(huespedes[i].Nombre);
        

            }
            for (int i = 0; i < habitacions.Count; i++)

            {
                comboBoxhabitacion.Items.Add(habitacions[i].Numero);


            }


        }

        private void comboBoxhuesped_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Reservas_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxhabitacion_SelectedIndexChanged(object sender, EventArgs e)
        {

            int numerohabitacion = Convert.ToInt16(comboBoxhabitacion.Text);
            for(int i=0; i<habitaciones.Count; i++)
            {
                if (numerohabitacion == habitaciones[i].Numero)
                {
                    textBoxEstado.Text = habitaciones[i].Estado;
                }
            }
            
            
        }

        public void DatosRegistros()
        {
            for(int i = 0; i < reservas.Count; i++)
            {
                dataGridReserva.Rows.Add(
                    reservas[i].Huesped.Nombre,
                    reservas[i].Habitacion.Numero,
                    reservas[i].FechaEntrada,
                    reservas[i].FechaSalida,
                    reservas[i].CantidadPersonas,
                    "Borrar",
                    "Editar"
                    
                    );
            }
        }
        private void buttonreservar_Click(object sender, EventArgs e)
        {
            
       
            if (varedit != -1)
            {
                //Huespedes y habitacion son objetos por lo tanto se les tiene que agregar como objetos
              Huespedes editarhuesped = huespedes.FirstOrDefault(h => h.Nombre == comboBoxhuesped.Text);
                Habitacion editarHabitacion = habitaciones.FirstOrDefault(h => h.Numero == Convert.ToInt16(comboBoxhabitacion.Text));
                
                reservas[varedit].Huesped =editarhuesped ;
                reservas[varedit].Habitacion = editarHabitacion;
                reservas[varedit].FechaEntrada = dateEntrada.Value;
                reservas[varedit].FechaSalida = dateSalida.Value;
                reservas[varedit].CantidadPersonas = Convert.ToInt16(textPersonas.Text);
               

                dataGridReserva.Rows[varedit].Cells[0].Value = comboBoxhuesped.Text;
                dataGridReserva.Rows[varedit].Cells[1].Value = comboBoxhabitacion.Text;
                dataGridReserva.Rows[varedit].Cells[2].Value = dateEntrada.Text;
                dataGridReserva.Rows[varedit].Cells[3].Value = dateSalida.Text;
                dataGridReserva.Rows[varedit].Cells[4].Value = textPersonas.Text;
                //limpiar  formulario
                dateEntrada.Text = "";
                dateSalida.Text = "";
                comboBoxhabitacion.Text = "";
                comboBoxhuesped.Text = "";
                textBoxEstado.Text = "";
                textPersonas.Text = "";



                varedit = -1;


            }
            else
            {
                //algoritmo de selecion y creacion del objeto Reserva

                int numerohabitacion = Convert.ToInt16(comboBoxhabitacion.Text);
                //cambio
                Huespedes huespedSelecionado = huespedes.FirstOrDefault(h => h.Nombre == comboBoxhuesped.Text);

                Habitacion habitacionselecionado = habitaciones.FirstOrDefault(h => h.Numero == numerohabitacion);
                if (habitacionselecionado.Estado == "Disponible")
                {
                    habitacionselecionado.Estado = "Ocupado";
                }
            
                Reserva nuevaReserva = new Reserva
                {
                    Huesped =huespedSelecionado ,
                    FechaEntrada = dateEntrada.Value,
                    FechaSalida = dateSalida.Value,
                    Habitacion = habitacionselecionado,
                    CantidadPersonas = int.Parse(textPersonas.Text),



                };
                //limpiar  formulario
                dateEntrada.Text = "";
                dateSalida.Text = "";
                comboBoxhabitacion.Text = "";
                comboBoxhuesped.Text = "";
                textBoxEstado.Text = "";
                textPersonas.Text = "";

                reservas.Add(nuevaReserva);

                // La mostramos en el DataGridView
                dataGridReserva.Rows.Add(
                    nuevaReserva.Huesped.Nombre,
                    nuevaReserva.Habitacion.Numero,
                    nuevaReserva.FechaEntrada,
                    nuevaReserva.FechaSalida,
                    nuevaReserva.CantidadPersonas,
                    "Borrar","Editar"

                );
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if(dataGridReserva.Columns[e.ColumnIndex].Name == "Editar")

            {
                MessageBox.Show(
    $"varedit: {varedit}\nReservas: {reservas.Count}\nFilas: {dataGridReserva.Rows.Count}"
);
                varedit = e.RowIndex;

                comboBoxhuesped.Text = dataGridReserva.Rows[e.RowIndex].Cells[0].Value.ToString();
                comboBoxhabitacion.Text = dataGridReserva.Rows[e.RowIndex].Cells[1].Value.ToString();
                dateEntrada.Text = dataGridReserva.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateSalida.Text = dataGridReserva.Rows[e.RowIndex].Cells[3].Value.ToString();
           textPersonas.Text = dataGridReserva.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            if (dataGridReserva.Columns[e.ColumnIndex].Name == "Borrar")
            {
                DialogResult resultado = MessageBox.Show("Eliminar Reserva", "Confirmar ,",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question
                  );
                if (resultado == DialogResult.Yes)
                {
                    reservas.RemoveAt(e.RowIndex);
                    dataGridReserva.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Reserva eliminada Correctamente");
                }
            }
        }
    }
}
