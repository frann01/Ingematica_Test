namespace IngematicaAppTest
{
    partial class FrmTest
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
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicial = new System.Windows.Forms.Label();
            this.lblLocalidadDestino = new System.Windows.Forms.Label();
            this.cbLocalidadDestino = new System.Windows.Forms.ComboBox();
            this.lblTipoTransporte = new System.Windows.Forms.Label();
            this.cbTipoTransporte = new System.Windows.Forms.ComboBox();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.txtFechaLlegada = new System.Windows.Forms.TextBox();
            this.lblFechaLlegada = new System.Windows.Forms.Label();
            this.txtDiasDemora = new System.Windows.Forms.TextBox();
            this.lblDiasDemora = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbTipoRuta = new System.Windows.Forms.ComboBox();
            this.lblTipoRuta = new System.Windows.Forms.Label();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(179, 43);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(165, 24);
            this.dtpFechaInicial.TabIndex = 0;
            // 
            // lblFechaInicial
            // 
            this.lblFechaInicial.AutoSize = true;
            this.lblFechaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicial.Location = new System.Drawing.Point(13, 48);
            this.lblFechaInicial.Name = "lblFechaInicial";
            this.lblFechaInicial.Size = new System.Drawing.Size(89, 18);
            this.lblFechaInicial.TabIndex = 1;
            this.lblFechaInicial.Text = "Fecha Inicial";
            // 
            // lblLocalidadDestino
            // 
            this.lblLocalidadDestino.AutoSize = true;
            this.lblLocalidadDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadDestino.Location = new System.Drawing.Point(12, 100);
            this.lblLocalidadDestino.Name = "lblLocalidadDestino";
            this.lblLocalidadDestino.Size = new System.Drawing.Size(126, 18);
            this.lblLocalidadDestino.TabIndex = 2;
            this.lblLocalidadDestino.Text = "Localidad Destino";
            // 
            // cbLocalidadDestino
            // 
            this.cbLocalidadDestino.DisplayMember = "Id";
            this.cbLocalidadDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLocalidadDestino.FormattingEnabled = true;
            this.cbLocalidadDestino.Location = new System.Drawing.Point(179, 97);
            this.cbLocalidadDestino.Name = "cbLocalidadDestino";
            this.cbLocalidadDestino.Size = new System.Drawing.Size(165, 26);
            this.cbLocalidadDestino.TabIndex = 3;
            this.cbLocalidadDestino.ValueMember = "Id";
            // 
            // lblTipoTransporte
            // 
            this.lblTipoTransporte.AutoSize = true;
            this.lblTipoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoTransporte.Location = new System.Drawing.Point(13, 147);
            this.lblTipoTransporte.Name = "lblTipoTransporte";
            this.lblTipoTransporte.Size = new System.Drawing.Size(113, 18);
            this.lblTipoTransporte.TabIndex = 4;
            this.lblTipoTransporte.Text = "Tipo Transporte";
            // 
            // cbTipoTransporte
            // 
            this.cbTipoTransporte.AutoCompleteCustomSource.AddRange(new string[] {
            "Ruta",
            "Autopista"});
            this.cbTipoTransporte.DisplayMember = "Id";
            this.cbTipoTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoTransporte.FormattingEnabled = true;
            this.cbTipoTransporte.Location = new System.Drawing.Point(179, 144);
            this.cbTipoTransporte.Name = "cbTipoTransporte";
            this.cbTipoTransporte.Size = new System.Drawing.Size(165, 26);
            this.cbTipoTransporte.TabIndex = 5;
            this.cbTipoTransporte.ValueMember = "Id";
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.txtFechaLlegada);
            this.gbResultado.Controls.Add(this.lblFechaLlegada);
            this.gbResultado.Controls.Add(this.txtDiasDemora);
            this.gbResultado.Controls.Add(this.lblDiasDemora);
            this.gbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResultado.Location = new System.Drawing.Point(401, 43);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(394, 190);
            this.gbResultado.TabIndex = 6;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "Resultado";
            // 
            // txtFechaLlegada
            // 
            this.txtFechaLlegada.Location = new System.Drawing.Point(160, 97);
            this.txtFechaLlegada.Name = "txtFechaLlegada";
            this.txtFechaLlegada.Size = new System.Drawing.Size(165, 24);
            this.txtFechaLlegada.TabIndex = 3;
            // 
            // lblFechaLlegada
            // 
            this.lblFechaLlegada.AutoSize = true;
            this.lblFechaLlegada.Location = new System.Drawing.Point(20, 101);
            this.lblFechaLlegada.Name = "lblFechaLlegada";
            this.lblFechaLlegada.Size = new System.Drawing.Size(104, 18);
            this.lblFechaLlegada.TabIndex = 2;
            this.lblFechaLlegada.Text = "Fecha Llegada";
            // 
            // txtDiasDemora
            // 
            this.txtDiasDemora.Location = new System.Drawing.Point(160, 56);
            this.txtDiasDemora.Name = "txtDiasDemora";
            this.txtDiasDemora.Size = new System.Drawing.Size(165, 24);
            this.txtDiasDemora.TabIndex = 1;
            // 
            // lblDiasDemora
            // 
            this.lblDiasDemora.AutoSize = true;
            this.lblDiasDemora.Location = new System.Drawing.Point(20, 60);
            this.lblDiasDemora.Name = "lblDiasDemora";
            this.lblDiasDemora.Size = new System.Drawing.Size(96, 18);
            this.lblDiasDemora.TabIndex = 0;
            this.lblDiasDemora.Text = "Dias Demora";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(675, 263);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(124, 38);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(513, 263);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 38);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbTipoRuta
            // 
            this.cbTipoRuta.DisplayMember = "Id";
            this.cbTipoRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRuta.FormattingEnabled = true;
            this.cbTipoRuta.Location = new System.Drawing.Point(179, 194);
            this.cbTipoRuta.Name = "cbTipoRuta";
            this.cbTipoRuta.Size = new System.Drawing.Size(165, 26);
            this.cbTipoRuta.TabIndex = 9;
            this.cbTipoRuta.ValueMember = "Id";
            // 
            // lblTipoRuta
            // 
            this.lblTipoRuta.AutoSize = true;
            this.lblTipoRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoRuta.Location = new System.Drawing.Point(13, 197);
            this.lblTipoRuta.Name = "lblTipoRuta";
            this.lblTipoRuta.Size = new System.Drawing.Size(107, 18);
            this.lblTipoRuta.TabIndex = 10;
            this.lblTipoRuta.Text = "Tipo Recorrido";
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 373);
            this.Controls.Add(this.lblTipoRuta);
            this.Controls.Add(this.cbTipoRuta);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.cbTipoTransporte);
            this.Controls.Add(this.lblTipoTransporte);
            this.Controls.Add(this.cbLocalidadDestino);
            this.Controls.Add(this.lblLocalidadDestino);
            this.Controls.Add(this.lblFechaInicial);
            this.Controls.Add(this.dtpFechaInicial);
            this.Name = "FrmTest";
            this.Text = "Test";
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lblFechaInicial;
        private System.Windows.Forms.Label lblLocalidadDestino;
        private System.Windows.Forms.ComboBox cbLocalidadDestino;
        private System.Windows.Forms.Label lblTipoTransporte;
        private System.Windows.Forms.ComboBox cbTipoTransporte;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.Label lblDiasDemora;
        private System.Windows.Forms.TextBox txtFechaLlegada;
        private System.Windows.Forms.Label lblFechaLlegada;
        private System.Windows.Forms.TextBox txtDiasDemora;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cbTipoRuta;
        private System.Windows.Forms.Label lblTipoRuta;
    }
}

