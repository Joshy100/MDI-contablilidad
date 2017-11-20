namespace CapaPresentación
{
    partial class VisorBG5
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
            this.BG5 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.BalanceGeneralN51 = new CapaPresentación.BalanceGeneralN5();
            this.SuspendLayout();
            // 
            // BG5
            // 
            this.BG5.ActiveViewIndex = 0;
            this.BG5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BG5.Cursor = System.Windows.Forms.Cursors.Default;
            this.BG5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BG5.Location = new System.Drawing.Point(0, 0);
            this.BG5.Name = "BG5";
            this.BG5.ReportSource = this.BalanceGeneralN51;
            this.BG5.Size = new System.Drawing.Size(688, 476);
            this.BG5.TabIndex = 0;
            this.BG5.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // VisorBG5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 476);
            this.Controls.Add(this.BG5);
            this.Name = "VisorBG5";
            this.Text = "VisorBG5";
            this.Load += new System.EventHandler(this.VisorBG5_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private BalanceGeneralN5 BalanceGeneralN51;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer BG5;
    }
}