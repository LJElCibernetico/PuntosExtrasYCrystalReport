namespace PuntosExtra.Registros
{
    partial class rEstudiantes
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
            this.observacionestextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nombrestextBox = new System.Windows.Forms.TextBox();
            this.estudiantesIDtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.fechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.validarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.consultarbutton = new System.Windows.Forms.Button();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.validarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // observacionestextBox
            // 
            this.observacionestextBox.Location = new System.Drawing.Point(91, 100);
            this.observacionestextBox.Multiline = true;
            this.observacionestextBox.Name = "observacionestextBox";
            this.observacionestextBox.Size = new System.Drawing.Size(255, 69);
            this.observacionestextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Observaciones";
            // 
            // nombrestextBox
            // 
            this.nombrestextBox.Location = new System.Drawing.Point(90, 45);
            this.nombrestextBox.Name = "nombrestextBox";
            this.nombrestextBox.Size = new System.Drawing.Size(256, 20);
            this.nombrestextBox.TabIndex = 15;
            // 
            // estudiantesIDtextBox
            // 
            this.estudiantesIDtextBox.Location = new System.Drawing.Point(91, 19);
            this.estudiantesIDtextBox.Name = "estudiantesIDtextBox";
            this.estudiantesIDtextBox.Size = new System.Drawing.Size(25, 20);
            this.estudiantesIDtextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estudiante ID";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(7, 47);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(49, 13);
            this.Nombre.TabIndex = 12;
            this.Nombre.Text = "Nombres";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(7, 76);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 45;
            this.Fechalabel.Text = "Fecha";
            // 
            // fechadateTimePicker
            // 
            this.fechadateTimePicker.Location = new System.Drawing.Point(91, 74);
            this.fechadateTimePicker.Name = "fechadateTimePicker";
            this.fechadateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.fechadateTimePicker.TabIndex = 44;
            // 
            // validarerrorProvider
            // 
            this.validarerrorProvider.ContainerControl = this;
            // 
            // consultarbutton
            // 
            this.consultarbutton.Image = global::PuntosExtra.Properties.Resources.impresora;
            this.consultarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.consultarbutton.Location = new System.Drawing.Point(268, 186);
            this.consultarbutton.Name = "consultarbutton";
            this.consultarbutton.Size = new System.Drawing.Size(62, 59);
            this.consultarbutton.TabIndex = 24;
            this.consultarbutton.Text = "Consultar";
            this.consultarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.consultarbutton.UseVisualStyleBackColor = true;
            this.consultarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscarbutton
            // 
            this.buscarbutton.Image = global::PuntosExtra.Properties.Resources.preview_search_find_locate_1551;
            this.buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buscarbutton.Location = new System.Drawing.Point(124, 5);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(73, 34);
            this.buscarbutton.TabIndex = 23;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Image = global::PuntosExtra.Properties.Resources.delete_remove_page_document_16678;
            this.eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eliminarbutton.Location = new System.Drawing.Point(188, 186);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(62, 59);
            this.eliminarbutton.TabIndex = 22;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // nuevobutton
            // 
            this.nuevobutton.Image = global::PuntosExtra.Properties.Resources.New_File_36861;
            this.nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevobutton.Location = new System.Drawing.Point(18, 186);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(68, 59);
            this.nuevobutton.TabIndex = 21;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Image = global::PuntosExtra.Properties.Resources.Save_as_37111;
            this.guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarbutton.Location = new System.Drawing.Point(108, 186);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(63, 59);
            this.guardarbutton.TabIndex = 20;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // rEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 257);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.fechadateTimePicker);
            this.Controls.Add(this.consultarbutton);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.observacionestextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombrestextBox);
            this.Controls.Add(this.estudiantesIDtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Name = "rEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Estudiantes";
            this.Load += new System.EventHandler(this.rEstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.validarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.TextBox observacionestextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombrestextBox;
        private System.Windows.Forms.TextBox estudiantesIDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button consultarbutton;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.DateTimePicker fechadateTimePicker;
        private System.Windows.Forms.ErrorProvider validarerrorProvider;
    }
}