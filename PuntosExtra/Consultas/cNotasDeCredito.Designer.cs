namespace PuntosExtra.Consultas
{
    partial class cNotasDeCredito
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
            this.buscarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.NotasDeCreditodataGridView = new System.Windows.Forms.DataGridView();
            this.imprimirbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NotasDeCreditodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarbutton
            // 
            this.buscarbutton.Image = global::PuntosExtra.Properties.Resources.preview_search_find_locate_1551;
            this.buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buscarbutton.Location = new System.Drawing.Point(395, 7);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(72, 40);
            this.buscarbutton.TabIndex = 45;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Metodo de busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = " Filtro";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(107, 26);
            this.CriteriotextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(283, 20);
            this.CriteriotextBox.TabIndex = 42;
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Items.AddRange(new object[] {
            "Nota ID",
            "Monto Asignatura"});
            this.FiltrarcomboBox.Location = new System.Drawing.Point(11, 26);
            this.FiltrarcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(92, 21);
            this.FiltrarcomboBox.TabIndex = 41;
            // 
            // NotasDeCreditodataGridView
            // 
            this.NotasDeCreditodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotasDeCreditodataGridView.Location = new System.Drawing.Point(11, 50);
            this.NotasDeCreditodataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.NotasDeCreditodataGridView.Name = "NotasDeCreditodataGridView";
            this.NotasDeCreditodataGridView.RowTemplate.Height = 24;
            this.NotasDeCreditodataGridView.Size = new System.Drawing.Size(456, 298);
            this.NotasDeCreditodataGridView.TabIndex = 40;
            // 
            // imprimirbutton
            // 
            this.imprimirbutton.Image = global::PuntosExtra.Properties.Resources.impresora;
            this.imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.imprimirbutton.Location = new System.Drawing.Point(196, 353);
            this.imprimirbutton.Name = "imprimirbutton";
            this.imprimirbutton.Size = new System.Drawing.Size(72, 56);
            this.imprimirbutton.TabIndex = 46;
            this.imprimirbutton.Text = "Imprimir";
            this.imprimirbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.imprimirbutton.UseVisualStyleBackColor = true;
            this.imprimirbutton.Click += new System.EventHandler(this.imprimirbutton_Click);
            // 
            // cNotasDeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 414);
            this.Controls.Add(this.imprimirbutton);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.NotasDeCreditodataGridView);
            this.Name = "cNotasDeCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Notas De Credito";
            this.Load += new System.EventHandler(this.cNotasDeCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotasDeCreditodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.DataGridView NotasDeCreditodataGridView;
        private System.Windows.Forms.Button imprimirbutton;
    }
}