namespace Front.Formularios
{
    partial class FormTarjetadeCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarjetadeCredito));
            txtPagarTarjeta = new TextBox();
            label6 = new Label();
            txtLimiteTarjeta = new TextBox();
            label5 = new Label();
            btnResumenTarjeta = new Button();
            btnVolverTarjetaCredito = new Button();
            label4 = new Label();
            CBEstadoTarjeta = new ComboBox();
            btnEmitirTarjeta = new Button();
            txtSaldoTarjeta = new TextBox();
            label3 = new Label();
            CBClienteTitularTarjeta = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dataGridViewTarjeta = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarjeta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPagarTarjeta
            // 
            txtPagarTarjeta.Location = new Point(128, 357);
            txtPagarTarjeta.Name = "txtPagarTarjeta";
            txtPagarTarjeta.Size = new Size(174, 23);
            txtPagarTarjeta.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Violet;
            label6.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(22, 355);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 44;
            label6.Text = "PAGAR:";
            // 
            // txtLimiteTarjeta
            // 
            txtLimiteTarjeta.Location = new Point(253, 161);
            txtLimiteTarjeta.Name = "txtLimiteTarjeta";
            txtLimiteTarjeta.Size = new Size(174, 23);
            txtLimiteTarjeta.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Violet;
            label5.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(22, 159);
            label5.Name = "label5";
            label5.Size = new Size(211, 25);
            label5.TabIndex = 42;
            label5.Text = "LIMITE DE CREDITO:";
            // 
            // btnResumenTarjeta
            // 
            btnResumenTarjeta.BackColor = Color.Violet;
            btnResumenTarjeta.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnResumenTarjeta.Location = new Point(22, 420);
            btnResumenTarjeta.Name = "btnResumenTarjeta";
            btnResumenTarjeta.Size = new Size(244, 51);
            btnResumenTarjeta.TabIndex = 41;
            btnResumenTarjeta.Text = "RESUMEN DE TARJETA";
            btnResumenTarjeta.UseVisualStyleBackColor = false;
            // 
            // btnVolverTarjetaCredito
            // 
            btnVolverTarjetaCredito.BackColor = Color.Violet;
            btnVolverTarjetaCredito.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolverTarjetaCredito.Location = new Point(780, 420);
            btnVolverTarjetaCredito.Name = "btnVolverTarjetaCredito";
            btnVolverTarjetaCredito.Size = new Size(130, 51);
            btnVolverTarjetaCredito.TabIndex = 40;
            btnVolverTarjetaCredito.Text = "VOLVER";
            btnVolverTarjetaCredito.UseVisualStyleBackColor = false;
            btnVolverTarjetaCredito.Click += btnVolverTarjetaCredito_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Violet;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 297);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 39;
            label4.Text = "CAMBIAR ESTADO:";
            // 
            // CBEstadoTarjeta
            // 
            CBEstadoTarjeta.FormattingEnabled = true;
            CBEstadoTarjeta.Items.AddRange(new object[] { "Activa", "Pausada", "Bloqueada" });
            CBEstadoTarjeta.Location = new Point(245, 299);
            CBEstadoTarjeta.Name = "CBEstadoTarjeta";
            CBEstadoTarjeta.Size = new Size(178, 23);
            CBEstadoTarjeta.TabIndex = 38;
            // 
            // btnEmitirTarjeta
            // 
            btnEmitirTarjeta.BackColor = Color.Violet;
            btnEmitirTarjeta.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmitirTarjeta.Location = new Point(342, 198);
            btnEmitirTarjeta.Name = "btnEmitirTarjeta";
            btnEmitirTarjeta.Size = new Size(130, 51);
            btnEmitirTarjeta.TabIndex = 37;
            btnEmitirTarjeta.Text = "EMITIR";
            btnEmitirTarjeta.UseVisualStyleBackColor = false;
            // 
            // txtSaldoTarjeta
            // 
            txtSaldoTarjeta.Location = new Point(128, 213);
            txtSaldoTarjeta.Name = "txtSaldoTarjeta";
            txtSaldoTarjeta.Size = new Size(174, 23);
            txtSaldoTarjeta.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Violet;
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 211);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 35;
            label3.Text = "SALDO:";
            // 
            // CBClienteTitularTarjeta
            // 
            CBClienteTitularTarjeta.FormattingEnabled = true;
            CBClienteTitularTarjeta.Location = new Point(253, 106);
            CBClienteTitularTarjeta.Name = "CBClienteTitularTarjeta";
            CBClienteTitularTarjeta.Size = new Size(170, 23);
            CBClienteTitularTarjeta.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Violet;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 104);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 33;
            label2.Text = "CLIENTE/TITULAR:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Violet;
            label1.Font = new Font("Constantia", 24F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(351, 39);
            label1.TabIndex = 32;
            label1.Text = "TARJETA DE CREDITO";
            // 
            // dataGridViewTarjeta
            // 
            dataGridViewTarjeta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarjeta.Location = new Point(548, 31);
            dataGridViewTarjeta.Name = "dataGridViewTarjeta";
            dataGridViewTarjeta.RowTemplate.Height = 25;
            dataGridViewTarjeta.Size = new Size(363, 380);
            dataGridViewTarjeta.TabIndex = 31;
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
            // FormTarjetadeCredito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(943, 498);
            Controls.Add(txtPagarTarjeta);
            Controls.Add(label6);
            Controls.Add(txtLimiteTarjeta);
            Controls.Add(label5);
            Controls.Add(btnResumenTarjeta);
            Controls.Add(btnVolverTarjetaCredito);
            Controls.Add(label4);
            Controls.Add(CBEstadoTarjeta);
            Controls.Add(btnEmitirTarjeta);
            Controls.Add(txtSaldoTarjeta);
            Controls.Add(label3);
            Controls.Add(CBClienteTitularTarjeta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewTarjeta);
            Controls.Add(pictureBox1);
            Name = "FormTarjetadeCredito";
            Text = "FormTarjetadeCredito";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarjeta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPagarTarjeta;
        private Label label6;
        private TextBox txtLimiteTarjeta;
        private Label label5;
        private Button btnResumenTarjeta;
        private Button btnVolverTarjetaCredito;
        private Label label4;
        private ComboBox CBEstadoTarjeta;
        private Button btnEmitirTarjeta;
        private TextBox txtSaldoTarjeta;
        private Label label3;
        private ComboBox CBClienteTitularTarjeta;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewTarjeta;
        private PictureBox pictureBox1;
    }
}