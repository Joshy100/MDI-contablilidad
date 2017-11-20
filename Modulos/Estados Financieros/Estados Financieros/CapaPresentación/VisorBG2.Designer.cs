namespace CapaPresentación
{
    partial class VisorBG2
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
            this.BG2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Balance_GeneralN21 = new CapaPresentación.Balance_GeneralN2();
            this.SuspendLayout();
            // 
            // BG2
            // 
            this.BG2.ActiveViewIndex = 0;
            this.BG2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BG2.Cursor = System.Windows.Forms.Cursors.Default;
            this.BG2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG2.Location = new System.Drawing.Point(0, 0);
            this.BG2.Name = "BG2";
            this.BG2.ReportSource = this.Balance_GeneralN21;
            this.BG2.Size = new System.Drawing.Size(659, 480);
            this.BG2.TabIndex = 0;
            this.BG2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorBG2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 480);
            this.Controls.Add(this.BG2);
            this.Name = "VisorBG2";
            this.Text = "VisorBG2";
            this.Load += new System.EventHandler(this.VisorBG2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Balance_GeneralN2 Balance_GeneralN21;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer BG2;
    }
}