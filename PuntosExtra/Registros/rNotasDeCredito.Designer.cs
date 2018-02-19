namespace PuntosExtra.Registros
{
    partial class rNotasDeCredito
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
            this.idnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.estudianteidnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pctnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.montoasignaturasnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.montotextBox = new System.Windows.Forms.TextBox();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.fechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValidarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buscarbutton = new System.Windows.Forms.Button();
            this.buscarEbutton = new System.Windows.Forms.Button();
            this.consultarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteidnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoasignaturasnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // idnumericUpDown
            // 
            this.idnumericUpDown.Location = new System.Drawing.Point(110, 19);
            this.idnumericUpDown.Name = "idnumericUpDown";
            this.idnumericUpDown.Size = new System.Drawing.Size(35, 20);
            this.idnumericUpDown.TabIndex = 84;
            // 
            // estudianteidnumericUpDown
            // 
            this.estudianteidnumericUpDown.Location = new System.Drawing.Point(109, 95);
            this.estudianteidnumericUpDown.Name = "estudianteidnumericUpDown";
            this.estudianteidnumericUpDown.Size = new System.Drawing.Size(36, 20);
            this.estudianteidnumericUpDown.TabIndex = 83;
            // 
            // pctnumericUpDown
            // 
            this.pctnumericUpDown.Location = new System.Drawing.Point(109, 157);
            this.pctnumericUpDown.Name = "pctnumericUpDown";
            this.pctnumericUpDown.Size = new System.Drawing.Size(271, 20);
            this.pctnumericUpDown.TabIndex = 82;
            this.pctnumericUpDown.ValueChanged += new System.EventHandler(this.pctnumericUpDown_ValueChanged);
            // 
            // montoasignaturasnumericUpDown
            // 
            this.montoasignaturasnumericUpDown.Location = new System.Drawing.Point(109, 126);
            this.montoasignaturasnumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.montoasignaturasnumericUpDown.Name = "montoasignaturasnumericUpDown";
            this.montoasignaturasnumericUpDown.Size = new System.Drawing.Size(271, 20);
            this.montoasignaturasnumericUpDown.TabIndex = 81;
            this.montoasignaturasnumericUpDown.ValueChanged += new System.EventHandler(this.montoasignaturasnumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Monto";
            // 
            // montotextBox
            // 
            this.montotextBox.Location = new System.Drawing.Point(110, 192);
            this.montotextBox.Name = "montotextBox";
            this.montotextBox.ReadOnly = true;
            this.montotextBox.Size = new System.Drawing.Size(272, 20);
            this.montotextBox.TabIndex = 79;
            // 
            // nombretextBox
            // 
            this.nombretextBox.Location = new System.Drawing.Point(232, 94);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(148, 20);
            this.nombretextBox.TabIndex = 78;
            // 
            // fechadateTimePicker
            // 
            this.fechadateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechadateTimePicker.Location = new System.Drawing.Point(109, 52);
            this.fechadateTimePicker.Name = "fechadateTimePicker";
            this.fechadateTimePicker.Size = new System.Drawing.Size(271, 20);
            this.fechadateTimePicker.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 73;
            this.label3.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Porciento de Beca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Monto Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "EstudianteID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "ID";
            // 
            // ValidarerrorProvider
            // 
            this.ValidarerrorProvider.ContainerControl = this;
            // 
            // buscarbutton
            // 
            this.buscarbutton.Image = global::PuntosExtra.Properties.Resources.preview_search_find_locate_1551;
            this.buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buscarbutton.Location = new System.Drawing.Point(151, 12);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(73, 34);
            this.buscarbutton.TabIndex = 90;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // buscarEbutton
            // 
            this.buscarEbutton.Image = global::PuntosExtra.Properties.Resources.preview_search_find_locate_1551;
            this.buscarEbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buscarEbutton.Location = new System.Drawing.Point(151, 86);
            this.buscarEbutton.Name = "buscarEbutton";
            this.buscarEbutton.Size = new System.Drawing.Size(73, 34);
            this.buscarEbutton.TabIndex = 89;
            this.buscarEbutton.Text = "Buscar";
            this.buscarEbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buscarEbutton.UseVisualStyleBackColor = true;
            this.buscarEbutton.Click += new System.EventHandler(this.buscarEbutton_Click);
            // 
            // consultarbutton
            // 
            this.consultarbutton.Image = global::PuntosExtra.Properties.Resources.impresora;
            this.consultarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.consultarbutton.Location = new System.Drawing.Point(294, 228);
            this.consultarbutton.Name = "consultarbutton";
            this.consultarbutton.Size = new System.Drawing.Size(62, 59);
            this.consultarbutton.TabIndex = 88;
            this.consultarbutton.Text = "Consultar";
            this.consultarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.consultarbutton.UseVisualStyleBackColor = true;
            this.consultarbutton.Click += new System.EventHandler(this.consultarbutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Image = global::PuntosExtra.Properties.Resources.delete_remove_page_document_16678;
            this.eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eliminarbutton.Location = new System.Drawing.Point(214, 228);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(62, 59);
            this.eliminarbutton.TabIndex = 87;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // nuevobutton
            // 
            this.nuevobutton.Image = global::PuntosExtra.Properties.Resources.New_File_36861;
            this.nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevobutton.Location = new System.Drawing.Point(44, 228);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(68, 59);
            this.nuevobutton.TabIndex = 86;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Image = global::PuntosExtra.Properties.Resources.Save_as_37111;
            this.guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarbutton.Location = new System.Drawing.Point(134, 228);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(63, 59);
            this.guardarbutton.TabIndex = 85;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // rNotasDeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 299);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.buscarEbutton);
            this.Controls.Add(this.consultarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.idnumericUpDown);
            this.Controls.Add(this.estudianteidnumericUpDown);
            this.Controls.Add(this.pctnumericUpDown);
            this.Controls.Add(this.montoasignaturasnumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.montotextBox);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.fechadateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rNotasDeCredito";
            this.Text = "Registro de Notas De Credito";
            this.Load += new System.EventHandler(this.rNotasDeCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudianteidnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.montoasignaturasnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown idnumericUpDown;
        private System.Windows.Forms.NumericUpDown estudianteidnumericUpDown;
        private System.Windows.Forms.NumericUpDown pctnumericUpDown;
        private System.Windows.Forms.NumericUpDown montoasignaturasnumericUpDown;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox montotextBox;
        private System.Windows.Forms.TextBox nombretextBox;
        private System.Windows.Forms.DateTimePicker fechadateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button consultarbutton;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.Button buscarEbutton;
        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.ErrorProvider ValidarerrorProvider;
    }
}