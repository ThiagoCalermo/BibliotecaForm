namespace tpbibliotecaBD
{
    partial class frmwModificar
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
            btnCancelar = new Button();
            btnGuardarNuevo = new Button();
            txtbUbicacionNueva = new TextBox();
            txtbCopiasNuevas = new TextBox();
            txtbEditorialNueva = new TextBox();
            txtbIdModificar = new TextBox();
            txtbGeneroNuevo = new TextBox();
            txtbAutorNuevo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label7 = new Label();
            txtbTituloNuevo = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Location = new Point(499, 459);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 28);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.AutoSize = true;
            btnGuardarNuevo.Location = new Point(477, 355);
            btnGuardarNuevo.Margin = new Padding(4, 3, 4, 3);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(185, 28);
            btnGuardarNuevo.TabIndex = 1;
            btnGuardarNuevo.Text = "Guardar cambios";
            btnGuardarNuevo.UseVisualStyleBackColor = true;
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // txtbUbicacionNueva
            // 
            txtbUbicacionNueva.Location = new Point(55, 357);
            txtbUbicacionNueva.Margin = new Padding(4, 3, 4, 3);
            txtbUbicacionNueva.Name = "txtbUbicacionNueva";
            txtbUbicacionNueva.Size = new Size(256, 26);
            txtbUbicacionNueva.TabIndex = 2;
            // 
            // txtbCopiasNuevas
            // 
            txtbCopiasNuevas.Location = new Point(55, 461);
            txtbCopiasNuevas.Margin = new Padding(4, 3, 4, 3);
            txtbCopiasNuevas.Name = "txtbCopiasNuevas";
            txtbCopiasNuevas.Size = new Size(256, 26);
            txtbCopiasNuevas.TabIndex = 3;
            // 
            // txtbEditorialNueva
            // 
            txtbEditorialNueva.Location = new Point(55, 155);
            txtbEditorialNueva.Margin = new Padding(4, 3, 4, 3);
            txtbEditorialNueva.Name = "txtbEditorialNueva";
            txtbEditorialNueva.Size = new Size(256, 26);
            txtbEditorialNueva.TabIndex = 4;
            // 
            // txtbIdModificar
            // 
            txtbIdModificar.Location = new Point(430, 155);
            txtbIdModificar.Margin = new Padding(4, 3, 4, 3);
            txtbIdModificar.Name = "txtbIdModificar";
            txtbIdModificar.Size = new Size(280, 26);
            txtbIdModificar.TabIndex = 5;
            // 
            // txtbGeneroNuevo
            // 
            txtbGeneroNuevo.Location = new Point(55, 246);
            txtbGeneroNuevo.Margin = new Padding(4, 3, 4, 3);
            txtbGeneroNuevo.Name = "txtbGeneroNuevo";
            txtbGeneroNuevo.Size = new Size(256, 26);
            txtbGeneroNuevo.TabIndex = 7;
            // 
            // txtbAutorNuevo
            // 
            txtbAutorNuevo.Location = new Point(55, 65);
            txtbAutorNuevo.Margin = new Padding(4, 3, 4, 3);
            txtbAutorNuevo.Name = "txtbAutorNuevo";
            txtbAutorNuevo.Size = new Size(256, 26);
            txtbAutorNuevo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(323, 18);
            label2.TabIndex = 10;
            label2.Text = "Id del libro que desea modificar ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 18);
            label3.TabIndex = 11;
            label3.Text = "Editorial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(134, 204);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 18);
            label4.TabIndex = 12;
            label4.Text = "Genero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 301);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(263, 18);
            label5.TabIndex = 13;
            label5.Text = "Ubicación en la biblioteca";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 411);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(300, 18);
            label6.TabIndex = 14;
            label6.Text = "Cantidad de copias disponibles";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 15;
            label1.Text = "Autor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(490, 204);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(162, 18);
            label7.TabIndex = 16;
            label7.Text = "Título del libro";
            // 
            // txtbTituloNuevo
            // 
            txtbTituloNuevo.Location = new Point(430, 246);
            txtbTituloNuevo.Margin = new Padding(4, 3, 4, 3);
            txtbTituloNuevo.Name = "txtbTituloNuevo";
            txtbTituloNuevo.Size = new Size(280, 26);
            txtbTituloNuevo.TabIndex = 17;
            // 
            // frmwModificar
            // 
            AutoScaleDimensions = new SizeF(12F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(774, 526);
            Controls.Add(txtbTituloNuevo);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtbAutorNuevo);
            Controls.Add(txtbGeneroNuevo);
            Controls.Add(txtbIdModificar);
            Controls.Add(txtbEditorialNueva);
            Controls.Add(txtbCopiasNuevas);
            Controls.Add(txtbUbicacionNueva);
            Controls.Add(btnGuardarNuevo);
            Controls.Add(btnCancelar);
            Font = new Font("Castellar", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmwModificar";
            Text = "frmwModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnGuardarNuevo;
        private TextBox txtbUbicacionNueva;
        private TextBox txtbCopiasNuevas;
        private TextBox txtbEditorialNueva;
        private TextBox txtbIdModificar;
        private TextBox txtbGeneroNuevo;
        private TextBox txtbAutorNuevo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label7;
        private TextBox txtbTituloNuevo;
    }
}