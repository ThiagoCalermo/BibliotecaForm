namespace tpbibliotecaBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevo = new Button();
            btnListar = new Button();
            dgvLibros = new DataGridView();
            btnModificar = new Button();
            btnBorrar = new Button();
            txtbTitulo = new TextBox();
            txtbAutor = new TextBox();
            txtbGenero = new TextBox();
            txtbUbicacion = new TextBox();
            txtbCopiasDis = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtbEditorial = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.AutoSize = true;
            btnNuevo.Location = new Point(484, 11);
            btnNuevo.Margin = new Padding(4, 3, 4, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(249, 28);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Guardar nuevo libro";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnListar
            // 
            btnListar.AutoSize = true;
            btnListar.Location = new Point(504, 394);
            btnListar.Margin = new Padding(4, 3, 4, 3);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(188, 28);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar los libros";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.BackgroundColor = Color.Wheat;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(13, 428);
            dgvLibros.Margin = new Padding(4, 3, 4, 3);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.RowTemplate.Height = 29;
            dgvLibros.Size = new Size(1070, 193);
            dgvLibros.TabIndex = 2;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = true;
            btnModificar.Location = new Point(13, 394);
            btnModificar.Margin = new Padding(4, 3, 4, 3);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(177, 28);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar libro";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.AutoSize = true;
            btnBorrar.Location = new Point(939, 394);
            btnBorrar.Margin = new Padding(4, 3, 4, 3);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(144, 28);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar libro";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtbTitulo
            // 
            txtbTitulo.Location = new Point(393, 60);
            txtbTitulo.Margin = new Padding(4, 3, 4, 3);
            txtbTitulo.Name = "txtbTitulo";
            txtbTitulo.Size = new Size(186, 26);
            txtbTitulo.TabIndex = 5;
            // 
            // txtbAutor
            // 
            txtbAutor.Location = new Point(771, 60);
            txtbAutor.Margin = new Padding(4, 3, 4, 3);
            txtbAutor.Name = "txtbAutor";
            txtbAutor.Size = new Size(186, 26);
            txtbAutor.TabIndex = 6;
            // 
            // txtbGenero
            // 
            txtbGenero.Location = new Point(506, 195);
            txtbGenero.Margin = new Padding(4, 3, 4, 3);
            txtbGenero.Name = "txtbGenero";
            txtbGenero.Size = new Size(186, 26);
            txtbGenero.TabIndex = 7;
            // 
            // txtbUbicacion
            // 
            txtbUbicacion.Location = new Point(504, 262);
            txtbUbicacion.Margin = new Padding(4, 3, 4, 3);
            txtbUbicacion.Name = "txtbUbicacion";
            txtbUbicacion.Size = new Size(186, 26);
            txtbUbicacion.TabIndex = 8;
            // 
            // txtbCopiasDis
            // 
            txtbCopiasDis.Location = new Point(506, 333);
            txtbCopiasDis.Margin = new Padding(4, 3, 4, 3);
            txtbCopiasDis.Name = "txtbCopiasDis";
            txtbCopiasDis.Size = new Size(186, 26);
            txtbCopiasDis.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 18);
            label1.TabIndex = 10;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(623, 60);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 18);
            label2.TabIndex = 11;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 195);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 12;
            label3.Text = "Genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(281, 262);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 18);
            label4.TabIndex = 13;
            label4.Text = "Ubicación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 333);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(175, 18);
            label5.TabIndex = 14;
            label5.Text = "Copias disponibles";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 126);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 18);
            label6.TabIndex = 15;
            label6.Text = "Editorial";
            // 
            // txtbEditorial
            // 
            txtbEditorial.Location = new Point(506, 126);
            txtbEditorial.Margin = new Padding(4, 3, 4, 3);
            txtbEditorial.Name = "txtbEditorial";
            txtbEditorial.Size = new Size(186, 26);
            txtbEditorial.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1096, 629);
            Controls.Add(txtbEditorial);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtbCopiasDis);
            Controls.Add(txtbUbicacion);
            Controls.Add(txtbGenero);
            Controls.Add(txtbAutor);
            Controls.Add(txtbTitulo);
            Controls.Add(btnBorrar);
            Controls.Add(btnModificar);
            Controls.Add(dgvLibros);
            Controls.Add(btnListar);
            Controls.Add(btnNuevo);
            Font = new Font("Castellar", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnListar;
        private DataGridView dgvLibros;
        private Button btnModificar;
        private Button btnBorrar;
        private TextBox txtbTitulo;
        private TextBox txtbAutor;
        private TextBox txtbGenero;
        private TextBox txtbUbicacion;
        private TextBox txtbCopiasDis;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtbEditorial;
    }
}