namespace QuanLySanBongMini
{
    partial class FLogin
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
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            buttonExit = new Button();
            buttonLogin = new Button();
            panel3 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 63);
            panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(134, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập: ";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonExit);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 209);
            panel1.TabIndex = 0;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(362, 158);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(92, 29);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += button2_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(229, 158);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(95, 29);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Đăng nhập";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(18, 81);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 63);
            panel3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(150, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 23);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 20);
            label2.Name = "label2";
            label2.Size = new Size(88, 19);
            label2.TabIndex = 0;
            label2.Text = "Mật khẩu: ";
            // 
            // FLogin
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonExit;
            ClientSize = new Size(518, 233);
            Controls.Add(panel1);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += FLogin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private TextBox textBox2;
        private Label label2;
        private Button buttonExit;
        private Button buttonLogin;
    }
}