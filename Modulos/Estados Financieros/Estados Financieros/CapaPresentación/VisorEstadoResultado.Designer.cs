namespace CapaPresentación
{
    partial class VisorEstadoResultado
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
            this.EstadoResultados = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.EstadoResultados1 = new CapaPresentación.EstadoResultados();
            this.SuspendLayout();
            // 
            // EstadoResultados
            // 
            this.EstadoResultados.ActiveViewIndex = 0;
            this.EstadoResultados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EstadoResultados.Cursor = System.Windows.Forms.Cursors.Default;
            this.EstadoResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EstadoResultados.Location = new System.Drawing.Point(0, 0);
            this.EstadoResultados.Name = "EstadoResultados";
            this.EstadoResultados.ReportSource = this.EstadoResultados1;
            this.EstadoResultados.Size = new System.Drawing.Size(734, 465);
            this.EstadoResultados.TabIndex = 0;
            this.EstadoResultados.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorEstadoResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 465);
            this.Controls.Add(this.EstadoResultados);
            this.Name = "VisorEstadoResultado";
            this.Text = "VisorEstadoResultado";
            this.ResumeLayout(false);

        }

        #endregion
        public CrystalDecisions.Windows.Forms.CrystalReportViewer EstadoResultados;
        private EstadoResultados EstadoResultados1;
    }
}