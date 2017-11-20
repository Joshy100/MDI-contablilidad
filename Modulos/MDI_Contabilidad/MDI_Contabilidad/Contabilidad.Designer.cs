namespace MDI_Contabilidad
{
    partial class Contabilidad
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.polizasLocalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosFinancierosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreContableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enlaceOtrosModulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionPolizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPolizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polizasLocalesToolStripMenuItem,
            this.estadosFinancierosToolStripMenuItem,
            this.cierreContableToolStripMenuItem,
            this.enlaceOtrosModulosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // polizasLocalesToolStripMenuItem
            // 
            this.polizasLocalesToolStripMenuItem.Name = "polizasLocalesToolStripMenuItem";
            this.polizasLocalesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.polizasLocalesToolStripMenuItem.Text = "Polizas Locales";
            this.polizasLocalesToolStripMenuItem.Click += new System.EventHandler(this.polizasLocalesToolStripMenuItem_Click);
            // 
            // estadosFinancierosToolStripMenuItem
            // 
            this.estadosFinancierosToolStripMenuItem.Name = "estadosFinancierosToolStripMenuItem";
            this.estadosFinancierosToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.estadosFinancierosToolStripMenuItem.Text = "Estados Financieros";
            this.estadosFinancierosToolStripMenuItem.Click += new System.EventHandler(this.estadosFinancierosToolStripMenuItem_Click);
            // 
            // cierreContableToolStripMenuItem
            // 
            this.cierreContableToolStripMenuItem.Name = "cierreContableToolStripMenuItem";
            this.cierreContableToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.cierreContableToolStripMenuItem.Text = "Cierre Contable";
            this.cierreContableToolStripMenuItem.Click += new System.EventHandler(this.cierreContableToolStripMenuItem_Click);
            // 
            // enlaceOtrosModulosToolStripMenuItem
            // 
            this.enlaceOtrosModulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPolizasToolStripMenuItem,
            this.polizaToolStripMenuItem,
            this.opcionPolizaToolStripMenuItem});
            this.enlaceOtrosModulosToolStripMenuItem.Name = "enlaceOtrosModulosToolStripMenuItem";
            this.enlaceOtrosModulosToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.enlaceOtrosModulosToolStripMenuItem.Text = "Enlace Otros Modulos";
            this.enlaceOtrosModulosToolStripMenuItem.Click += new System.EventHandler(this.enlaceOtrosModulosToolStripMenuItem_Click);
            // 
            // polizaToolStripMenuItem
            // 
            this.polizaToolStripMenuItem.Name = "polizaToolStripMenuItem";
            this.polizaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.polizaToolStripMenuItem.Text = "Polizas En Batch";
            this.polizaToolStripMenuItem.Click += new System.EventHandler(this.polizaToolStripMenuItem_Click);
            // 
            // opcionPolizaToolStripMenuItem
            // 
            this.opcionPolizaToolStripMenuItem.Name = "opcionPolizaToolStripMenuItem";
            this.opcionPolizaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.opcionPolizaToolStripMenuItem.Text = "Opcion Poliza";
            this.opcionPolizaToolStripMenuItem.Click += new System.EventHandler(this.opcionPolizaToolStripMenuItem_Click);
            // 
            // verPolizasToolStripMenuItem
            // 
            this.verPolizasToolStripMenuItem.Name = "verPolizasToolStripMenuItem";
            this.verPolizasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.verPolizasToolStripMenuItem.Text = "Ver Polizas";
            this.verPolizasToolStripMenuItem.Click += new System.EventHandler(this.verPolizasToolStripMenuItem_Click);
            // 
            // Contabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 512);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Contabilidad";
            this.Text = "Contabilidad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem polizasLocalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadosFinancierosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreContableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enlaceOtrosModulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionPolizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPolizasToolStripMenuItem;
    }
}