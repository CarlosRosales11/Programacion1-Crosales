namespace Front.Formularios
{
    partial class FormRealizarTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRealizarTransferencia));
            CBRealizarTransferenciaA = new ComboBox();
            CBRealizarTransferenciaDe = new ComboBox();
            label4 = new Label();
            btnTransferir = new Button();
            btnVolverTransferencia = new Button();
            txtMontoTransferencia = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CBRealizarTransferenciaA
            // 
            CBRealizarTransferenciaA.FormattingEnabled = true;
            CBRealizarTransferenciaA.Location = new Point(364, 191);
            CBRealizarTransferenciaA.Name = "CBRealizarTransferenciaA";
            CBRealizarTransferenciaA.Size = new Size(190, 23);
            CBRealizarTransferenciaA.TabIndex = 39;
            // 
            // CBRealizarTransferenciaDe
            // 
            CBRealizarTransferenciaDe.FormattingEnabled = true;
            CBRealizarTransferenciaDe.Location = new Point(364, 121);
            CBRealizarTransferenciaDe.Name = "CBRealizarTransferenciaDe";
            CBRealizarTransferenciaDe.Size = new Size(190, 23);
            CBRealizarTransferenciaDe.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DodgerBlue;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 119);
            label4.Name = "label4";
            label4.Size = new Size(317, 25);
            label4.TabIndex = 37;
            label4.Text = "REALIZAR TRANSFERENCIA DE:";
            // 
            // btnTransferir
            // 
            btnTransferir.BackColor = Color.DodgerBlue;
            btnTransferir.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransferir.Location = new Point(198, 383);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(153, 51);
            btnTransferir.TabIndex = 36;
            btnTransferir.Text = "TRANSFERIR";
            btnTransferir.UseVisualStyleBackColor = false;
            btnTransferir.Click += btnTransferir_Click;
            // 
            // btnVolverTransferencia
            // 
            btnVolverTransferencia.BackColor = Color.DodgerBlue;
            btnVolverTransferencia.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverTransferencia.Location = new Point(24, 383);
            btnVolverTransferencia.Name = "btnVolverTransferencia";
            btnVolverTransferencia.Size = new Size(130, 51);
            btnVolverTransferencia.TabIndex = 35;
            btnVolverTransferencia.Text = "VOLVER";
            btnVolverTransferencia.UseVisualStyleBackColor = false;
            btnVolverTransferencia.Click += btnVolverTransferencia_Click;
            // 
            // txtMontoTransferencia
            // 
            txtMontoTransferencia.Location = new Point(139, 266);
            txtMontoTransferencia.Name = "txtMontoTransferencia";
            txtMontoTransferencia.Size = new Size(212, 23);
            txtMontoTransferencia.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DodgerBlue;
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 264);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 33;
            label3.Text = "MONTO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DodgerBlue;
            label1.Font = new Font("Constantia", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(275, 39);
            label1.TabIndex = 32;
            label1.Text = "TRANSFERENCIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DodgerBlue;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 189);
            label2.Name = "label2";
            label2.Size = new Size(304, 25);
            label2.TabIndex = 31;
            label2.Text = "REALIZAR TRANSFERENCIA A:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(919, 474);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // FormRealizarTransferencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(943, 498);
            Controls.Add(CBRealizarTransferenciaA);
            Controls.Add(CBRealizarTransferenciaDe);
            Controls.Add(label4);
            Controls.Add(btnTransferir);
            Controls.Add(btnVolverTransferencia);
            Controls.Add(txtMontoTransferencia);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Name = "FormRealizarTransferencia";
            Text = "FormRealizarTransferencia";
            Load += FormRealizarTransferencia_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CBRealizarTransferenciaA;
        private ComboBox CBRealizarTransferenciaDe;
        private Label label4;
        private Button btnTransferir;
        private Button btnVolverTransferencia;
        private TextBox txtMontoTransferencia;
        private Label label3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}