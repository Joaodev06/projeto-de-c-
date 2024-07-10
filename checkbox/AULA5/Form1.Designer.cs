namespace AULA5
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
            this.PIC1 = new System.Windows.Forms.PictureBox();
            this.IOS = new System.Windows.Forms.RadioButton();
            this.AND = new System.Windows.Forms.RadioButton();
            this.LIN = new System.Windows.Forms.RadioButton();
            this.WIND = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PIC1)).BeginInit();
            this.SuspendLayout();
            // 
            // PIC1
            // 
            this.PIC1.Location = new System.Drawing.Point(596, 134);
            this.PIC1.Name = "PIC1";
            this.PIC1.Size = new System.Drawing.Size(419, 195);
            this.PIC1.TabIndex = 0;
            this.PIC1.TabStop = false;
            this.PIC1.Click += new System.EventHandler(this.PIC1_Click);
            // 
            // IOS
            // 
            this.IOS.AutoSize = true;
            this.IOS.Location = new System.Drawing.Point(7, 183);
            this.IOS.Name = "IOS";
            this.IOS.Size = new System.Drawing.Size(62, 24);
            this.IOS.TabIndex = 1;
            this.IOS.TabStop = true;
            this.IOS.Text = "IOS";
            this.IOS.UseVisualStyleBackColor = true;
            this.IOS.CheckedChanged += new System.EventHandler(this.IOS_CheckedChanged);
            // 
            // AND
            // 
            this.AND.AutoSize = true;
            this.AND.Location = new System.Drawing.Point(162, 183);
            this.AND.Name = "AND";
            this.AND.Size = new System.Drawing.Size(109, 24);
            this.AND.TabIndex = 2;
            this.AND.TabStop = true;
            this.AND.Text = "ANDROID";
            this.AND.UseVisualStyleBackColor = true;
            // 
            // LIN
            // 
            this.LIN.AutoSize = true;
            this.LIN.Location = new System.Drawing.Point(7, 244);
            this.LIN.Name = "LIN";
            this.LIN.Size = new System.Drawing.Size(82, 24);
            this.LIN.TabIndex = 3;
            this.LIN.TabStop = true;
            this.LIN.Text = "LINUX";
            this.LIN.UseVisualStyleBackColor = true;
            // 
            // WIND
            // 
            this.WIND.AutoSize = true;
            this.WIND.Location = new System.Drawing.Point(162, 244);
            this.WIND.Name = "WIND";
            this.WIND.Size = new System.Drawing.Size(115, 24);
            this.WIND.TabIndex = 4;
            this.WIND.TabStop = true;
            this.WIND.Text = "WINDOWS";
            this.WIND.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BTN1
            // 
            this.BTN1.Location = new System.Drawing.Point(7, 302);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(141, 42);
            this.BTN1.TabIndex = 10;
            this.BTN1.Text = "VERIFICAR";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(616, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "ESCOLHA UM SISTEMA OPERACIONAL";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WIND);
            this.Controls.Add(this.LIN);
            this.Controls.Add(this.AND);
            this.Controls.Add(this.IOS);
            this.Controls.Add(this.PIC1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PIC1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PIC1;
        private System.Windows.Forms.RadioButton IOS;
        private System.Windows.Forms.RadioButton AND;
        private System.Windows.Forms.RadioButton LIN;
        private System.Windows.Forms.RadioButton WIND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

