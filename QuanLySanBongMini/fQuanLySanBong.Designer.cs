namespace QuanLySanBongMini
{
    partial class FQuanLySanBong
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem1 = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            label2 = new Label();
            txbFieldType = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel3 = new Panel();
            btnResetStatus = new Button();
            buttonThanhToan = new Button();
            buttonHuysan = new Button();
            buttonDatsan = new Button();
            panel4 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem1, thôngTinTàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1012, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem1
            // 
            adminToolStripMenuItem1.Name = "adminToolStripMenuItem1";
            adminToolStripMenuItem1.Size = new Size(60, 20);
            adminToolStripMenuItem1.Text = "Quản lý";
            adminToolStripMenuItem1.Click += quảnLýToolStripMenuItem1_Click;
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(122, 20);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(170, 22);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(170, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txbFieldType);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(578, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(422, 71);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 24);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Loại sân";
            // 
            // txbFieldType
            // 
            txbFieldType.Location = new Point(276, 21);
            txbFieldType.Name = "txbFieldType";
            txbFieldType.Size = new Size(100, 23);
            txbFieldType.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Chọn sân bóng";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(80, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnResetStatus);
            panel3.Controls.Add(buttonThanhToan);
            panel3.Controls.Add(buttonHuysan);
            panel3.Controls.Add(buttonDatsan);
            panel3.Location = new Point(577, 507);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 55);
            panel3.TabIndex = 3;
            // 
            // btnResetStatus
            // 
            btnResetStatus.Location = new Point(328, 8);
            btnResetStatus.Name = "btnResetStatus";
            btnResetStatus.Size = new Size(80, 44);
            btnResetStatus.TabIndex = 3;
            btnResetStatus.Text = "Cập nhật";
            btnResetStatus.UseVisualStyleBackColor = true;
            btnResetStatus.Click += btnResetStatus_Click;
            // 
            // buttonThanhToan
            // 
            buttonThanhToan.Location = new Point(224, 8);
            buttonThanhToan.Name = "buttonThanhToan";
            buttonThanhToan.Size = new Size(81, 44);
            buttonThanhToan.TabIndex = 2;
            buttonThanhToan.Text = "Thanh Toán";
            buttonThanhToan.UseVisualStyleBackColor = true;
            buttonThanhToan.Click += buttonThanhToan_Click;
            // 
            // buttonHuysan
            // 
            buttonHuysan.Location = new Point(122, 8);
            buttonHuysan.Name = "buttonHuysan";
            buttonHuysan.Size = new Size(81, 44);
            buttonHuysan.TabIndex = 1;
            buttonHuysan.Text = "Hủy đặt";
            buttonHuysan.UseVisualStyleBackColor = true;
            buttonHuysan.Click += buttonHuysan_Click;
            // 
            // buttonDatsan
            // 
            buttonDatsan.Location = new Point(13, 8);
            buttonDatsan.Name = "buttonDatsan";
            buttonDatsan.Size = new Size(88, 44);
            buttonDatsan.TabIndex = 0;
            buttonDatsan.Text = "Đặt sân";
            buttonDatsan.UseVisualStyleBackColor = true;
            buttonDatsan.Click += buttonDatsan_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lsvBill);
            panel4.Location = new Point(578, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(425, 393);
            panel4.TabIndex = 4;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(419, 387);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            lsvBill.SelectedIndexChanged += lsvBill_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Sân";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Khung giờ";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Người Đặt ";
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày tạo";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Giá tiền";
            columnHeader5.Width = 80;
            // 
            // flpTable
            // 
            flpTable.AllowDrop = true;
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(559, 531);
            flpTable.TabIndex = 1;
            flpTable.TabStop = true;
            flpTable.Paint += flpTable_Paint;
            // 
            // FQuanLySanBong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 589);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FQuanLySanBong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý sân bóng";
            Load += FQuanLySanBong_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem1;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private ComboBox comboBox1;
        private Panel panel4;
        private Button buttonHuysan;
        private Button buttonDatsan;
        private FlowLayoutPanel flpTable;
        private ListView lsvBill;
        private Button buttonThanhToan;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button btnResetStatus;
        private Label label2;
        private TextBox txbFieldType;
    }
}