namespace QuanLySanBongMini
{
    partial class fAdmin
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
            components = new System.ComponentModel.Container();
            tcAdmin = new TabControl();
            tabAccount = new TabPage();
            panel4 = new Panel();
            panel3 = new Panel();
            txbIdAccount = new TextBox();
            label9 = new Label();
            panel7 = new Panel();
            nmAccountType = new NumericUpDown();
            label3 = new Label();
            panel6 = new Panel();
            textBoxDisplayName = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            textBoxUserName = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            buttonInfoAccount = new Button();
            buttonAdjustAccount = new Button();
            buttonDelete = new Button();
            buttonAddAccount = new Button();
            panel1 = new Panel();
            dataAccount = new DataGridView();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            displayNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idAccountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountBindingSource = new BindingSource(components);
            tabField = new TabPage();
            panel11 = new Panel();
            panel22 = new Panel();
            txtBoxFieldStatus = new TextBox();
            label12 = new Label();
            panel15 = new Panel();
            nmFieldPrice = new NumericUpDown();
            label7 = new Label();
            panel12 = new Panel();
            txbFieldType = new TextBox();
            label4 = new Label();
            panel13 = new Panel();
            txbFieldName = new TextBox();
            label5 = new Label();
            panel14 = new Panel();
            txbFieldID = new TextBox();
            label6 = new Label();
            dtgvField = new DataGridView();
            panel10 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            tabTime = new TabPage();
            dtgvTime = new DataGridView();
            panel17 = new Panel();
            panel18 = new Panel();
            txbTimeStatus = new TextBox();
            label8 = new Label();
            panel19 = new Panel();
            cbField = new ComboBox();
            cbFieldid = new Label();
            panel20 = new Panel();
            txbTimeName = new TextBox();
            label10 = new Label();
            panel21 = new Panel();
            txbIDtime = new TextBox();
            label11 = new Label();
            panel16 = new Panel();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            tabBill = new TabPage();
            panel9 = new Panel();
            buttonViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            panel8 = new Panel();
            dtgvBill = new DataGridView();
            tableBindingSource1 = new BindingSource(components);
            tableBindingSource = new BindingSource(components);
            fieldBindingSource = new BindingSource(components);
            fieldRegisterBindingSource = new BindingSource(components);
            tcAdmin.SuspendLayout();
            tabAccount.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountType).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).BeginInit();
            tabField.SuspendLayout();
            panel11.SuspendLayout();
            panel22.SuspendLayout();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFieldPrice).BeginInit();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvField).BeginInit();
            panel10.SuspendLayout();
            tabTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTime).BeginInit();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel21.SuspendLayout();
            panel16.SuspendLayout();
            tabBill.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tableBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldRegisterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tabAccount);
            tcAdmin.Controls.Add(tabField);
            tcAdmin.Controls.Add(tabTime);
            tcAdmin.Controls.Add(tabBill);
            tcAdmin.Location = new Point(10, 13);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(790, 543);
            tcAdmin.TabIndex = 0;
            tcAdmin.SelectedIndexChanged += tcAdmin_SelectedIndexChanged;
            // 
            // tabAccount
            // 
            tabAccount.Controls.Add(panel4);
            tabAccount.Controls.Add(panel2);
            tabAccount.Controls.Add(panel1);
            tabAccount.Location = new Point(4, 24);
            tabAccount.Name = "tabAccount";
            tabAccount.Padding = new Padding(3);
            tabAccount.Size = new Size(782, 515);
            tabAccount.TabIndex = 0;
            tabAccount.Text = "Tài Khoản";
            tabAccount.UseVisualStyleBackColor = true;
            tabAccount.Click += tabPage1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(442, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(331, 417);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(txbIdAccount);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(3, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(325, 63);
            panel3.TabIndex = 2;
            // 
            // txbIdAccount
            // 
            txbIdAccount.Location = new Point(127, 20);
            txbIdAccount.Name = "txbIdAccount";
            txbIdAccount.ReadOnly = true;
            txbIdAccount.Size = new Size(195, 23);
            txbIdAccount.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(3, 24);
            label9.Name = "label9";
            label9.Size = new Size(114, 19);
            label9.TabIndex = 0;
            label9.Text = "ID Tài khoản: ";
            // 
            // panel7
            // 
            panel7.Controls.Add(nmAccountType);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(3, 213);
            panel7.Name = "panel7";
            panel7.Size = new Size(325, 63);
            panel7.TabIndex = 3;
            // 
            // nmAccountType
            // 
            nmAccountType.Location = new Point(153, 24);
            nmAccountType.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            nmAccountType.Name = "nmAccountType";
            nmAccountType.Size = new Size(59, 23);
            nmAccountType.TabIndex = 1;
            nmAccountType.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 24);
            label3.Name = "label3";
            label3.Size = new Size(122, 19);
            label3.TabIndex = 0;
            label3.Text = "Loại tài khoản:";
            // 
            // panel6
            // 
            panel6.Controls.Add(textBoxDisplayName);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(3, 144);
            panel6.Name = "panel6";
            panel6.Size = new Size(325, 63);
            panel6.TabIndex = 2;
            // 
            // textBoxDisplayName
            // 
            textBoxDisplayName.Location = new Point(127, 20);
            textBoxDisplayName.Name = "textBoxDisplayName";
            textBoxDisplayName.Size = new Size(195, 23);
            textBoxDisplayName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 24);
            label2.Name = "label2";
            label2.Size = new Size(108, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên hiển thị: ";
            // 
            // panel5
            // 
            panel5.Controls.Add(textBoxUserName);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(3, 75);
            panel5.Name = "panel5";
            panel5.Size = new Size(325, 63);
            panel5.TabIndex = 1;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(127, 20);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(195, 23);
            textBoxUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(122, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản: ";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonInfoAccount);
            panel2.Controls.Add(buttonAdjustAccount);
            panel2.Controls.Add(buttonDelete);
            panel2.Controls.Add(buttonAddAccount);
            panel2.Location = new Point(9, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(418, 73);
            panel2.TabIndex = 1;
            // 
            // buttonInfoAccount
            // 
            buttonInfoAccount.Location = new Point(320, 3);
            buttonInfoAccount.Name = "buttonInfoAccount";
            buttonInfoAccount.Size = new Size(81, 67);
            buttonInfoAccount.TabIndex = 3;
            buttonInfoAccount.Text = "Xem";
            buttonInfoAccount.UseVisualStyleBackColor = true;
            buttonInfoAccount.Click += buttonInfoAccount_Click;
            // 
            // buttonAdjustAccount
            // 
            buttonAdjustAccount.Location = new Point(220, 3);
            buttonAdjustAccount.Name = "buttonAdjustAccount";
            buttonAdjustAccount.Size = new Size(81, 67);
            buttonAdjustAccount.TabIndex = 2;
            buttonAdjustAccount.Text = "Sửa";
            buttonAdjustAccount.UseVisualStyleBackColor = true;
            buttonAdjustAccount.Click += buttonAdjustAccount_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(118, 3);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(81, 67);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAddAccount
            // 
            buttonAddAccount.Location = new Point(17, 3);
            buttonAddAccount.Name = "buttonAddAccount";
            buttonAddAccount.Size = new Size(81, 67);
            buttonAddAccount.TabIndex = 0;
            buttonAddAccount.Text = "Thêm";
            buttonAddAccount.UseVisualStyleBackColor = true;
            buttonAddAccount.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataAccount);
            panel1.Location = new Point(9, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 417);
            panel1.TabIndex = 0;
            // 
            // dataAccount
            // 
            dataAccount.AutoGenerateColumns = false;
            dataAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAccount.Columns.AddRange(new DataGridViewColumn[] { typeDataGridViewTextBoxColumn, displayNameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, idAccountDataGridViewTextBoxColumn });
            dataAccount.DataSource = accountBindingSource;
            dataAccount.Location = new Point(3, 0);
            dataAccount.Name = "dataAccount";
            dataAccount.RowTemplate.Height = 25;
            dataAccount.Size = new Size(415, 414);
            dataAccount.TabIndex = 0;
            dataAccount.CellContentClick += dataAccount_CellContentClick;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // displayNameDataGridViewTextBoxColumn
            // 
            displayNameDataGridViewTextBoxColumn.DataPropertyName = "DisplayName";
            displayNameDataGridViewTextBoxColumn.HeaderText = "DisplayName";
            displayNameDataGridViewTextBoxColumn.Name = "displayNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // idAccountDataGridViewTextBoxColumn
            // 
            idAccountDataGridViewTextBoxColumn.DataPropertyName = "IdAccount";
            idAccountDataGridViewTextBoxColumn.HeaderText = "IdAccount";
            idAccountDataGridViewTextBoxColumn.Name = "idAccountDataGridViewTextBoxColumn";
            // 
            // accountBindingSource
            // 
            accountBindingSource.DataSource = typeof(DTO.Account);
            // 
            // tabField
            // 
            tabField.Controls.Add(panel11);
            tabField.Controls.Add(dtgvField);
            tabField.Controls.Add(panel10);
            tabField.Location = new Point(4, 24);
            tabField.Name = "tabField";
            tabField.Padding = new Padding(3);
            tabField.Size = new Size(782, 515);
            tabField.TabIndex = 1;
            tabField.Text = "Sân";
            tabField.UseVisualStyleBackColor = true;
            tabField.Click += tabField_Click;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel22);
            panel11.Controls.Add(panel15);
            panel11.Controls.Add(panel12);
            panel11.Controls.Add(panel13);
            panel11.Controls.Add(panel14);
            panel11.Location = new Point(442, 92);
            panel11.Name = "panel11";
            panel11.Size = new Size(331, 417);
            panel11.TabIndex = 4;
            // 
            // panel22
            // 
            panel22.Controls.Add(txtBoxFieldStatus);
            panel22.Controls.Add(label12);
            panel22.Location = new Point(3, 220);
            panel22.Name = "panel22";
            panel22.Size = new Size(328, 63);
            panel22.TabIndex = 5;
            // 
            // txtBoxFieldStatus
            // 
            txtBoxFieldStatus.Location = new Point(127, 20);
            txtBoxFieldStatus.Name = "txtBoxFieldStatus";
            txtBoxFieldStatus.Size = new Size(195, 23);
            txtBoxFieldStatus.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 24);
            label12.Name = "label12";
            label12.Size = new Size(91, 19);
            label12.TabIndex = 0;
            label12.Text = "Trạng thái:";
            label12.Click += label12_Click_1;
            // 
            // panel15
            // 
            panel15.Controls.Add(nmFieldPrice);
            panel15.Controls.Add(label7);
            panel15.Location = new Point(3, 289);
            panel15.Name = "panel15";
            panel15.Size = new Size(325, 63);
            panel15.TabIndex = 4;
            // 
            // nmFieldPrice
            // 
            nmFieldPrice.Location = new Point(127, 24);
            nmFieldPrice.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            nmFieldPrice.Name = "nmFieldPrice";
            nmFieldPrice.Size = new Size(195, 23);
            nmFieldPrice.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 24);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 0;
            label7.Text = "Giá tiền:";
            // 
            // panel12
            // 
            panel12.Controls.Add(txbFieldType);
            panel12.Controls.Add(label4);
            panel12.Location = new Point(3, 151);
            panel12.Name = "panel12";
            panel12.Size = new Size(328, 63);
            panel12.TabIndex = 3;
            // 
            // txbFieldType
            // 
            txbFieldType.Location = new Point(127, 24);
            txbFieldType.Name = "txbFieldType";
            txbFieldType.Size = new Size(195, 23);
            txbFieldType.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 24);
            label4.Name = "label4";
            label4.Size = new Size(82, 19);
            label4.TabIndex = 0;
            label4.Text = "Loại Sân:";
            // 
            // panel13
            // 
            panel13.Controls.Add(txbFieldName);
            panel13.Controls.Add(label5);
            panel13.Location = new Point(3, 82);
            panel13.Name = "panel13";
            panel13.Size = new Size(325, 63);
            panel13.TabIndex = 2;
            // 
            // txbFieldName
            // 
            txbFieldName.Location = new Point(127, 20);
            txbFieldName.Name = "txbFieldName";
            txbFieldName.Size = new Size(195, 23);
            txbFieldName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 24);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 0;
            label5.Text = "Tên Sân: ";
            // 
            // panel14
            // 
            panel14.Controls.Add(txbFieldID);
            panel14.Controls.Add(label6);
            panel14.Location = new Point(3, 13);
            panel14.Name = "panel14";
            panel14.Size = new Size(325, 63);
            panel14.TabIndex = 1;
            // 
            // txbFieldID
            // 
            txbFieldID.Location = new Point(127, 20);
            txbFieldID.Name = "txbFieldID";
            txbFieldID.ReadOnly = true;
            txbFieldID.Size = new Size(195, 23);
            txbFieldID.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 24);
            label6.Name = "label6";
            label6.Size = new Size(69, 19);
            label6.TabIndex = 0;
            label6.Text = "ID Sân: ";
            // 
            // dtgvField
            // 
            dtgvField.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvField.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvField.Location = new Point(9, 95);
            dtgvField.Name = "dtgvField";
            dtgvField.RowTemplate.Height = 25;
            dtgvField.Size = new Size(415, 414);
            dtgvField.TabIndex = 3;
            dtgvField.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel10
            // 
            panel10.Controls.Add(button1);
            panel10.Controls.Add(button2);
            panel10.Controls.Add(button3);
            panel10.Controls.Add(button4);
            panel10.Location = new Point(6, 6);
            panel10.Name = "panel10";
            panel10.Size = new Size(418, 73);
            panel10.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(320, 3);
            button1.Name = "button1";
            button1.Size = new Size(81, 67);
            button1.TabIndex = 3;
            button1.Text = "Xem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(220, 3);
            button2.Name = "button2";
            button2.Size = new Size(81, 67);
            button2.TabIndex = 2;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(118, 3);
            button3.Name = "button3";
            button3.Size = new Size(81, 67);
            button3.TabIndex = 1;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(17, 3);
            button4.Name = "button4";
            button4.Size = new Size(81, 67);
            button4.TabIndex = 0;
            button4.Text = "Thêm";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabTime
            // 
            tabTime.Controls.Add(dtgvTime);
            tabTime.Controls.Add(panel17);
            tabTime.Controls.Add(panel16);
            tabTime.Location = new Point(4, 24);
            tabTime.Name = "tabTime";
            tabTime.Padding = new Padding(3);
            tabTime.Size = new Size(782, 515);
            tabTime.TabIndex = 2;
            tabTime.Text = "Khung giờ";
            tabTime.UseVisualStyleBackColor = true;
            // 
            // dtgvTime
            // 
            dtgvTime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTime.Location = new Point(6, 85);
            dtgvTime.Name = "dtgvTime";
            dtgvTime.RowTemplate.Height = 25;
            dtgvTime.Size = new Size(418, 424);
            dtgvTime.TabIndex = 6;
            // 
            // panel17
            // 
            panel17.Controls.Add(panel18);
            panel17.Controls.Add(panel19);
            panel17.Controls.Add(panel20);
            panel17.Controls.Add(panel21);
            panel17.Location = new Point(427, 98);
            panel17.Name = "panel17";
            panel17.Size = new Size(331, 417);
            panel17.TabIndex = 5;
            // 
            // panel18
            // 
            panel18.Controls.Add(txbTimeStatus);
            panel18.Controls.Add(label8);
            panel18.Location = new Point(3, 151);
            panel18.Name = "panel18";
            panel18.Size = new Size(325, 63);
            panel18.TabIndex = 4;
            // 
            // txbTimeStatus
            // 
            txbTimeStatus.Location = new Point(124, 20);
            txbTimeStatus.Name = "txbTimeStatus";
            txbTimeStatus.Size = new Size(198, 23);
            txbTimeStatus.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(3, 24);
            label8.Name = "label8";
            label8.Size = new Size(95, 19);
            label8.TabIndex = 0;
            label8.Text = "Trạng thái: ";
            // 
            // panel19
            // 
            panel19.Controls.Add(cbField);
            panel19.Controls.Add(cbFieldid);
            panel19.Location = new Point(0, 220);
            panel19.Name = "panel19";
            panel19.Size = new Size(328, 63);
            panel19.TabIndex = 3;
            // 
            // cbField
            // 
            cbField.FormattingEnabled = true;
            cbField.Location = new Point(127, 24);
            cbField.Name = "cbField";
            cbField.Size = new Size(195, 23);
            cbField.TabIndex = 1;
            // 
            // cbFieldid
            // 
            cbFieldid.AutoSize = true;
            cbFieldid.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbFieldid.Location = new Point(3, 24);
            cbFieldid.Name = "cbFieldid";
            cbFieldid.Size = new Size(65, 19);
            cbFieldid.TabIndex = 0;
            cbFieldid.Text = "ID Sân:";
            // 
            // panel20
            // 
            panel20.Controls.Add(txbTimeName);
            panel20.Controls.Add(label10);
            panel20.Location = new Point(3, 82);
            panel20.Name = "panel20";
            panel20.Size = new Size(325, 63);
            panel20.TabIndex = 2;
            // 
            // txbTimeName
            // 
            txbTimeName.Location = new Point(127, 20);
            txbTimeName.Name = "txbTimeName";
            txbTimeName.Size = new Size(195, 23);
            txbTimeName.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 24);
            label10.Name = "label10";
            label10.Size = new Size(102, 19);
            label10.TabIndex = 0;
            label10.Text = "Khung Giờ: ";
            // 
            // panel21
            // 
            panel21.Controls.Add(txbIDtime);
            panel21.Controls.Add(label11);
            panel21.Location = new Point(3, 13);
            panel21.Name = "panel21";
            panel21.Size = new Size(325, 63);
            panel21.TabIndex = 1;
            // 
            // txbIDtime
            // 
            txbIDtime.Location = new Point(127, 20);
            txbIDtime.Name = "txbIDtime";
            txbIDtime.ReadOnly = true;
            txbIDtime.Size = new Size(195, 23);
            txbIDtime.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 24);
            label11.Name = "label11";
            label11.Size = new Size(117, 19);
            label11.TabIndex = 0;
            label11.Text = "ID khung giờ: ";
            // 
            // panel16
            // 
            panel16.Controls.Add(button5);
            panel16.Controls.Add(button6);
            panel16.Controls.Add(button7);
            panel16.Controls.Add(button8);
            panel16.Location = new Point(6, 6);
            panel16.Name = "panel16";
            panel16.Size = new Size(418, 73);
            panel16.TabIndex = 3;
            // 
            // button5
            // 
            button5.Location = new Point(320, 3);
            button5.Name = "button5";
            button5.Size = new Size(81, 67);
            button5.TabIndex = 3;
            button5.Text = "Xem";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(220, 3);
            button6.Name = "button6";
            button6.Size = new Size(81, 67);
            button6.TabIndex = 2;
            button6.Text = "Sửa";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(118, 3);
            button7.Name = "button7";
            button7.Size = new Size(81, 67);
            button7.TabIndex = 1;
            button7.Text = "Xóa";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(17, 3);
            button8.Name = "button8";
            button8.Size = new Size(81, 67);
            button8.TabIndex = 0;
            button8.Text = "Thêm";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // tabBill
            // 
            tabBill.Controls.Add(panel9);
            tabBill.Controls.Add(panel8);
            tabBill.Location = new Point(4, 24);
            tabBill.Name = "tabBill";
            tabBill.Padding = new Padding(3);
            tabBill.Size = new Size(782, 515);
            tabBill.TabIndex = 3;
            tabBill.Text = "Doanh thu";
            tabBill.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(buttonViewBill);
            panel9.Controls.Add(dtpkToDate);
            panel9.Controls.Add(dtpkFromDate);
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(773, 29);
            panel9.TabIndex = 1;
            panel9.Paint += panel9_Paint;
            // 
            // buttonViewBill
            // 
            buttonViewBill.Location = new Point(312, 5);
            buttonViewBill.Name = "buttonViewBill";
            buttonViewBill.Size = new Size(75, 23);
            buttonViewBill.TabIndex = 2;
            buttonViewBill.Text = "Thống kê";
            buttonViewBill.UseVisualStyleBackColor = true;
            buttonViewBill.Click += buttonViewBill_Click_1;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(570, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(200, 23);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(4, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(200, 23);
            dtpkFromDate.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(dtgvBill);
            panel8.Location = new Point(3, 37);
            panel8.Name = "panel8";
            panel8.Size = new Size(773, 472);
            panel8.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(4, 1);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowTemplate.Height = 25;
            dtgvBill.Size = new Size(766, 465);
            dtgvBill.TabIndex = 0;
            dtgvBill.CellContentClick += dtgvBill_CellContentClick_1;
            // 
            // tableBindingSource1
            // 
            tableBindingSource1.DataSource = typeof(DTO.Table);
            // 
            // tableBindingSource
            // 
            tableBindingSource.DataSource = typeof(DTO.Table);
            // 
            // fieldBindingSource
            // 
            fieldBindingSource.DataSource = typeof(DTO.Field);
            // 
            // fieldRegisterBindingSource
            // 
            fieldRegisterBindingSource.DataSource = typeof(DTO.FieldRegister);
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 568);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            Text = "Admin";
            tcAdmin.ResumeLayout(false);
            tabAccount.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountType).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountBindingSource).EndInit();
            tabField.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel22.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFieldPrice).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvField).EndInit();
            panel10.ResumeLayout(false);
            tabTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTime).EndInit();
            panel17.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel16.ResumeLayout(false);
            tabBill.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tableBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldRegisterBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tabAccount;
        private TabPage tabField;
        private TabPage tabTime;
        private TabPage tabBill;
        private Panel panel4;
        private Panel panel2;
        private Button buttonAddAccount;
        private Panel panel1;
        private DataGridView dataAccount;
        private Button buttonInfoAccount;
        private Button buttonAdjustAccount;
        private Button buttonDelete;
        private Panel panel5;
        private TextBox textBoxUserName;
        private Label label1;
        private Panel panel6;
        private TextBox textBoxDisplayName;
        private Label label2;
        private Panel panel7;
        private Label label3;
        private Panel panel9;
        private Panel panel8;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private DataGridView dtgvBill;
        private Button buttonViewBill;
        private Panel panel11;
        private Panel panel12;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panel13;
        private TextBox txbFieldName;
        private Label label5;
        private Panel panel14;
        private TextBox txbFieldID;
        private Label label6;
        private DataGridView dtgvField;
        private Panel panel10;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel15;
        private NumericUpDown nmFieldPrice;
        private Label label7;
        private BindingSource fieldBindingSource;
        private Panel panel17;
        private Panel panel19;
        private ComboBox cbField;
        private Label cbFieldid;
        private Panel panel20;
        private TextBox txbTimeName;
        private Label label10;
        private Panel panel21;
        private TextBox txbIDtime;
        private Label label11;
        private Panel panel16;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panel22;
        private Label label12;
        private BindingSource tableBindingSource;
        private BindingSource fieldRegisterBindingSource;
        private BindingSource tableBindingSource1;
        private DataGridView dtgvTime;
        private TextBox txbFieldType;
        private TextBox txtBoxFieldStatus;
        private Panel panel18;
        private TextBox txbTimeStatus;
        private Label label8;
        private Panel panel3;
        private TextBox txbIdAccount;
        private Label label9;
        private NumericUpDown nmAccountType;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn displayNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAccountDataGridViewTextBoxColumn;
        private BindingSource accountBindingSource;
    }
}