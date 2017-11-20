namespace enlaces
{
    partial class poliza_batch
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
            this.Dgv_insertar_partida = new System.Windows.Forms.DataGridView();
            this.nm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_auxiliar = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_mostrarDetalle = new System.Windows.Forms.DataGridView();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_agregarpoliza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_saldos = new System.Windows.Forms.Button();
            this.Btn_agregarfila = new System.Windows.Forms.Button();
            this.Txt_Haber = new System.Windows.Forms.TextBox();
            this.Txt_Debe = new System.Windows.Forms.TextBox();
            this.Lbl_detalle_partida = new System.Windows.Forms.Label();
            this.Dgv_detalle_partida = new System.Windows.Forms.DataGridView();
            this.nump = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_partida = new System.Windows.Forms.DataGridView();
            this.Lbl_partida = new System.Windows.Forms.Label();
            this.Cmb_mes = new System.Windows.Forms.ComboBox();
            this.Cmb_anio = new System.Windows.Forms.ComboBox();
            this.Lbl_mes = new System.Windows.Forms.Label();
            this.Lbl_anio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_insertar_partida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_auxiliar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle_partida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_partida)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_insertar_partida
            // 
            this.Dgv_insertar_partida.AllowUserToAddRows = false;
            this.Dgv_insertar_partida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_insertar_partida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nm,
            this.razon,
            this.fecha});
            this.Dgv_insertar_partida.Location = new System.Drawing.Point(7, 48);
            this.Dgv_insertar_partida.Name = "Dgv_insertar_partida";
            this.Dgv_insertar_partida.Size = new System.Drawing.Size(583, 111);
            this.Dgv_insertar_partida.TabIndex = 74;
            this.Dgv_insertar_partida.Visible = false;
            this.Dgv_insertar_partida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_insertar_partida_CellContentClick);
            // 
            // nm
            // 
            this.nm.HeaderText = "num";
            this.nm.Name = "nm";
            this.nm.ReadOnly = true;
            // 
            // razon
            // 
            this.razon.HeaderText = "razón de partida";
            this.razon.Name = "razon";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Dgv_auxiliar
            // 
            this.Dgv_auxiliar.AllowUserToAddRows = false;
            this.Dgv_auxiliar.AllowUserToOrderColumns = true;
            this.Dgv_auxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_auxiliar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.cnta,
            this.db,
            this.hb});
            this.Dgv_auxiliar.Location = new System.Drawing.Point(7, 212);
            this.Dgv_auxiliar.Name = "Dgv_auxiliar";
            this.Dgv_auxiliar.Size = new System.Drawing.Size(583, 121);
            this.Dgv_auxiliar.TabIndex = 73;
            // 
            // num
            // 
            this.num.HeaderText = "num";
            this.num.Name = "num";
            // 
            // cnta
            // 
            this.cnta.HeaderText = "cuenta";
            this.cnta.Name = "cnta";
            this.cnta.ReadOnly = true;
            // 
            // db
            // 
            this.db.HeaderText = "debe";
            this.db.Name = "db";
            this.db.ReadOnly = true;
            // 
            // hb
            // 
            this.hb.HeaderText = "haber";
            this.hb.Name = "hb";
            this.hb.ReadOnly = true;
            // 
            // Dgv_mostrarDetalle
            // 
            this.Dgv_mostrarDetalle.AllowUserToAddRows = false;
            this.Dgv_mostrarDetalle.AllowUserToOrderColumns = true;
            this.Dgv_mostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_mostrarDetalle.Location = new System.Drawing.Point(7, 212);
            this.Dgv_mostrarDetalle.Name = "Dgv_mostrarDetalle";
            this.Dgv_mostrarDetalle.Size = new System.Drawing.Size(583, 121);
            this.Dgv_mostrarDetalle.TabIndex = 72;
            this.Dgv_mostrarDetalle.Visible = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Enabled = false;
            this.Btn_eliminar.Location = new System.Drawing.Point(7, 373);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(143, 23);
            this.Btn_eliminar.TabIndex = 71;
            this.Btn_eliminar.Text = "Eliminar Fila Seleccionada";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_agregarpoliza
            // 
            this.Btn_agregarpoliza.Location = new System.Drawing.Point(7, 165);
            this.Btn_agregarpoliza.Name = "Btn_agregarpoliza";
            this.Btn_agregarpoliza.Size = new System.Drawing.Size(98, 23);
            this.Btn_agregarpoliza.TabIndex = 70;
            this.Btn_agregarpoliza.Text = "Nueva Póliza";
            this.Btn_agregarpoliza.UseVisualStyleBackColor = true;
            this.Btn_agregarpoliza.Click += new System.EventHandler(this.Btn_agregarpoliza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Haber";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Debe:";
            // 
            // Btn_saldos
            // 
            this.Btn_saldos.Enabled = false;
            this.Btn_saldos.Location = new System.Drawing.Point(464, 373);
            this.Btn_saldos.Name = "Btn_saldos";
            this.Btn_saldos.Size = new System.Drawing.Size(118, 23);
            this.Btn_saldos.TabIndex = 67;
            this.Btn_saldos.Text = "Guardar";
            this.Btn_saldos.UseVisualStyleBackColor = true;
            this.Btn_saldos.Click += new System.EventHandler(this.Btn_saldos_Click);
            // 
            // Btn_agregarfila
            // 
            this.Btn_agregarfila.Enabled = false;
            this.Btn_agregarfila.Location = new System.Drawing.Point(7, 344);
            this.Btn_agregarfila.Name = "Btn_agregarfila";
            this.Btn_agregarfila.Size = new System.Drawing.Size(143, 23);
            this.Btn_agregarfila.TabIndex = 66;
            this.Btn_agregarfila.Text = "Agregar Nueva Fila";
            this.Btn_agregarfila.UseVisualStyleBackColor = true;
            this.Btn_agregarfila.Click += new System.EventHandler(this.Btn_agregarfila_Click);
            // 
            // Txt_Haber
            // 
            this.Txt_Haber.Location = new System.Drawing.Point(295, 363);
            this.Txt_Haber.Name = "Txt_Haber";
            this.Txt_Haber.Size = new System.Drawing.Size(100, 20);
            this.Txt_Haber.TabIndex = 65;
            this.Txt_Haber.Text = "0.00";
            // 
            // Txt_Debe
            // 
            this.Txt_Debe.BackColor = System.Drawing.Color.White;
            this.Txt_Debe.Location = new System.Drawing.Point(189, 363);
            this.Txt_Debe.Name = "Txt_Debe";
            this.Txt_Debe.Size = new System.Drawing.Size(100, 20);
            this.Txt_Debe.TabIndex = 64;
            this.Txt_Debe.Text = "0.00";
            // 
            // Lbl_detalle_partida
            // 
            this.Lbl_detalle_partida.AutoSize = true;
            this.Lbl_detalle_partida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_detalle_partida.ForeColor = System.Drawing.Color.White;
            this.Lbl_detalle_partida.Location = new System.Drawing.Point(212, 189);
            this.Lbl_detalle_partida.Name = "Lbl_detalle_partida";
            this.Lbl_detalle_partida.Size = new System.Drawing.Size(155, 20);
            this.Lbl_detalle_partida.TabIndex = 63;
            this.Lbl_detalle_partida.Text = "DETALLE PARTIDA";
            // 
            // Dgv_detalle_partida
            // 
            this.Dgv_detalle_partida.AllowUserToAddRows = false;
            this.Dgv_detalle_partida.AllowUserToOrderColumns = true;
            this.Dgv_detalle_partida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_detalle_partida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nump,
            this.cuenta,
            this.debe,
            this.haber});
            this.Dgv_detalle_partida.Location = new System.Drawing.Point(7, 212);
            this.Dgv_detalle_partida.Name = "Dgv_detalle_partida";
            this.Dgv_detalle_partida.Size = new System.Drawing.Size(583, 121);
            this.Dgv_detalle_partida.TabIndex = 62;
            this.Dgv_detalle_partida.Visible = false;
            // 
            // nump
            // 
            this.nump.HeaderText = "num";
            this.nump.Name = "nump";
            // 
            // cuenta
            // 
            this.cuenta.HeaderText = "cuenta";
            this.cuenta.Items.AddRange(new object[] {
            "agregar cuenta",
            "1-activo",
            "11-activo corriente",
            "111-banco",
            "112-documentos por cobrar",
            "2-pasivo",
            "21-documentos por pagar"});
            this.cuenta.Name = "cuenta";
            // 
            // debe
            // 
            this.debe.HeaderText = "debe";
            this.debe.Name = "debe";
            // 
            // haber
            // 
            this.haber.HeaderText = "haber";
            this.haber.Name = "haber";
            // 
            // Dgv_partida
            // 
            this.Dgv_partida.AllowUserToAddRows = false;
            this.Dgv_partida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_partida.Location = new System.Drawing.Point(7, 48);
            this.Dgv_partida.Name = "Dgv_partida";
            this.Dgv_partida.Size = new System.Drawing.Size(583, 111);
            this.Dgv_partida.TabIndex = 61;
            // 
            // Lbl_partida
            // 
            this.Lbl_partida.AutoSize = true;
            this.Lbl_partida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_partida.ForeColor = System.Drawing.Color.White;
            this.Lbl_partida.Location = new System.Drawing.Point(240, 25);
            this.Lbl_partida.Name = "Lbl_partida";
            this.Lbl_partida.Size = new System.Drawing.Size(90, 20);
            this.Lbl_partida.TabIndex = 60;
            this.Lbl_partida.Text = "PARTIDAS";
            // 
            // Cmb_mes
            // 
            this.Cmb_mes.FormattingEnabled = true;
            this.Cmb_mes.Items.AddRange(new object[] {
            "enero",
            "febrero",
            "marzo",
            "abril",
            "mayo",
            "junio",
            "julio",
            "agosto",
            "septiembre",
            "octubre",
            "noviembre",
            "diciembre"});
            this.Cmb_mes.Location = new System.Drawing.Point(469, 10);
            this.Cmb_mes.Name = "Cmb_mes";
            this.Cmb_mes.Size = new System.Drawing.Size(121, 21);
            this.Cmb_mes.TabIndex = 59;
            this.Cmb_mes.Visible = false;
            // 
            // Cmb_anio
            // 
            this.Cmb_anio.FormattingEnabled = true;
            this.Cmb_anio.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019"});
            this.Cmb_anio.Location = new System.Drawing.Point(122, 10);
            this.Cmb_anio.Name = "Cmb_anio";
            this.Cmb_anio.Size = new System.Drawing.Size(121, 21);
            this.Cmb_anio.TabIndex = 58;
            this.Cmb_anio.Visible = false;
            // 
            // Lbl_mes
            // 
            this.Lbl_mes.AutoSize = true;
            this.Lbl_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mes.ForeColor = System.Drawing.Color.White;
            this.Lbl_mes.Location = new System.Drawing.Point(384, 11);
            this.Lbl_mes.Name = "Lbl_mes";
            this.Lbl_mes.Size = new System.Drawing.Size(44, 20);
            this.Lbl_mes.TabIndex = 57;
            this.Lbl_mes.Text = "MES";
            this.Lbl_mes.Visible = false;
            // 
            // Lbl_anio
            // 
            this.Lbl_anio.AutoSize = true;
            this.Lbl_anio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_anio.ForeColor = System.Drawing.Color.White;
            this.Lbl_anio.Location = new System.Drawing.Point(8, 8);
            this.Lbl_anio.Name = "Lbl_anio";
            this.Lbl_anio.Size = new System.Drawing.Size(43, 20);
            this.Lbl_anio.TabIndex = 56;
            this.Lbl_anio.Text = "AÑO";
            this.Lbl_anio.Visible = false;
            // 
            // poliza_batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(607, 441);
            this.Controls.Add(this.Dgv_insertar_partida);
            this.Controls.Add(this.Dgv_auxiliar);
            this.Controls.Add(this.Dgv_mostrarDetalle);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_agregarpoliza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_saldos);
            this.Controls.Add(this.Btn_agregarfila);
            this.Controls.Add(this.Txt_Haber);
            this.Controls.Add(this.Txt_Debe);
            this.Controls.Add(this.Lbl_detalle_partida);
            this.Controls.Add(this.Dgv_detalle_partida);
            this.Controls.Add(this.Dgv_partida);
            this.Controls.Add(this.Lbl_partida);
            this.Controls.Add(this.Cmb_mes);
            this.Controls.Add(this.Cmb_anio);
            this.Controls.Add(this.Lbl_mes);
            this.Controls.Add(this.Lbl_anio);
            this.Name = "poliza_batch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poliza En Batch - 4302";
            this.Load += new System.EventHandler(this.poliza_batch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_insertar_partida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_auxiliar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_detalle_partida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_partida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_insertar_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridView Dgv_auxiliar;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnta;
        private System.Windows.Forms.DataGridViewTextBoxColumn db;
        private System.Windows.Forms.DataGridViewTextBoxColumn hb;
        private System.Windows.Forms.DataGridView Dgv_mostrarDetalle;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_agregarpoliza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_saldos;
        private System.Windows.Forms.Button Btn_agregarfila;
        private System.Windows.Forms.TextBox Txt_Haber;
        private System.Windows.Forms.TextBox Txt_Debe;
        private System.Windows.Forms.Label Lbl_detalle_partida;
        private System.Windows.Forms.DataGridView Dgv_detalle_partida;
        private System.Windows.Forms.DataGridViewTextBoxColumn nump;
        private System.Windows.Forms.DataGridViewComboBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
        private System.Windows.Forms.DataGridView Dgv_partida;
        private System.Windows.Forms.Label Lbl_partida;
        private System.Windows.Forms.ComboBox Cmb_mes;
        private System.Windows.Forms.ComboBox Cmb_anio;
        private System.Windows.Forms.Label Lbl_mes;
        private System.Windows.Forms.Label Lbl_anio;
    }
}