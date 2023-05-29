namespace EstacionamentoDesafio
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtPlaca = new TextBox();
            btnEntrada = new Button();
            btnSaida = new Button();
            Entrada = new ListBox();
            Saída = new ListBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(412, 77);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(160, 23);
            txtPlaca.TabIndex = 0;
            txtPlaca.TextChanged += txtPlaca_TextChanged;
            // 
            // btnEntrada
            // 
            btnEntrada.AccessibleName = "";
            btnEntrada.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrada.Location = new Point(143, 143);
            btnEntrada.Name = "btnEntrada";
            btnEntrada.Size = new Size(75, 23);
            btnEntrada.TabIndex = 1;
            btnEntrada.Text = "Cadastrar";
            btnEntrada.UseVisualStyleBackColor = true;
            btnEntrada.Click += btnEntrada_Click;
            // 
            // btnSaida
            // 
            btnSaida.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaida.Location = new Point(575, 143);
            btnSaida.Name = "btnSaida";
            btnSaida.Size = new Size(75, 23);
            btnSaida.TabIndex = 2;
            btnSaida.Text = "Finalizar";
            btnSaida.UseVisualStyleBackColor = true;
            btnSaida.Click += btnSaida_Click;
            // 
            // Entrada
            // 
            Entrada.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Entrada.FormattingEnabled = true;
            Entrada.ItemHeight = 20;
            Entrada.Location = new Point(42, 172);
            Entrada.Name = "Entrada";
            Entrada.Size = new Size(275, 224);
            Entrada.TabIndex = 3;
            // 
            // Saída
            // 
            Saída.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Saída.FormattingEnabled = true;
            Saída.ItemHeight = 20;
            Saída.Location = new Point(479, 172);
            Saída.Name = "Saída";
            Saída.Size = new Size(275, 224);
            Saída.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 9);
            label1.Name = "label1";
            label1.Size = new Size(455, 51);
            label1.TabIndex = 5;
            label1.Text = "Estacionamento Rotativo";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(236, 76);
            label2.Name = "label2";
            label2.Size = new Size(219, 24);
            label2.TabIndex = 6;
            label2.Text = "Digite a placa do veículo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.parking_86279__1_;
            pictureBox1.Location = new Point(42, 9);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 103);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(788, 461);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Saída);
            Controls.Add(Entrada);
            Controls.Add(btnSaida);
            Controls.Add(btnEntrada);
            Controls.Add(txtPlaca);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Estacionamento Rotativo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.ListBox Entrada;
        private System.Windows.Forms.ListBox Saída;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}