namespace UrunSatis
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            ıconButton2 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(116, 19);
            label1.TabIndex = 0;
            label1.Text = "Toplam Ücret:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(135, 43);
            label2.Name = "label2";
            label2.Size = new Size(39, 18);
            label2.TabIndex = 1;
            label2.Text = "0 TL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 101);
            label3.Name = "label3";
            label3.Size = new Size(100, 19);
            label3.TabIndex = 2;
            label3.Text = "Verilen Para";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(22, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.White;
            label4.Location = new Point(237, 62);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 4;
            label4.Text = "Para Üstü";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(248, 102);
            label5.Name = "label5";
            label5.Size = new Size(63, 30);
            label5.TabIndex = 5;
            label5.Text = "0 TL";
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = Color.Indigo;
            ıconButton1.Cursor = Cursors.Hand;
            ıconButton1.FlatAppearance.BorderSize = 0;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ıconButton1.ForeColor = Color.White;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.Location = new Point(385, 72);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(105, 48);
            ıconButton1.TabIndex = 6;
            ıconButton1.Text = "Bitir";
            ıconButton1.UseVisualStyleBackColor = false;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // ıconButton2
            // 
            ıconButton2.Cursor = Cursors.Hand;
            ıconButton2.FlatAppearance.BorderSize = 0;
            ıconButton2.FlatStyle = FlatStyle.Flat;
            ıconButton2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ıconButton2.ForeColor = Color.White;
            ıconButton2.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            ıconButton2.IconColor = Color.White;
            ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton2.IconSize = 30;
            ıconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            ıconButton2.Location = new Point(64, 13);
            ıconButton2.Name = "ıconButton2";
            ıconButton2.Size = new Size(74, 27);
            ıconButton2.TabIndex = 7;
            ıconButton2.Text = "Yenile";
            ıconButton2.TextAlign = ContentAlignment.MiddleRight;
            ıconButton2.UseVisualStyleBackColor = true;
            ıconButton2.Click += ıconButton2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(511, 185);
            Controls.Add(ıconButton2);
            Controls.Add(ıconButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nakit Ödeme";
            Activated += Form2_Activated;
            Load += Form2_Load;
            Click += Form2_Click;
            Enter += Form2_Enter;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton ıconButton2;
    }
}