namespace OrgActualesdeArchivos
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtApellido = new TextBox();
            txtSalario = new TextBox();
            btnAgregar = new Button();
            btnCargar = new Button();
            btnGuardar = new Button();
            listBoxEmpleados = new ListBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(82, 17);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(144, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 20);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(550, 25);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "Salario";
            label3.Click += label3_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(327, 17);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(144, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(598, 17);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(144, 23);
            txtSalario.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(642, 69);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(146, 72);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(642, 179);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(146, 72);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(642, 294);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(146, 72);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // listBoxEmpleados
            // 
            listBoxEmpleados.FormattingEnabled = true;
            listBoxEmpleados.ItemHeight = 15;
            listBoxEmpleados.Location = new Point(25, 69);
            listBoxEmpleados.Name = "listBoxEmpleados";
            listBoxEmpleados.Size = new Size(585, 364);
            listBoxEmpleados.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxEmpleados);
            Controls.Add(btnGuardar);
            Controls.Add(btnCargar);
            Controls.Add(btnAgregar);
            Controls.Add(txtSalario);
            Controls.Add(txtApellido);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtApellido;
        private TextBox txtSalario;
        private Button btnAgregar;
        private Button btnCargar;
        private Button btnGuardar;
        private ListBox listBoxEmpleados;
    }
}
