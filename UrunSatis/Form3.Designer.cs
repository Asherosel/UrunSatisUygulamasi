namespace UrunSatis
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            textLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(89, 163);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Personel Numaranız";
            textBox1.Click += textBox1_Click;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(50, 71);
            label1.Name = "label1";
            label1.Size = new Size(315, 41);
            label1.TabIndex = 1;
            label1.Text = "Ürün Satış Sistemi";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(89, 217);
            textBox2.MaxLength = 15;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(221, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "Şifreniz";
            textBox2.UseSystemPasswordChar = true;
            textBox2.Click += textBox2_Click;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = Color.Indigo;
            ıconButton1.Cursor = Cursors.Hand;
            ıconButton1.FlatAppearance.BorderSize = 0;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 35;
            ıconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton1.Location = new Point(136, 304);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(122, 51);
            ıconButton1.TabIndex = 4;
            ıconButton1.Text = "Giriş Yap";
            ıconButton1.TextAlign = ContentAlignment.MiddleRight;
            ıconButton1.UseVisualStyleBackColor = false;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textLabel.ForeColor = Color.Red;
            textLabel.Location = new Point(83, 387);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(0, 30);
            textLabel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(12, 387);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 6;
            label2.Text = "Hata:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(89, 145);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 7;
            label3.Text = "Personel Numarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(89, 199);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 8;
            label4.Text = "Parola";
            label4.Click += label4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(412, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textLabel);
            Controls.Add(ıconButton1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Satış Sistemine Giriş";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private Label textLabel;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}