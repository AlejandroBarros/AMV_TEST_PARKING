namespace CapaPresentacion
{
    partial class CP_Registro
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
            this.btEntrada = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.dtHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.cmbTipos = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.btSalida = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btEntrada
            // 
            this.btEntrada.BackColor = System.Drawing.Color.PaleGreen;
            this.btEntrada.Location = new System.Drawing.Point(1007, 287);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Size = new System.Drawing.Size(188, 34);
            this.btEntrada.TabIndex = 16;
            this.btEntrada.Text = "Registrar Entrada";
            this.btEntrada.UseVisualStyleBackColor = false;
            this.btEntrada.Click += new System.EventHandler(this.btEntrada_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1003, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(844, 262);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(129, 20);
            this.lblEntrada.TabIndex = 14;
            this.lblEntrada.Text = "Hora de entrada:";
            // 
            // dtHoraEntrada
            // 
            this.dtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraEntrada.Location = new System.Drawing.Point(1010, 261);
            this.dtHoraEntrada.Name = "dtHoraEntrada";
            this.dtHoraEntrada.Size = new System.Drawing.Size(81, 20);
            this.dtHoraEntrada.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(844, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Matricula del Vehiculo";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(1010, 208);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(181, 20);
            this.txtMatricula.TabIndex = 11;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(844, 232);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(126, 20);
            this.lbltipo.TabIndex = 10;
            this.lbltipo.Text = "Tipo de Vehiculo";
            // 
            // cmbTipos
            // 
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(1010, 234);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(181, 21);
            this.cmbTipos.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 447);
            this.dataGridView1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(844, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hora de salida:";
            // 
            // dtHoraSalida
            // 
            this.dtHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraSalida.Location = new System.Drawing.Point(1010, 362);
            this.dtHoraSalida.Name = "dtHoraSalida";
            this.dtHoraSalida.Size = new System.Drawing.Size(81, 20);
            this.dtHoraSalida.TabIndex = 18;
            // 
            // btSalida
            // 
            this.btSalida.BackColor = System.Drawing.Color.IndianRed;
            this.btSalida.Location = new System.Drawing.Point(1003, 388);
            this.btSalida.Name = "btSalida";
            this.btSalida.Size = new System.Drawing.Size(188, 34);
            this.btSalida.TabIndex = 20;
            this.btSalida.Text = "Registrar Salida";
            this.btSalida.UseVisualStyleBackColor = false;
            this.btSalida.Click += new System.EventHandler(this.btSalida_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.LightSalmon;
            this.btEditar.Location = new System.Drawing.Point(136, 465);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(118, 34);
            this.btEditar.TabIndex = 21;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminar.Location = new System.Drawing.Point(12, 465);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(118, 34);
            this.btEliminar.TabIndex = 22;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // CP_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 510);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtHoraSalida);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btEntrada);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.dtHoraEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.cmbTipos);
            this.Name = "CP_Registro";
            this.Text = "CP_Registro";
            this.Load += new System.EventHandler(this.CP_Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEntrada;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.DateTimePicker dtHoraEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.ComboBox cmbTipos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtHoraSalida;
        private System.Windows.Forms.Button btSalida;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btEliminar;
    }
}