
namespace WAMagno.UI
{
    partial class PronosticoStock
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRazon = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
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
            this.gridPronostico = new DevExpress.XtraGrid.GridControl();
            this.histRazonesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPronostico = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock_Inicial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.listRazones = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colCodigoBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPronostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histRazonesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPronostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRazones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.buttonRazon);
            this.panel1.Controls.Add(this.buttonBuscar);
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 450);
            this.panel1.TabIndex = 0;
            // 
            // buttonRazon
            // 
            this.buttonRazon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRazon.Location = new System.Drawing.Point(10, 380);
            this.buttonRazon.Name = "buttonRazon";
            this.buttonRazon.Size = new System.Drawing.Size(191, 27);
            this.buttonRazon.TabIndex = 10;
            this.buttonRazon.Text = "Razones";
            this.buttonRazon.UseVisualStyleBackColor = true;
            this.buttonRazon.Click += new System.EventHandler(this.buttonRazon_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(128, 299);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 9;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
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
            this.panel2.Controls.Add(this.gridPronostico);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 450);
            this.panel2.TabIndex = 1;
            // 
            // gridPronostico
            // 
            this.gridPronostico.DataSource = this.histRazonesDataSetBindingSource;
            this.gridPronostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPronostico.Location = new System.Drawing.Point(0, 0);
            this.gridPronostico.MainView = this.gridViewPronostico;
            this.gridPronostico.Name = "gridPronostico";
            this.gridPronostico.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.listRazones});
            this.gridPronostico.Size = new System.Drawing.Size(591, 450);
            this.gridPronostico.TabIndex = 0;
            this.gridPronostico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPronostico});
            // 
            // gridViewPronostico
            // 
            this.gridViewPronostico.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDia,
            this.colReferencia,
            this.colDescripcion,
            this.colStock_Inicial,
            this.colStock,
            this.colADU,
            this.colTransito,
            this.colRazon,
            this.colCodigoBodega});
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "Format0";
            gridFormatRule2.Rule = null;
            this.gridViewPronostico.FormatRules.Add(gridFormatRule2);
            this.gridViewPronostico.GridControl = this.gridPronostico;
            this.gridViewPronostico.Name = "gridViewPronostico";
            this.gridViewPronostico.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewPronostico_RowCellStyle);
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
            // colRazon
            // 
            this.colRazon.ColumnEdit = this.listRazones;
            this.colRazon.FieldName = "Razon";
            this.colRazon.Name = "colRazon";
            this.colRazon.Visible = true;
            this.colRazon.VisibleIndex = 7;
            // 
            // listRazones
            // 
            this.listRazones.AutoHeight = false;
            this.listRazones.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.listRazones.Name = "listRazones";
            // 
            // colCodigoBodega
            // 
            this.colCodigoBodega.FieldName = "CodigoBodega";
            this.colCodigoBodega.Name = "colCodigoBodega";
            this.colCodigoBodega.Visible = true;
            this.colCodigoBodega.VisibleIndex = 8;
            // 
            // PronosticoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PronosticoStock";
            this.Text = "Pronostico Stock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPronostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histRazonesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPronostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listRazones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaInicial;
        private System.Windows.Forms.Label lblRef;
        private System.Windows.Forms.TextBox txtCodigoBodega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Button buttonBuscar;
        private DevExpress.XtraGrid.GridControl gridPronostico;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPronostico;
        private System.Windows.Forms.Button buttonRazon;
        private System.Windows.Forms.BindingSource histRazonesDataSetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDia;
        private DevExpress.XtraGrid.Columns.GridColumn colReferencia;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colStock_Inicial;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colADU;
        private DevExpress.XtraGrid.Columns.GridColumn colTransito;
        private DevExpress.XtraGrid.Columns.GridColumn colRazon;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox listRazones;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBodega;
    }
}