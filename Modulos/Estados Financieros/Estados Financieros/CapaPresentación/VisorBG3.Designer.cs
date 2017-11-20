namespace CapaPresentación
{
    partial class VisorBG3
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
            this.BG3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Balance_GeneralN31 = new CapaPresentación.Balance_GeneralN3();
            this.SuspendLayout();
            // 
            // BG3
            // 
            this.BG3.ActiveViewIndex = 0;
            this.BG3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BG3.Cursor = System.Windows.Forms.Cursors.Default;
            this.BG3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG3.Location = new System.Drawing.Point(0, 0);
            this.BG3.Name = "BG3";
            this.BG3.ReportSource = this.Balance_GeneralN31;
            this.BG3.Size = new System.Drawing.Size(719, 446);
            this.BG3.TabIndex = 0;
            this.BG3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.BG3.Load += new System.EventHandler(this.BG3_Load);
            // 
            // VisorBG3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 446);
            this.Controls.Add(this.BG3);
            this.Name = "VisorBG3";
            this.Text = "VisorBG3";
            this.Load += new System.EventHandler(this.VisorBG3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer BG3;
        private Balance_GeneralN3 Balance_GeneralN31;
    }
}