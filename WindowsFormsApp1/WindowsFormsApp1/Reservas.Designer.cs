namespace WindowsFormsApp1
{
    partial class Reservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxhuesped = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxhabitacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textPersonas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonreservar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateEntrada = new System.Windows.Forms.DateTimePicker();
            this.dateSalida = new System.Windows.Forms.DateTimePicker();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.dataGridReserva = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Habitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Reservas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva Reserva";
            // 
            // comboBoxhuesped
            // 
            this.comboBoxhuesped.FormattingEnabled = true;
            this.comboBoxhuesped.Location = new System.Drawing.Point(372, 108);
            this.comboBoxhuesped.Name = "comboBoxhuesped";
            this.comboBoxhuesped.Size = new System.Drawing.Size(297, 21);
            this.comboBoxhuesped.TabIndex = 2;
            this.comboBoxhuesped.SelectedIndexChanged += new System.EventHandler(this.comboBoxhuesped_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Huespedes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Habitacion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBoxhabitacion
            // 
            this.comboBoxhabitacion.FormattingEnabled = true;
            this.comboBoxhabitacion.Location = new System.Drawing.Point(372, 151);
            this.comboBoxhabitacion.Name = "comboBoxhabitacion";
            this.comboBoxhabitacion.Size = new System.Drawing.Size(297, 21);
            this.comboBoxhabitacion.TabIndex = 5;
            this.comboBoxhabitacion.SelectedIndexChanged += new System.EventHandler(this.comboBoxhabitacion_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha de entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fecha de salida";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Personas";
            // 
            // textPersonas
            // 
            this.textPersonas.Location = new System.Drawing.Point(372, 266);
            this.textPersonas.Name = "textPersonas";
            this.textPersonas.Size = new System.Drawing.Size(51, 20);
            this.textPersonas.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Estado";
            // 
            // buttonreservar
            // 
            this.buttonreservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonreservar.Location = new System.Drawing.Point(234, 368);
            this.buttonreservar.Name = "buttonreservar";
            this.buttonreservar.Size = new System.Drawing.Size(156, 41);
            this.buttonreservar.TabIndex = 12;
            this.buttonreservar.Text = "Reservar";
            this.buttonreservar.UseVisualStyleBackColor = true;
            this.buttonreservar.Click += new System.EventHandler(this.buttonreservar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(482, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateEntrada
            // 
            this.dateEntrada.Location = new System.Drawing.Point(372, 192);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.Size = new System.Drawing.Size(266, 20);
            this.dateEntrada.TabIndex = 14;
            // 
            // dateSalida
            // 
            this.dateSalida.Location = new System.Drawing.Point(372, 234);
            this.dateSalida.Name = "dateSalida";
            this.dateSalida.Size = new System.Drawing.Size(266, 20);
            this.dateSalida.TabIndex = 15;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.Location = new System.Drawing.Point(372, 307);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(123, 20);
            this.textBoxEstado.TabIndex = 16;
            this.textBoxEstado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridReserva
            // 
            this.dataGridReserva.AllowUserToAddRows = false;
            this.dataGridReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Habitacion,
            this.Entrada,
            this.Salida,
            this.Personas,
            this.Borrar,
            this.Editar});
            this.dataGridReserva.Location = new System.Drawing.Point(12, 415);
            this.dataGridReserva.Name = "dataGridReserva";
            this.dataGridReserva.Size = new System.Drawing.Size(763, 150);
            this.dataGridReserva.TabIndex = 18;
            this.dataGridReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Habitacion
            // 
            this.Habitacion.HeaderText = "Habitacion";
            this.Habitacion.Name = "Habitacion";
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Entrada";
            this.Entrada.Name = "Entrada";
            this.Entrada.Width = 110;
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Salida";
            this.Salida.Name = "Salida";
            this.Salida.Width = 110;
            // 
            // Personas
            // 
            this.Personas.HeaderText = "Personas";
            this.Personas.Name = "Personas";
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Name = "Borrar";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 569);
            this.Controls.Add(this.dataGridReserva);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.dateSalida);
            this.Controls.Add(this.dateEntrada);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonreservar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textPersonas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxhabitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxhuesped);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Reservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxhuesped;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxhabitacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPersonas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonreservar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateEntrada;
        private System.Windows.Forms.DateTimePicker dateSalida;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.DataGridView dataGridReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personas;
        private System.Windows.Forms.DataGridViewButtonColumn Borrar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}