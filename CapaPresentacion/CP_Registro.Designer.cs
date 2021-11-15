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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblCountRegistros = new System.Windows.Forms.Label();
            this.lblOcupMinutos = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btEntrada
            // 
            this.btEntrada.BackColor = System.Drawing.Color.PaleGreen;
            this.btEntrada.Location = new System.Drawing.Point(1343, 353);
            this.btEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEntrada.Name = "btEntrada";
            this.btEntrada.Size = new System.Drawing.Size(251, 42);
            this.btEntrada.TabIndex = 16;
            this.btEntrada.Text = "Registrar Entrada";
            this.btEntrada.UseVisualStyleBackColor = false;
            this.btEntrada.Click += new System.EventHandler(this.btEntrada_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1337, 22);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(1125, 322);
            this.lblEntrada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(129, 20);
            this.lblEntrada.TabIndex = 14;
            this.lblEntrada.Text = "Hora de entrada:";
            // 
            // dtHoraEntrada
            // 
            this.dtHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraEntrada.Location = new System.Drawing.Point(1347, 321);
            this.dtHoraEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtHoraEntrada.Name = "dtHoraEntrada";
            this.dtHoraEntrada.Size = new System.Drawing.Size(107, 22);
            this.dtHoraEntrada.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1125, 254);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Matricula del Vehiculo";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(1347, 256);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(240, 22);
            this.txtMatricula.TabIndex = 11;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(1125, 286);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(126, 20);
            this.lbltipo.TabIndex = 10;
            this.lbltipo.Text = "Tipo de Vehiculo";
            // 
            // cmbTipos
            // 
            this.cmbTipos.FormattingEnabled = true;
            this.cmbTipos.Location = new System.Drawing.Point(1347, 288);
            this.cmbTipos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipos.Name = "cmbTipos";
            this.cmbTipos.Size = new System.Drawing.Size(240, 24);
            this.cmbTipos.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1009, 550);
            this.dataGridView1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1125, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Hora de salida:";
            // 
            // dtHoraSalida
            // 
            this.dtHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraSalida.Location = new System.Drawing.Point(1347, 446);
            this.dtHoraSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtHoraSalida.Name = "dtHoraSalida";
            this.dtHoraSalida.Size = new System.Drawing.Size(107, 22);
            this.dtHoraSalida.TabIndex = 18;
            // 
            // btSalida
            // 
            this.btSalida.BackColor = System.Drawing.Color.IndianRed;
            this.btSalida.Location = new System.Drawing.Point(1337, 478);
            this.btSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalida.Name = "btSalida";
            this.btSalida.Size = new System.Drawing.Size(251, 42);
            this.btSalida.TabIndex = 20;
            this.btSalida.Text = "Registrar Salida";
            this.btSalida.UseVisualStyleBackColor = false;
            this.btSalida.Click += new System.EventHandler(this.btSalida_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.LightSalmon;
            this.btEditar.Location = new System.Drawing.Point(181, 572);
            this.btEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(157, 42);
            this.btEditar.TabIndex = 21;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Visible = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminar.Location = new System.Drawing.Point(16, 572);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(157, 42);
            this.btEliminar.TabIndex = 22;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(1035, 22);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 16);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "lblUsername";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(1035, 50);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 16);
            this.lblPosition.TabIndex = 24;
            this.lblPosition.Text = "label4";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(1035, 79);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "label5";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1038, 113);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 23);
            this.btnLogout.TabIndex = 26;
            this.btnLogout.Text = "Cerrar Sesion";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(1420, 572);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(44, 16);
            this.lblIngresos.TabIndex = 27;
            this.lblIngresos.Text = "label3";
            this.lblIngresos.Visible = false;
            // 
            // lblCountRegistros
            // 
            this.lblCountRegistros.AutoSize = true;
            this.lblCountRegistros.Location = new System.Drawing.Point(1241, 572);
            this.lblCountRegistros.Name = "lblCountRegistros";
            this.lblCountRegistros.Size = new System.Drawing.Size(44, 16);
            this.lblCountRegistros.TabIndex = 28;
            this.lblCountRegistros.Text = "label3";
            this.lblCountRegistros.Visible = false;
            // 
            // lblOcupMinutos
            // 
            this.lblOcupMinutos.AutoSize = true;
            this.lblOcupMinutos.Location = new System.Drawing.Point(1066, 572);
            this.lblOcupMinutos.Name = "lblOcupMinutos";
            this.lblOcupMinutos.Size = new System.Drawing.Size(44, 16);
            this.lblOcupMinutos.TabIndex = 29;
            this.lblOcupMinutos.Text = "label3";
            this.lblOcupMinutos.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(939, 576);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 34);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // CP_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1617, 628);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblOcupMinutos);
            this.Controls.Add(this.lblCountRegistros);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblUsername);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblCountRegistros;
        private System.Windows.Forms.Label lblOcupMinutos;
        private System.Windows.Forms.Button btnActualizar;
    }
}