
namespace WAMagno.UI
{
    partial class Razones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGuardarRazon = new System.Windows.Forms.Button();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridRazones = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRazones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonGuardarRazon);
            this.panel1.Controls.Add(this.txtRazon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 450);
            this.panel1.TabIndex = 1;
            // 
            // buttonGuardarRazon
            // 
            this.buttonGuardarRazon.Location = new System.Drawing.Point(12, 128);
            this.buttonGuardarRazon.Name = "buttonGuardarRazon";
            this.buttonGuardarRazon.Size = new System.Drawing.Size(174, 33);
            this.buttonGuardarRazon.TabIndex = 2;
            this.buttonGuardarRazon.Text = "Insertar Razon";
            this.buttonGuardarRazon.UseVisualStyleBackColor = true;
            this.buttonGuardarRazon.Click += new System.EventHandler(this.buttonGuardarRazon_Click);
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(6, 79);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(197, 20);
            this.txtRazon.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insertar nueva Razon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razon";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridRazones);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 450);
            this.panel2.TabIndex = 2;
            // 
            // gridRazones
            // 
            this.gridRazones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRazones.Location = new System.Drawing.Point(0, 0);
            this.gridRazones.MainView = this.gridView1;
            this.gridRazones.Name = "gridRazones";
            this.gridRazones.Size = new System.Drawing.Size(591, 450);
            this.gridRazones.TabIndex = 0;
            this.gridRazones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridRazones;
            this.gridView1.Name = "gridView1";
            // 
            // Razones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Razones";
            this.Text = "Historico Razones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRazones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardarRazon;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridRazones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}