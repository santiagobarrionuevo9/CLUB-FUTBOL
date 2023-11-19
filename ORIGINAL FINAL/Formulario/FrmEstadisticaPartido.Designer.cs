namespace EquipoProgramacionEPF.Formulario
{
    partial class FrmEstadisticaPartido
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRojas = new System.Windows.Forms.TextBox();
            this.txttiempoJugado = new System.Windows.Forms.TextBox();
            this.txtAsistencias = new System.Windows.Forms.TextBox();
            this.txtGoles = new System.Windows.Forms.TextBox();
            this.txtAmarillas = new System.Windows.Forms.TextBox();
            this.cboJugador = new System.Windows.Forms.ComboBox();
            this.dgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.ColJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAsistencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmarilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRoja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoJugado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jugador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Goles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asistencias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amarillas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rojas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tiempo Jugado";
            // 
            // txtRojas
            // 
            this.txtRojas.Location = new System.Drawing.Point(518, 84);
            this.txtRojas.Name = "txtRojas";
            this.txtRojas.Size = new System.Drawing.Size(229, 22);
            this.txtRojas.TabIndex = 6;
            // 
            // txttiempoJugado
            // 
            this.txttiempoJugado.Location = new System.Drawing.Point(518, 144);
            this.txttiempoJugado.Name = "txttiempoJugado";
            this.txttiempoJugado.Size = new System.Drawing.Size(229, 22);
            this.txttiempoJugado.TabIndex = 6;
            this.txttiempoJugado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtAsistencias
            // 
            this.txtAsistencias.Location = new System.Drawing.Point(141, 144);
            this.txtAsistencias.Name = "txtAsistencias";
            this.txtAsistencias.Size = new System.Drawing.Size(229, 22);
            this.txtAsistencias.TabIndex = 7;
            // 
            // txtGoles
            // 
            this.txtGoles.Location = new System.Drawing.Point(141, 90);
            this.txtGoles.Name = "txtGoles";
            this.txtGoles.Size = new System.Drawing.Size(229, 22);
            this.txtGoles.TabIndex = 8;
            // 
            // txtAmarillas
            // 
            this.txtAmarillas.Location = new System.Drawing.Point(518, 31);
            this.txtAmarillas.Name = "txtAmarillas";
            this.txtAmarillas.Size = new System.Drawing.Size(229, 22);
            this.txtAmarillas.TabIndex = 9;
            // 
            // cboJugador
            // 
            this.cboJugador.FormattingEnabled = true;
            this.cboJugador.Location = new System.Drawing.Point(141, 28);
            this.cboJugador.Name = "cboJugador";
            this.cboJugador.Size = new System.Drawing.Size(229, 24);
            this.cboJugador.TabIndex = 11;
            // 
            // dgvEstadisticas
            // 
            this.dgvEstadisticas.AllowUserToAddRows = false;
            this.dgvEstadisticas.AllowUserToDeleteRows = false;
            this.dgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadisticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColJugador,
            this.ColAsistencias,
            this.ColGoles,
            this.ColAmarilla,
            this.ColRoja,
            this.TiempoJugado,
            this.ColBorrar});
            this.dgvEstadisticas.Location = new System.Drawing.Point(12, 193);
            this.dgvEstadisticas.Name = "dgvEstadisticas";
            this.dgvEstadisticas.ReadOnly = true;
            this.dgvEstadisticas.RowHeadersWidth = 51;
            this.dgvEstadisticas.RowTemplate.Height = 24;
            this.dgvEstadisticas.Size = new System.Drawing.Size(774, 217);
            this.dgvEstadisticas.TabIndex = 12;
            // 
            // ColJugador
            // 
            this.ColJugador.HeaderText = "Jugador";
            this.ColJugador.MinimumWidth = 6;
            this.ColJugador.Name = "ColJugador";
            this.ColJugador.ReadOnly = true;
            this.ColJugador.Width = 125;
            // 
            // ColAsistencias
            // 
            this.ColAsistencias.HeaderText = "Asistencias";
            this.ColAsistencias.MinimumWidth = 6;
            this.ColAsistencias.Name = "ColAsistencias";
            this.ColAsistencias.ReadOnly = true;
            this.ColAsistencias.Width = 125;
            // 
            // ColGoles
            // 
            this.ColGoles.HeaderText = "Goles";
            this.ColGoles.MinimumWidth = 6;
            this.ColGoles.Name = "ColGoles";
            this.ColGoles.ReadOnly = true;
            this.ColGoles.Width = 125;
            // 
            // ColAmarilla
            // 
            this.ColAmarilla.HeaderText = "Amarilla";
            this.ColAmarilla.MinimumWidth = 6;
            this.ColAmarilla.Name = "ColAmarilla";
            this.ColAmarilla.ReadOnly = true;
            this.ColAmarilla.Width = 80;
            // 
            // ColRoja
            // 
            this.ColRoja.HeaderText = "Roja";
            this.ColRoja.MinimumWidth = 6;
            this.ColRoja.Name = "ColRoja";
            this.ColRoja.ReadOnly = true;
            this.ColRoja.Width = 80;
            // 
            // TiempoJugado
            // 
            this.TiempoJugado.HeaderText = "Tiempo Jugado";
            this.TiempoJugado.MinimumWidth = 6;
            this.TiempoJugado.Name = "TiempoJugado";
            this.TiempoJugado.ReadOnly = true;
            this.TiempoJugado.Width = 125;
            // 
            // ColBorrar
            // 
            this.ColBorrar.HeaderText = "Borrar";
            this.ColBorrar.MinimumWidth = 6;
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.ReadOnly = true;
            this.ColBorrar.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(353, 440);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 47);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(646, 440);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 47);
            this.button3.TabIndex = 15;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(792, 193);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 43);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmEstadisticaPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 499);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvEstadisticas);
            this.Controls.Add(this.cboJugador);
            this.Controls.Add(this.txtAmarillas);
            this.Controls.Add(this.txtAsistencias);
            this.Controls.Add(this.txtGoles);
            this.Controls.Add(this.txttiempoJugado);
            this.Controls.Add(this.txtRojas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEstadisticaPartido";
            this.Text = "EstadisticaPartido";
            this.Load += new System.EventHandler(this.EstadisticaPartido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadisticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRojas;
        private System.Windows.Forms.TextBox txttiempoJugado;
        private System.Windows.Forms.TextBox txtAsistencias;
        private System.Windows.Forms.TextBox txtGoles;
        private System.Windows.Forms.TextBox txtAmarillas;
        private System.Windows.Forms.ComboBox cboJugador;
        private System.Windows.Forms.DataGridView dgvEstadisticas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsistencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmarilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRoja;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoJugado;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAgregar;
    }
}