namespace QuanLySanBongMini
{
    partial class fAccount
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
            panel2 = new Panel();
            textBoxUserName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            textBoxDisplayName = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            textBoxPassWord = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            textBoxNewPass = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            textBoxReEnter = new TextBox();
            label5 = new Label();
            buttonUpdate = new Button();
            buttonExit = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 63);
            panel2.TabIndex = 1;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(150, 20);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.ReadOnly = true;
            textBoxUserName.Size = new Size(303, 23);
            textBoxUserName.TabIndex = 1;
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
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxDisplayName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 63);
            panel1.TabIndex = 2;
            // 
            // textBoxDisplayName
            // 
            textBoxDisplayName.Location = new Point(150, 20);
            textBoxDisplayName.Name = "textBoxDisplayName";
            textBoxDisplayName.Size = new Size(303, 23);
            textBoxDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 20);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị: ";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxPassWord);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 63);
            panel3.TabIndex = 3;
            // 
            // textBoxPassWord
            // 
            textBoxPassWord.Location = new Point(150, 20);
            textBoxPassWord.Name = "textBoxPassWord";
            textBoxPassWord.Size = new Size(303, 23);
            textBoxPassWord.TabIndex = 1;
            textBoxPassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 20);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu: ";
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxNewPass);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 249);
            panel4.Name = "panel4";
            panel4.Size = new Size(459, 63);
            panel4.TabIndex = 4;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.Location = new Point(150, 20);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.Size = new Size(303, 23);
            textBoxNewPass.TabIndex = 1;
            textBoxNewPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 20);
            label4.Name = "label4";
            label4.Size = new Size(121, 19);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu mới: ";
            // 
            // panel5
            // 
            panel5.Controls.Add(textBoxReEnter);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(12, 318);
            panel5.Name = "panel5";
            panel5.Size = new Size(459, 63);
            panel5.TabIndex = 5;
            // 
            // textBoxReEnter
            // 
            textBoxReEnter.Location = new Point(150, 20);
            textBoxReEnter.Name = "textBoxReEnter";
            textBoxReEnter.Size = new Size(303, 23);
            textBoxReEnter.TabIndex = 1;
            textBoxReEnter.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 20);
            label5.Name = "label5";
            label5.Size = new Size(81, 19);
            label5.TabIndex = 0;
            label5.Text = "Nhập lại: ";
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(226, 409);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "Cập nhật";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(353, 409);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // fAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonUpdate);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fAccount";
            Text = "fAccount";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox textBoxUserName;
        private Label label1;
        private Panel panel1;
        private TextBox textBoxDisplayName;
        private Label label2;
        private Panel panel3;
        private TextBox textBoxPassWord;
        private Label label3;
        private Panel panel4;
        private TextBox textBoxNewPass;
        private Label label4;
        private Panel panel5;
        private TextBox textBoxReEnter;
        private Label label5;
        private Button buttonUpdate;
        private Button buttonExit;
    }
}