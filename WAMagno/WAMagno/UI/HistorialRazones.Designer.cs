
namespace WAMagno.UI
{
    partial class HistorialRazones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialRazones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBuscarHist = new System.Windows.Forms.Button();
            this.txtCodigoBodega = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.lblRef = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaInicial = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridHistRazones = new DevExpress.XtraGrid.GridControl();
            this.gridViewRazones = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Inicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdRazon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigoBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistRazones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRazones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonBuscarHist);
            this.panel1.Controls.Add(this.txtCodigoBodega);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtReferencia);
            this.panel1.Controls.Add(this.lblRef);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fechaFinal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fechaInicial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 450);
            this.panel1.TabIndex = 1;
            // 
            // buttonBuscarHist
            // 
            this.buttonBuscarHist.Location = new System.Drawing.Point(12, 318);
            this.buttonBuscarHist.Name = "buttonBuscarHist";
            this.buttonBuscarHist.Size = new System.Drawing.Size(174, 33);
            this.buttonBuscarHist.TabIndex = 2;
            this.buttonBuscarHist.Text = "Buscar";
            this.buttonBuscarHist.UseVisualStyleBackColor = true;
            // 
            // txtCodigoBodega
            // 
            this.txtCodigoBodega.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoBodega.Location = new System.Drawing.Point(6, 259);
            this.txtCodigoBodega.Name = "txtCodigoBodega";
            this.txtCodigoBodega.Size = new System.Drawing.Size(197, 20);
            this.txtCodigoBodega.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(3, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código Bodega";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(6, 197);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(197, 20);
            this.txtReferencia.TabIndex = 6;
            // 
            // lblRef
            // 
            this.lblRef.AutoSize = true;
            this.lblRef.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRef.Location = new System.Drawing.Point(3, 172);
            this.lblRef.Name = "lblRef";
            this.lblRef.Size = new System.Drawing.Size(59, 13);
            this.lblRef.TabIndex = 5;
            this.lblRef.Text = "Referencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Final";
            // 
            // fechaFinal
            // 
            this.fechaFinal.Location = new System.Drawing.Point(6, 134);
            this.fechaFinal.Name = "fechaFinal";
            this.fechaFinal.Size = new System.Drawing.Size(200, 20);
            this.fechaFinal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterios de Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha Inicial";
            // 
            // fechaInicial
            // 
            this.fechaInicial.Location = new System.Drawing.Point(6, 71);
            this.fechaInicial.Name = "fechaInicial";
            this.fechaInicial.Size = new System.Drawing.Size(200, 20);
            this.fechaInicial.TabIndex = 0;
            this.fechaInicial.Value = new System.DateTime(2021, 3, 31, 16, 37, 56, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridHistRazones);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 450);
            this.panel2.TabIndex = 2;
            // 
            // gridHistRazones
            // 
            this.gridHistRazones.DataMember = "GetHistRazones";
            this.gridHistRazones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHistRazones.Location = new System.Drawing.Point(0, 0);
            this.gridHistRazones.MainView = this.gridViewRazones;
            this.gridHistRazones.Name = "gridHistRazones";
            this.gridHistRazones.Size = new System.Drawing.Size(591, 450);
            this.gridHistRazones.TabIndex = 3;
            this.gridHistRazones.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRazones});
            // 
            // gridViewRazones
            // 
            this.gridViewRazones.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDia,
            this.colReferencia,
            this.colDescripcion,
            this.colStock_Inicial,
            this.colStock,
            this.colADU,
            this.colTransito,
            this.colIdRazon,
            this.colCodigoBodega});
            this.gridViewRazones.GridControl = this.gridHistRazones;
            this.gridViewRazones.Name = "gridViewRazones";
            // 
            // colDia
            // 
            this.colDia.FieldName = "Dia";
            this.colDia.Name = "colDia";
            this.colDia.Visible = true;
            this.colDia.VisibleIndex = 0;
            // 
            // colReferencia
            // 
            this.colReferencia.FieldName = "Referencia";
            this.colReferencia.Name = "colReferencia";
            this.colReferencia.Visible = true;
            this.colReferencia.VisibleIndex = 1;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // colStock_Inicial
            // 
            this.colStock_Inicial.FieldName = "Stock_Inicial";
            this.colStock_Inicial.Name = "colStock_Inicial";
            this.colStock_Inicial.Visible = true;
            this.colStock_Inicial.VisibleIndex = 3;
            // 
            // colStock
            // 
            this.colStock.FieldName = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.Visible = true;
            this.colStock.VisibleIndex = 4;
            // 
            // colADU
            // 
            this.colADU.FieldName = "ADU";
            this.colADU.Name = "colADU";
            this.colADU.Visible = true;
            this.colADU.VisibleIndex = 5;
            // 
            // colTransito
            // 
            this.colTransito.FieldName = "Transito";
            this.colTransito.Name = "colTransito";
            this.colTransito.Visible = true;
            this.colTransito.VisibleIndex = 6;
            // 
            // colIdRazon
            // 
            this.colIdRazon.FieldName = "IdRazon";
            this.colIdRazon.Name = "colIdRazon";
            this.colIdRazon.Visible = true;
            this.colIdRazon.VisibleIndex = 7;
            // 
            // colCodigoBodega
            // 
            this.colCodigoBodega.FieldName = "CodigoBodega";
            this.colCodigoBodega.Name = "colCodigoBodega";
            this.colCodigoBodega.Visible = true;
            this.colCodigoBodega.VisibleIndex = 8;
            // 
            // HistorialRazones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "HistorialRazones";
            this.Text = "Historico Razones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistRazones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRazones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCodigoBodega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaInicial;
        private System.Windows.Forms.Button buttonBuscarHist;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gridHistRazones;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewRazones;
        private DevExpress.XtraGrid.Columns.GridColumn colDia;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Inicial;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colADU;
        private DevExpress.XtraGrid.Columns.GridColumn colTransito;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRazon;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBodega;
    }
}