namespace Front.Formularios
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            txtDniCliente = new TextBox();
            txtApellidoCliente = new TextBox();
            txtNombreCliente = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVolverCliente = new Button();
            btnEliminarCliente = new Button();
            btnAgregarCliente = new Button();
            ListaClientes = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(161, 261);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(169, 23);
            txtDniCliente.TabIndex = 35;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(161, 204);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(169, 23);
            txtApellidoCliente.TabIndex = 34;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(161, 146);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(169, 23);
            txtNombreCliente.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DodgerBlue;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(25, 259);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 32;
            label4.Text = "DNI:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DodgerBlue;
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(25, 202);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 31;
            label3.Text = "APELLIDO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DodgerBlue;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(25, 144);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 30;
            label2.Text = "NOMBRE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DodgerBlue;
            label1.Font = new Font("Constantia", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(166, 39);
            label1.TabIndex = 29;
            label1.Text = "CLIENTES";
            // 
            // btnVolverCliente
            // 
            btnVolverCliente.BackColor = Color.DodgerBlue;
            btnVolverCliente.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverCliente.Location = new Point(325, 408);
            btnVolverCliente.Name = "btnVolverCliente";
            btnVolverCliente.Size = new Size(130, 51);
            btnVolverCliente.TabIndex = 28;
            btnVolverCliente.Text = "VOLVER";
            btnVolverCliente.UseVisualStyleBackColor = false;
            btnVolverCliente.Click += btnVolverCliente_Click;
            // 
            // btnEliminarCliente
            // 
            btnEliminarCliente.BackColor = Color.DodgerBlue;
            btnEliminarCliente.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarCliente.Location = new Point(175, 408);
            btnEliminarCliente.Name = "btnEliminarCliente";
            btnEliminarCliente.Size = new Size(130, 51);
            btnEliminarCliente.TabIndex = 27;
            btnEliminarCliente.Text = "ELIMINAR";
            btnEliminarCliente.UseVisualStyleBackColor = false;
            btnEliminarCliente.Click += btnEliminarCliente_Click;
            // 
            // btnAgregarCliente
            // 
            btnAgregarCliente.BackColor = Color.DodgerBlue;
            btnAgregarCliente.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCliente.Location = new Point(25, 408);
            btnAgregarCliente.Name = "btnAgregarCliente";
            btnAgregarCliente.Size = new Size(130, 51);
            btnAgregarCliente.TabIndex = 26;
            btnAgregarCliente.Text = "AGREGAR";
            btnAgregarCliente.UseVisualStyleBackColor = false;
            btnAgregarCliente.Click += btnAgregarCliente_Click;
            // 
            // ListaClientes
            // 
            ListaClientes.BackColor = Color.PowderBlue;
            ListaClientes.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListaClientes.FormattingEnabled = true;
            ListaClientes.ItemHeight = 19;
            ListaClientes.Location = new Point(587, 42);
            ListaClientes.Name = "ListaClientes";
            ListaClientes.Size = new Size(322, 403);
            ListaClientes.TabIndex = 25;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(919, 474);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(943, 498);
            Controls.Add(txtDniCliente);
            Controls.Add(txtApellidoCliente);
            Controls.Add(txtNombreCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVolverCliente);
            Controls.Add(btnEliminarCliente);
            Controls.Add(btnAgregarCliente);
            Controls.Add(ListaClientes);
            Controls.Add(pictureBox1);
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDniCliente;
        private TextBox txtApellidoCliente;
        private TextBox txtNombreCliente;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnVolverCliente;
        private Button btnEliminarCliente;
        private Button btnAgregarCliente;
        private ListBox ListaClientes;
        private PictureBox pictureBox1;
    }
}