namespace V680S_Reader_Writer
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txb_ReadIPAddress = new System.Windows.Forms.TextBox();
            this.lbl_ReadIPAddress = new System.Windows.Forms.Label();
            this.tabCtrl_ModeSwitch = new System.Windows.Forms.TabControl();
            this.tab_Read = new System.Windows.Forms.TabPage();
            this.btn_OutputCSV = new System.Windows.Forms.Button();
            this.nud_ReadDataLength = new System.Windows.Forms.NumericUpDown();
            this.nud_ReadStartAddress = new System.Windows.Forms.NumericUpDown();
            this.btn_RFIDRead = new System.Windows.Forms.Button();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_ReadDetaLength = new System.Windows.Forms.Label();
            this.lbl_ReadStartAddress = new System.Windows.Forms.Label();
            this.DGV_ReadData = new System.Windows.Forms.DataGridView();
            this.Column_Address_Decimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Address_Hex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ReadData_Binary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ReadData_ASCII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Write = new System.Windows.Forms.TabPage();
            this.rdbtn_ASCII = new System.Windows.Forms.RadioButton();
            this.rdbtn_Binary = new System.Windows.Forms.RadioButton();
            this.lbl_InputDataType = new System.Windows.Forms.Label();
            this.txb_WriteData = new System.Windows.Forms.TextBox();
            this.btn_RFIDWrite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_WriteStartAddress = new System.Windows.Forms.NumericUpDown();
            this.txb_WriteIPAddress = new System.Windows.Forms.TextBox();
            this.lbl_WriteData = new System.Windows.Forms.Label();
            this.lbl_WriteStartAddress = new System.Windows.Forms.Label();
            this.lbl_WriteIPAddress = new System.Windows.Forms.Label();
            this.tab_Collation = new System.Windows.Forms.TabPage();
            this.tab_DataTransfer = new System.Windows.Forms.TabPage();
            this.tab_DataClear1 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_FormClose = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tool = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCtrl_ModeSwitch.SuspendLayout();
            this.tab_Read.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ReadDataLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ReadStartAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ReadData)).BeginInit();
            this.tab_Write.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_WriteStartAddress)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_ReadIPAddress
            // 
            this.txb_ReadIPAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txb_ReadIPAddress.Location = new System.Drawing.Point(310, 33);
            this.txb_ReadIPAddress.Name = "txb_ReadIPAddress";
            this.txb_ReadIPAddress.Size = new System.Drawing.Size(265, 30);
            this.txb_ReadIPAddress.TabIndex = 0;
            // 
            // lbl_ReadIPAddress
            // 
            this.lbl_ReadIPAddress.AutoSize = true;
            this.lbl_ReadIPAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ReadIPAddress.Location = new System.Drawing.Point(41, 36);
            this.lbl_ReadIPAddress.Name = "lbl_ReadIPAddress";
            this.lbl_ReadIPAddress.Size = new System.Drawing.Size(174, 24);
            this.lbl_ReadIPAddress.TabIndex = 1;
            this.lbl_ReadIPAddress.Text = "V680S IPアドレス";
            // 
            // tabCtrl_ModeSwitch
            // 
            this.tabCtrl_ModeSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrl_ModeSwitch.Controls.Add(this.tab_Read);
            this.tabCtrl_ModeSwitch.Controls.Add(this.tab_Write);
            this.tabCtrl_ModeSwitch.Controls.Add(this.tab_Collation);
            this.tabCtrl_ModeSwitch.Controls.Add(this.tab_DataTransfer);
            this.tabCtrl_ModeSwitch.Controls.Add(this.tab_DataClear1);
            this.tabCtrl_ModeSwitch.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabCtrl_ModeSwitch.Location = new System.Drawing.Point(12, 31);
            this.tabCtrl_ModeSwitch.Name = "tabCtrl_ModeSwitch";
            this.tabCtrl_ModeSwitch.SelectedIndex = 0;
            this.tabCtrl_ModeSwitch.Size = new System.Drawing.Size(791, 490);
            this.tabCtrl_ModeSwitch.TabIndex = 2;
            // 
            // tab_Read
            // 
            this.tab_Read.Controls.Add(this.btn_OutputCSV);
            this.tab_Read.Controls.Add(this.nud_ReadDataLength);
            this.tab_Read.Controls.Add(this.nud_ReadStartAddress);
            this.tab_Read.Controls.Add(this.btn_RFIDRead);
            this.tab_Read.Controls.Add(this.lbl_Unit);
            this.tab_Read.Controls.Add(this.lbl_ReadDetaLength);
            this.tab_Read.Controls.Add(this.lbl_ReadStartAddress);
            this.tab_Read.Controls.Add(this.DGV_ReadData);
            this.tab_Read.Controls.Add(this.txb_ReadIPAddress);
            this.tab_Read.Controls.Add(this.lbl_ReadIPAddress);
            this.tab_Read.Location = new System.Drawing.Point(4, 33);
            this.tab_Read.Name = "tab_Read";
            this.tab_Read.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Read.Size = new System.Drawing.Size(783, 453);
            this.tab_Read.TabIndex = 0;
            this.tab_Read.Text = "RFID読取り";
            this.tab_Read.UseVisualStyleBackColor = true;
            // 
            // btn_OutputCSV
            // 
            this.btn_OutputCSV.Location = new System.Drawing.Point(603, 115);
            this.btn_OutputCSV.Name = "btn_OutputCSV";
            this.btn_OutputCSV.Size = new System.Drawing.Size(157, 63);
            this.btn_OutputCSV.TabIndex = 11;
            this.btn_OutputCSV.Text = "CSV出力";
            this.btn_OutputCSV.UseVisualStyleBackColor = true;
            this.btn_OutputCSV.Click += new System.EventHandler(this.btn_OutputCSV_Click);
            // 
            // nud_ReadDataLength
            // 
            this.nud_ReadDataLength.Location = new System.Drawing.Point(310, 148);
            this.nud_ReadDataLength.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.nud_ReadDataLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_ReadDataLength.Name = "nud_ReadDataLength";
            this.nud_ReadDataLength.Size = new System.Drawing.Size(103, 30);
            this.nud_ReadDataLength.TabIndex = 10;
            this.nud_ReadDataLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_ReadDataLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_ReadStartAddress
            // 
            this.nud_ReadStartAddress.Hexadecimal = true;
            this.nud_ReadStartAddress.Location = new System.Drawing.Point(310, 90);
            this.nud_ReadStartAddress.Maximum = new decimal(new int[] {
            8191,
            0,
            0,
            0});
            this.nud_ReadStartAddress.Name = "nud_ReadStartAddress";
            this.nud_ReadStartAddress.Size = new System.Drawing.Size(103, 30);
            this.nud_ReadStartAddress.TabIndex = 9;
            this.nud_ReadStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_RFIDRead
            // 
            this.btn_RFIDRead.Location = new System.Drawing.Point(603, 33);
            this.btn_RFIDRead.Name = "btn_RFIDRead";
            this.btn_RFIDRead.Size = new System.Drawing.Size(157, 63);
            this.btn_RFIDRead.TabIndex = 8;
            this.btn_RFIDRead.Text = "RFID読取り";
            this.btn_RFIDRead.UseVisualStyleBackColor = true;
            this.btn_RFIDRead.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Unit.Location = new System.Drawing.Point(419, 92);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(39, 24);
            this.lbl_Unit.TabIndex = 6;
            this.lbl_Unit.Text = "(H)";
            // 
            // lbl_ReadDetaLength
            // 
            this.lbl_ReadDetaLength.AutoSize = true;
            this.lbl_ReadDetaLength.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ReadDetaLength.Location = new System.Drawing.Point(41, 150);
            this.lbl_ReadDetaLength.Name = "lbl_ReadDetaLength";
            this.lbl_ReadDetaLength.Size = new System.Drawing.Size(244, 24);
            this.lbl_ReadDetaLength.TabIndex = 4;
            this.lbl_ReadDetaLength.Text = "読取りバイト数 (10進数)";
            // 
            // lbl_ReadStartAddress
            // 
            this.lbl_ReadStartAddress.AutoSize = true;
            this.lbl_ReadStartAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ReadStartAddress.Location = new System.Drawing.Point(41, 92);
            this.lbl_ReadStartAddress.Name = "lbl_ReadStartAddress";
            this.lbl_ReadStartAddress.Size = new System.Drawing.Size(222, 24);
            this.lbl_ReadStartAddress.TabIndex = 3;
            this.lbl_ReadStartAddress.Text = "先頭アドレス (16進数)";
            // 
            // DGV_ReadData
            // 
            this.DGV_ReadData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_ReadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ReadData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Address_Decimal,
            this.Column_Address_Hex,
            this.Column_ReadData_Binary,
            this.Column_ReadData_ASCII});
            this.DGV_ReadData.Location = new System.Drawing.Point(6, 206);
            this.DGV_ReadData.Name = "DGV_ReadData";
            this.DGV_ReadData.RowTemplate.Height = 24;
            this.DGV_ReadData.Size = new System.Drawing.Size(771, 241);
            this.DGV_ReadData.TabIndex = 2;
            // 
            // Column_Address_Decimal
            // 
            this.Column_Address_Decimal.HeaderText = "アドレス (10進数)";
            this.Column_Address_Decimal.Name = "Column_Address_Decimal";
            this.Column_Address_Decimal.Width = 120;
            // 
            // Column_Address_Hex
            // 
            this.Column_Address_Hex.HeaderText = "アドレス (16進数)";
            this.Column_Address_Hex.Name = "Column_Address_Hex";
            this.Column_Address_Hex.Width = 120;
            // 
            // Column_ReadData_Binary
            // 
            this.Column_ReadData_Binary.HeaderText = "読取り結果(16進数)";
            this.Column_ReadData_Binary.Name = "Column_ReadData_Binary";
            this.Column_ReadData_Binary.Width = 128;
            // 
            // Column_ReadData_ASCII
            // 
            this.Column_ReadData_ASCII.HeaderText = "読取り結果(ASCII)";
            this.Column_ReadData_ASCII.Name = "Column_ReadData_ASCII";
            this.Column_ReadData_ASCII.Width = 128;
            // 
            // tab_Write
            // 
            this.tab_Write.Controls.Add(this.rdbtn_ASCII);
            this.tab_Write.Controls.Add(this.rdbtn_Binary);
            this.tab_Write.Controls.Add(this.lbl_InputDataType);
            this.tab_Write.Controls.Add(this.txb_WriteData);
            this.tab_Write.Controls.Add(this.btn_RFIDWrite);
            this.tab_Write.Controls.Add(this.label4);
            this.tab_Write.Controls.Add(this.nud_WriteStartAddress);
            this.tab_Write.Controls.Add(this.txb_WriteIPAddress);
            this.tab_Write.Controls.Add(this.lbl_WriteData);
            this.tab_Write.Controls.Add(this.lbl_WriteStartAddress);
            this.tab_Write.Controls.Add(this.lbl_WriteIPAddress);
            this.tab_Write.Location = new System.Drawing.Point(4, 33);
            this.tab_Write.Name = "tab_Write";
            this.tab_Write.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Write.Size = new System.Drawing.Size(783, 453);
            this.tab_Write.TabIndex = 1;
            this.tab_Write.Text = "RFID書込み";
            this.tab_Write.UseVisualStyleBackColor = true;
            // 
            // rdbtn_ASCII
            // 
            this.rdbtn_ASCII.AutoSize = true;
            this.rdbtn_ASCII.Location = new System.Drawing.Point(450, 146);
            this.rdbtn_ASCII.Name = "rdbtn_ASCII";
            this.rdbtn_ASCII.Size = new System.Drawing.Size(88, 28);
            this.rdbtn_ASCII.TabIndex = 14;
            this.rdbtn_ASCII.Text = "ASCII";
            this.rdbtn_ASCII.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Binary
            // 
            this.rdbtn_Binary.AutoSize = true;
            this.rdbtn_Binary.Checked = true;
            this.rdbtn_Binary.Location = new System.Drawing.Point(310, 146);
            this.rdbtn_Binary.Name = "rdbtn_Binary";
            this.rdbtn_Binary.Size = new System.Drawing.Size(93, 28);
            this.rdbtn_Binary.TabIndex = 13;
            this.rdbtn_Binary.TabStop = true;
            this.rdbtn_Binary.Text = "Binary";
            this.rdbtn_Binary.UseVisualStyleBackColor = true;
            // 
            // lbl_InputDataType
            // 
            this.lbl_InputDataType.AutoSize = true;
            this.lbl_InputDataType.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_InputDataType.Location = new System.Drawing.Point(41, 150);
            this.lbl_InputDataType.Name = "lbl_InputDataType";
            this.lbl_InputDataType.Size = new System.Drawing.Size(91, 24);
            this.lbl_InputDataType.TabIndex = 12;
            this.lbl_InputDataType.Text = "データ型";
            // 
            // txb_WriteData
            // 
            this.txb_WriteData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_WriteData.Location = new System.Drawing.Point(24, 237);
            this.txb_WriteData.Multiline = true;
            this.txb_WriteData.Name = "txb_WriteData";
            this.txb_WriteData.Size = new System.Drawing.Size(736, 200);
            this.txb_WriteData.TabIndex = 11;
            // 
            // btn_RFIDWrite
            // 
            this.btn_RFIDWrite.Location = new System.Drawing.Point(603, 33);
            this.btn_RFIDWrite.Name = "btn_RFIDWrite";
            this.btn_RFIDWrite.Size = new System.Drawing.Size(157, 63);
            this.btn_RFIDWrite.TabIndex = 10;
            this.btn_RFIDWrite.Text = "RFID書込み";
            this.btn_RFIDWrite.UseVisualStyleBackColor = true;
            this.btn_RFIDWrite.Click += new System.EventHandler(this.btn_RFIDWrite_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(419, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "(H)";
            // 
            // nud_WriteStartAddress
            // 
            this.nud_WriteStartAddress.Hexadecimal = true;
            this.nud_WriteStartAddress.Location = new System.Drawing.Point(310, 90);
            this.nud_WriteStartAddress.Maximum = new decimal(new int[] {
            8191,
            0,
            0,
            0});
            this.nud_WriteStartAddress.Name = "nud_WriteStartAddress";
            this.nud_WriteStartAddress.Size = new System.Drawing.Size(103, 30);
            this.nud_WriteStartAddress.TabIndex = 7;
            this.nud_WriteStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txb_WriteIPAddress
            // 
            this.txb_WriteIPAddress.Location = new System.Drawing.Point(310, 33);
            this.txb_WriteIPAddress.Name = "txb_WriteIPAddress";
            this.txb_WriteIPAddress.Size = new System.Drawing.Size(265, 30);
            this.txb_WriteIPAddress.TabIndex = 6;
            // 
            // lbl_WriteData
            // 
            this.lbl_WriteData.AutoSize = true;
            this.lbl_WriteData.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_WriteData.Location = new System.Drawing.Point(41, 201);
            this.lbl_WriteData.Name = "lbl_WriteData";
            this.lbl_WriteData.Size = new System.Drawing.Size(229, 24);
            this.lbl_WriteData.TabIndex = 5;
            this.lbl_WriteData.Text = "書込みデータ (16進数)";
            // 
            // lbl_WriteStartAddress
            // 
            this.lbl_WriteStartAddress.AutoSize = true;
            this.lbl_WriteStartAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_WriteStartAddress.Location = new System.Drawing.Point(41, 92);
            this.lbl_WriteStartAddress.Name = "lbl_WriteStartAddress";
            this.lbl_WriteStartAddress.Size = new System.Drawing.Size(222, 24);
            this.lbl_WriteStartAddress.TabIndex = 4;
            this.lbl_WriteStartAddress.Text = "先頭アドレス (16進数)";
            // 
            // lbl_WriteIPAddress
            // 
            this.lbl_WriteIPAddress.AutoSize = true;
            this.lbl_WriteIPAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_WriteIPAddress.Location = new System.Drawing.Point(41, 36);
            this.lbl_WriteIPAddress.Name = "lbl_WriteIPAddress";
            this.lbl_WriteIPAddress.Size = new System.Drawing.Size(174, 24);
            this.lbl_WriteIPAddress.TabIndex = 2;
            this.lbl_WriteIPAddress.Text = "V680S IPアドレス";
            // 
            // tab_Collation
            // 
            this.tab_Collation.Location = new System.Drawing.Point(4, 33);
            this.tab_Collation.Name = "tab_Collation";
            this.tab_Collation.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Collation.Size = new System.Drawing.Size(783, 453);
            this.tab_Collation.TabIndex = 2;
            this.tab_Collation.Text = "照合";
            this.tab_Collation.UseVisualStyleBackColor = true;
            // 
            // tab_DataTransfer
            // 
            this.tab_DataTransfer.Location = new System.Drawing.Point(4, 33);
            this.tab_DataTransfer.Name = "tab_DataTransfer";
            this.tab_DataTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DataTransfer.Size = new System.Drawing.Size(783, 453);
            this.tab_DataTransfer.TabIndex = 3;
            this.tab_DataTransfer.Text = "データ転送";
            this.tab_DataTransfer.UseVisualStyleBackColor = true;
            // 
            // tab_DataClear1
            // 
            this.tab_DataClear1.Location = new System.Drawing.Point(4, 33);
            this.tab_DataClear1.Name = "tab_DataClear1";
            this.tab_DataClear1.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DataClear1.Size = new System.Drawing.Size(783, 453);
            this.tab_DataClear1.TabIndex = 4;
            this.tab_DataClear1.Text = "ID初期化";
            this.tab_DataClear1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Tool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_FormClose});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(63, 24);
            this.Menu_File.Text = "ファイル";
            // 
            // MenuItem_FormClose
            // 
            this.MenuItem_FormClose.Name = "MenuItem_FormClose";
            this.MenuItem_FormClose.Size = new System.Drawing.Size(114, 26);
            this.MenuItem_FormClose.Text = "終了";
            this.MenuItem_FormClose.Click += new System.EventHandler(this.MenuItem_FormClose_Click);
            // 
            // Menu_Tool
            // 
            this.Menu_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Setting});
            this.Menu_Tool.Name = "Menu_Tool";
            this.Menu_Tool.Size = new System.Drawing.Size(54, 24);
            this.Menu_Tool.Text = "ツール";
            // 
            // MenuItem_Setting
            // 
            this.MenuItem_Setting.Name = "MenuItem_Setting";
            this.MenuItem_Setting.Size = new System.Drawing.Size(144, 26);
            this.MenuItem_Setting.Text = "動作設定";
            this.MenuItem_Setting.Click += new System.EventHandler(this.MenuItem_Setting_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 533);
            this.Controls.Add(this.tabCtrl_ModeSwitch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(833, 580);
            this.Name = "FormMain";
            this.Text = "V680S_ReaderWriter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabCtrl_ModeSwitch.ResumeLayout(false);
            this.tab_Read.ResumeLayout(false);
            this.tab_Read.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ReadDataLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ReadStartAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ReadData)).EndInit();
            this.tab_Write.ResumeLayout(false);
            this.tab_Write.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_WriteStartAddress)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_ReadIPAddress;
        private System.Windows.Forms.Label lbl_ReadIPAddress;
        private System.Windows.Forms.TabControl tabCtrl_ModeSwitch;
        private System.Windows.Forms.TabPage tab_Read;
        private System.Windows.Forms.Button btn_OutputCSV;
        private System.Windows.Forms.NumericUpDown nud_ReadDataLength;
        private System.Windows.Forms.NumericUpDown nud_ReadStartAddress;
        private System.Windows.Forms.Button btn_RFIDRead;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Label lbl_ReadDetaLength;
        private System.Windows.Forms.Label lbl_ReadStartAddress;
        private System.Windows.Forms.DataGridView DGV_ReadData;
        private System.Windows.Forms.TabPage tab_Write;
        private System.Windows.Forms.TabPage tab_Collation;
        private System.Windows.Forms.Button btn_RFIDWrite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_WriteStartAddress;
        private System.Windows.Forms.TextBox txb_WriteIPAddress;
        private System.Windows.Forms.Label lbl_WriteData;
        private System.Windows.Forms.Label lbl_WriteStartAddress;
        private System.Windows.Forms.Label lbl_WriteIPAddress;
        private System.Windows.Forms.Label lbl_InputDataType;
        private System.Windows.Forms.TextBox txb_WriteData;
        private System.Windows.Forms.RadioButton rdbtn_ASCII;
        private System.Windows.Forms.RadioButton rdbtn_Binary;
        private System.Windows.Forms.TabPage tab_DataTransfer;
        private System.Windows.Forms.TabPage tab_DataClear1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tool;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Setting;
        private System.Windows.Forms.ToolStripMenuItem Menu_File;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_FormClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Address_Decimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Address_Hex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ReadData_Binary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ReadData_ASCII;
    }
}

