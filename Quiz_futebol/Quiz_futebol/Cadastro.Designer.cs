namespace Quiz_futebol
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.USU = new System.Windows.Forms.TextBox();
            this.SENHA = new System.Windows.Forms.TextBox();
            this.CONSENHA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUÁRIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "SENHA";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News706 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "CONFIRMAR SENHA";
            // 
            // USU
            // 
            this.USU.Location = new System.Drawing.Point(250, 122);
            this.USU.Multiline = true;
            this.USU.Name = "USU";
            this.USU.Size = new System.Drawing.Size(341, 26);
            this.USU.TabIndex = 4;
            // 
            // SENHA
            // 
            this.SENHA.Location = new System.Drawing.Point(250, 188);
            this.SENHA.Multiline = true;
            this.SENHA.Name = "SENHA";
            this.SENHA.PasswordChar = '*';
            this.SENHA.Size = new System.Drawing.Size(341, 26);
            this.SENHA.TabIndex = 5;
            // 
            // CONSENHA
            // 
            this.CONSENHA.Location = new System.Drawing.Point(250, 267);
            this.CONSENHA.Name = "CONSENHA";
            this.CONSENHA.PasswordChar = '*';
            this.CONSENHA.Size = new System.Drawing.Size(341, 26);
            this.CONSENHA.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(233, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Quiz_futebol.Properties.Resources.PE;
            this.pictureBox1.Location = new System.Drawing.Point(746, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CONSENHA);
            this.Controls.Add(this.SENHA);
            this.Controls.Add(this.USU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox USU;
        private System.Windows.Forms.TextBox SENHA;
        private System.Windows.Forms.TextBox CONSENHA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}