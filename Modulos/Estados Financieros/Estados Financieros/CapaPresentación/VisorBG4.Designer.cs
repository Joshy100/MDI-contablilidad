namespace CapaPresentación
{
    partial class VisorBG4
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
            this.BG4 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Balance_GeneralN41 = new CapaPresentación.Balance_GeneralN4();
            this.SuspendLayout();
            // 
            // BG4
            // 
            this.BG4.ActiveViewIndex = 0;
            this.BG4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BG4.Cursor = System.Windows.Forms.Cursors.Default;
            this.BG4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG4.Location = new System.Drawing.Point(0, 0);
            this.BG4.Name = "BG4";
            this.BG4.ReportSource = this.Balance_GeneralN41;
            this.BG4.Size = new System.Drawing.Size(679, 411);
            this.BG4.TabIndex = 0;
            this.BG4.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorBG4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 411);
            this.Controls.Add(this.BG4);
            this.Name = "VisorBG4";
            this.Text = "VisorBG4";
            this.ResumeLayout(false);

        }

        #endregion
        private Balance_GeneralN4 Balance_GeneralN41;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer BG4;
    }
}