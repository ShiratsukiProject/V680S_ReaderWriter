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
            this.Column_ReadAddress_Decimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ReadAddress_Hex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ReadData_Binary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ReadData_ASCII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_Write = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btn_OutputCSV2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_CollationDataLength = new System.Windows.Forms.NumericUpDown();
            this.nud_CollationStartAddress = new System.Windows.Forms.NumericUpDown();
            this.lbl_CollationDataLength = new System.Windows.Forms.Label();
            this.lbl_CollationStartAddress = new System.Windows.Forms.Label();
            this.txb_CollationIPAddress2 = new System.Windows.Forms.TextBox();
            this.lbl_IPAddress2 = new System.Windows.Forms.Label();
            this.btn_Collation = new System.Windows.Forms.Button();
            this.dgv_CollationResult = new System.Windows.Forms.DataGridView();
            this.Column_CollationAddress_Decimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CollationAddress_Hex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CollationData1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CollationData2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CollationResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_CollationIPAddress1 = new System.Windows.Forms.TextBox();
            this.lbl_IPAddress1 = new System.Windows.Forms.Label();
            this.tab_DataTransfer = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.btn_Transfar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_TransfarDataLength = new System.Windows.Forms.NumericUpDown();
            this.nud_TransfarStartAddress = new System.Windows.Forms.NumericUpDown();
            this.txb_TransfarIPAddress2 = new System.Windows.Forms.TextBox();
            this.txb_TransfarIPAddress1 = new System.Windows.Forms.TextBox();
            this.lbl_TransfarDataLength = new System.Windows.Forms.Label();
            this.lbl_TransfarStartAddress = new System.Windows.Forms.Label();
            this.lbl_TransfarIPAddress2 = new System.Windows.Forms.Label();
            this.lbl_TransfarIPAddress1 = new System.Windows.Forms.Label();
            this.tab_DataClear1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_RFIDReset = new System.Windows.Forms.Button();
            this.nud_ResetDataLength = new System.Windows.Forms.NumericUpDown();
            this.nud_ResetStartAddress = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ResetDataLength = new System.Windows.Forms.Label();
            this.lbl_ResetStartAddress = new System.Windows.Forms.Label();
            this.txb_ResetIPAddress = new System.Windows.Forms.TextBox();
            this.lbl_ResetIPAddress = new System.Windows.Forms.Label();
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
            this.tab_Collation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CollationDataLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CollationStartAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CollationResult)).BeginInit();
            this.tab_DataTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TransfarDataLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TransfarStartAddress)).BeginInit();
            this.tab_DataClear1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ResetDataLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ResetStartAddress)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_ReadIPAddress
            // 
            this.txb_ReadIPAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txb_ReadIPAddress.Location = new System.Drawing.Point(232, 26);
            this.txb_ReadIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txb_ReadIPAddress.Name = "txb_ReadIPAddress";
            this.txb_ReadIPAddress.Size = new System.Drawing.Size(200, 26);
            this.txb_ReadIPAddress.TabIndex = 0;
            // 
            // lbl_ReadIPAddress
            // 
            this.lbl_ReadIPAddress.AutoSize = true;
            this.lbl_ReadIPAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ReadIPAddress.Location = new System.Drawing.Point(31, 29);
            this.lbl_ReadIPAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ReadIPAddress.Name = "lbl_ReadIPAddress";
            this.lbl_ReadIPAddress.Size = new System.Drawing.Size(142, 19);
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
            this.tabCtrl_ModeSwitch.Location = new System.Drawing.Point(9, 25);
            this.tabCtrl_ModeSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.tabCtrl_ModeSwitch.Name = "tabCtrl_ModeSwitch";
            this.tabCtrl_ModeSwitch.SelectedIndex = 0;
            this.tabCtrl_ModeSwitch.Size = new System.Drawing.Size(733, 464);
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
            this.tab_Read.Location = new System.Drawing.Point(4, 28);
            this.tab_Read.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Read.Name = "tab_Read";
            this.tab_Read.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Read.Size = new System.Drawing.Size(725, 432);
            this.tab_Read.TabIndex = 0;
            this.tab_Read.Text = "RFID読取り";
            this.tab_Read.UseVisualStyleBackColor = true;
            // 
            // btn_OutputCSV
            // 
            this.btn_OutputCSV.Location = new System.Drawing.Point(582, 94);
            this.btn_OutputCSV.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OutputCSV.Name = "btn_OutputCSV";
            this.btn_OutputCSV.Size = new System.Drawing.Size(118, 50);
            this.btn_OutputCSV.TabIndex = 11;
            this.btn_OutputCSV.Text = "CSV出力";
            this.btn_OutputCSV.UseVisualStyleBackColor = true;
            this.btn_OutputCSV.Click += new System.EventHandler(this.btn_OutputCSV_Click);
            // 
            // nud_ReadDataLength
            // 
            this.nud_ReadDataLength.Location = new System.Drawing.Point(232, 118);
            this.nud_ReadDataLength.Margin = new System.Windows.Forms.Padding(2);
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
            this.nud_ReadDataLength.Size = new System.Drawing.Size(77, 26);
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
            this.nud_ReadStartAddress.Location = new System.Drawing.Point(232, 72);
            this.nud_ReadStartAddress.Margin = new System.Windows.Forms.Padding(2);
            this.nud_ReadStartAddress.Maximum = new decimal(new int[] {
            8191,
            0,
            0,
            0});
            this.nud_ReadStartAddress.Name = "nud_ReadStartAddress";
            this.nud_ReadStartAddress.Size = new System.Drawing.Size(77, 26);
            this.nud_ReadStartAddress.TabIndex = 9;
            this.nud_ReadStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_RFIDRead
            // 
            this.btn_RFIDRead.Location = new System.Drawing.Point(582, 26);
            this.btn_RFIDRead.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RFIDRead.Name = "btn_RFIDRead";
            this.btn_RFIDRead.Size = new System.Drawing.Size(118, 50);
            this.btn_RFIDRead.TabIndex = 8;
            this.btn_RFIDRead.Text = "RFID読取り";
            this.btn_RFIDRead.UseVisualStyleBackColor = true;
            this.btn_RFIDRead.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Unit.Location = new System.Drawing.Point(314, 74);
            this.lbl_Unit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(33, 19);
            this.lbl_Unit.TabIndex = 6;
            this.lbl_Unit.Text = "(H)";
            // 
            // lbl_ReadDetaLength
            // 
            this.lbl_ReadDetaLength.AutoSize = true;
            this.lbl_ReadDetaLength.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ReadDetaLength.Location = new System.Drawing.Point(31, 120);
            this.lbl_ReadDetaLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ReadDetaLength.Name = "lbl_ReadDetaLength";
            this.lbl_ReadDetaLength.Size = new System.Drawing.Size(197, 19);
            this.lbl_ReadDetaLength.TabIndex = 4;
            this.lbl_ReadDetaLength.Text = "読取りバイト数 (10進数)";
            // 
            // lbl_ReadStartAddress
            // 
            this.lbl_ReadStartAddress.AutoSize = true;
            this.lbl_ReadStartAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ReadStartAddress.Location = new System.Drawing.Point(31, 74);
            this.lbl_ReadStartAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ReadStartAddress.Name = "lbl_ReadStartAddress";
            this.lbl_ReadStartAddress.Size = new System.Drawing.Size(180, 19);
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
            this.Column_ReadAddress_Decimal,
            this.Column_ReadAddress_Hex,
            this.Column_ReadData_Binary,
            this.Column_ReadData_ASCII});
            this.DGV_ReadData.Location = new System.Drawing.Point(22, 214);
            this.DGV_ReadData.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_ReadData.Name = "DGV_ReadData";
            this.DGV_ReadData.RowHeadersWidth = 51;
            this.DGV_ReadData.RowTemplate.Height = 24;
            this.DGV_ReadData.Size = new System.Drawing.Size(680, 194);
            this.DGV_ReadData.TabIndex = 2;
            // 
            // Column_ReadAddress_Decimal
            // 
            this.Column_ReadAddress_Decimal.HeaderText = "アドレス (10進数)";
            this.Column_ReadAddress_Decimal.MinimumWidth = 6;
            this.Column_ReadAddress_Decimal.Name = "Column_ReadAddress_Decimal";
            this.Column_ReadAddress_Decimal.Width = 120;
            // 
            // Column_ReadAddress_Hex
            // 
            this.Column_ReadAddress_Hex.HeaderText = "アドレス (16進数)";
            this.Column_ReadAddress_Hex.MinimumWidth = 6;
            this.Column_ReadAddress_Hex.Name = "Column_ReadAddress_Hex";
            this.Column_ReadAddress_Hex.Width = 120;
            // 
            // Column_ReadData_Binary
            // 
            this.Column_ReadData_Binary.HeaderText = "読取り結果(16進数)";
            this.Column_ReadData_Binary.MinimumWidth = 6;
            this.Column_ReadData_Binary.Name = "Column_ReadData_Binary";
            this.Column_ReadData_Binary.Width = 132;
            // 
            // Column_ReadData_ASCII
            // 
            this.Column_ReadData_ASCII.HeaderText = "読取り結果(ASCII)";
            this.Column_ReadData_ASCII.MinimumWidth = 6;
            this.Column_ReadData_ASCII.Name = "Column_ReadData_ASCII";
            this.Column_ReadData_ASCII.Width = 132;
            // 
            // tab_Write
            // 
            this.tab_Write.Controls.Add(this.label1);
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
            this.tab_Write.Location = new System.Drawing.Point(4, 28);
            this.tab_Write.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Write.Name = "tab_Write";
            this.tab_Write.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Write.Size = new System.Drawing.Size(725, 432);
            this.tab_Write.TabIndex = 1;
            this.tab_Write.Text = "RFID書込み";
            this.tab_Write.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(31, 157);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "書込みデータ (16進数)";
            // 
            // rdbtn_ASCII
            // 
            this.rdbtn_ASCII.AutoSize = true;
            this.rdbtn_ASCII.Location = new System.Drawing.Point(365, 117);
            this.rdbtn_ASCII.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtn_ASCII.Name = "rdbtn_ASCII";
            this.rdbtn_ASCII.Size = new System.Drawing.Size(73, 23);
            this.rdbtn_ASCII.TabIndex = 14;
            this.rdbtn_ASCII.Text = "ASCII";
            this.rdbtn_ASCII.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Binary
            // 
            this.rdbtn_Binary.AutoSize = true;
            this.rdbtn_Binary.Checked = true;
            this.rdbtn_Binary.Location = new System.Drawing.Point(232, 117);
            this.rdbtn_Binary.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtn_Binary.Name = "rdbtn_Binary";
            this.rdbtn_Binary.Size = new System.Drawing.Size(78, 23);
            this.rdbtn_Binary.TabIndex = 13;
            this.rdbtn_Binary.TabStop = true;
            this.rdbtn_Binary.Text = "Binary";
            this.rdbtn_Binary.UseVisualStyleBackColor = true;
            // 
            // lbl_InputDataType
            // 
            this.lbl_InputDataType.AutoSize = true;
            this.lbl_InputDataType.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_InputDataType.Location = new System.Drawing.Point(31, 120);
            this.lbl_InputDataType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_InputDataType.Name = "lbl_InputDataType";
            this.lbl_InputDataType.Size = new System.Drawing.Size(73, 19);
            this.lbl_InputDataType.TabIndex = 12;
            this.lbl_InputDataType.Text = "データ型";
            // 
            // txb_WriteData
            // 
            this.txb_WriteData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_WriteData.Location = new System.Drawing.Point(22, 214);
            this.txb_WriteData.Margin = new System.Windows.Forms.Padding(2);
            this.txb_WriteData.Multiline = true;
            this.txb_WriteData.Name = "txb_WriteData";
            this.txb_WriteData.Size = new System.Drawing.Size(680, 194);
            this.txb_WriteData.TabIndex = 11;
            // 
            // btn_RFIDWrite
            // 
            this.btn_RFIDWrite.Location = new System.Drawing.Point(560, 26);
            this.btn_RFIDWrite.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RFIDWrite.Name = "btn_RFIDWrite";
            this.btn_RFIDWrite.Size = new System.Drawing.Size(118, 50);
            this.btn_RFIDWrite.TabIndex = 10;
            this.btn_RFIDWrite.Text = "RFID書込み";
            this.btn_RFIDWrite.UseVisualStyleBackColor = true;
            this.btn_RFIDWrite.Click += new System.EventHandler(this.btn_RFIDWrite_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(314, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "(H)";
            // 
            // nud_WriteStartAddress
            // 
            this.nud_WriteStartAddress.Hexadecimal = true;
            this.nud_WriteStartAddress.Location = new System.Drawing.Point(232, 72);
            this.nud_WriteStartAddress.Margin = new System.Windows.Forms.Padding(2);
            this.nud_WriteStartAddress.Maximum = new decimal(new int[] {
            8191,
            0,
            0,
            0});
            this.nud_WriteStartAddress.Name = "nud_WriteStartAddress";
            this.nud_WriteStartAddress.Size = new System.Drawing.Size(77, 26);
            this.nud_WriteStartAddress.TabIndex = 7;
            this.nud_WriteStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txb_WriteIPAddress
            // 
            this.txb_WriteIPAddress.Location = new System.Drawing.Point(232, 26);
            this.txb_WriteIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txb_WriteIPAddress.Name = "txb_WriteIPAddress";
            this.txb_WriteIPAddress.Size = new System.Drawing.Size(200, 26);
            this.txb_WriteIPAddress.TabIndex = 6;
            // 
            // lbl_WriteData
            // 
            this.lbl_WriteData.AutoSize = true;
            this.lbl_WriteData.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_WriteData.Location = new System.Drawing.Point(61, 179);
            this.lbl_WriteData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_WriteData.Name = "lbl_WriteData";
            this.lbl_WriteData.Size = new System.Drawing.Size(432, 19);
            this.lbl_WriteData.TabIndex = 5;
            this.lbl_WriteData.Text = "(Binalyで入力する場合はカンマ \" , \" で区切ってください)";
            // 
            // lbl_WriteStartAddress
            // 
            this.lbl_WriteStartAddress.AutoSize = true;
            this.lbl_WriteStartAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_WriteStartAddress.Location = new System.Drawing.Point(31, 74);
            this.lbl_WriteStartAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_WriteStartAddress.Name = "lbl_WriteStartAddress";
            this.lbl_WriteStartAddress.Size = new System.Drawing.Size(180, 19);
            this.lbl_WriteStartAddress.TabIndex = 4;
            this.lbl_WriteStartAddress.Text = "先頭アドレス (16進数)";
            // 
            // lbl_WriteIPAddress
            // 
            this.lbl_WriteIPAddress.AutoSize = true;
            this.lbl_WriteIPAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_WriteIPAddress.Location = new System.Drawing.Point(31, 29);
            this.lbl_WriteIPAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_WriteIPAddress.Name = "lbl_WriteIPAddress";
            this.lbl_WriteIPAddress.Size = new System.Drawing.Size(142, 19);
            this.lbl_WriteIPAddress.TabIndex = 2;
            this.lbl_WriteIPAddress.Text = "V680S IPアドレス";
            // 
            // tab_Collation
            // 
            this.tab_Collation.Controls.Add(this.btn_OutputCSV2);
            this.tab_Collation.Controls.Add(this.label3);
            this.tab_Collation.Controls.Add(this.nud_CollationDataLength);
            this.tab_Collation.Controls.Add(this.nud_CollationStartAddress);
            this.tab_Collation.Controls.Add(this.lbl_CollationDataLength);
            this.tab_Collation.Controls.Add(this.lbl_CollationStartAddress);
            this.tab_Collation.Controls.Add(this.txb_CollationIPAddress2);
            this.tab_Collation.Controls.Add(this.lbl_IPAddress2);
            this.tab_Collation.Controls.Add(this.btn_Collation);
            this.tab_Collation.Controls.Add(this.dgv_CollationResult);
            this.tab_Collation.Controls.Add(this.txb_CollationIPAddress1);
            this.tab_Collation.Controls.Add(this.lbl_IPAddress1);
            this.tab_Collation.Location = new System.Drawing.Point(4, 28);
            this.tab_Collation.Margin = new System.Windows.Forms.Padding(2);
            this.tab_Collation.Name = "tab_Collation";
            this.tab_Collation.Padding = new System.Windows.Forms.Padding(2);
            this.tab_Collation.Size = new System.Drawing.Size(725, 432);
            this.tab_Collation.TabIndex = 2;
            this.tab_Collation.Text = "照合";
            this.tab_Collation.UseVisualStyleBackColor = true;
            // 
            // btn_OutputCSV2
            // 
            this.btn_OutputCSV2.Location = new System.Drawing.Point(582, 94);
            this.btn_OutputCSV2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_OutputCSV2.Name = "btn_OutputCSV2";
            this.btn_OutputCSV2.Size = new System.Drawing.Size(118, 50);
            this.btn_OutputCSV2.TabIndex = 29;
            this.btn_OutputCSV2.Text = "CSV出力";
            this.btn_OutputCSV2.UseVisualStyleBackColor = true;
            this.btn_OutputCSV2.Click += new System.EventHandler(this.btn_OutputCSV2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(314, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "(H)";
            // 
            // nud_CollationDataLength
            // 
            this.nud_CollationDataLength.Location = new System.Drawing.Point(232, 162);
            this.nud_CollationDataLength.Margin = new System.Windows.Forms.Padding(2);
            this.nud_CollationDataLength.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.nud_CollationDataLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_CollationDataLength.Name = "nud_CollationDataLength";
            this.nud_CollationDataLength.Size = new System.Drawing.Size(77, 26);
            this.nud_CollationDataLength.TabIndex = 27;
            this.nud_CollationDataLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_CollationDataLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_CollationStartAddress
            // 
            this.nud_CollationStartAddress.Hexadecimal = true;
            this.nud_CollationStartAddress.Location = new System.Drawing.Point(232, 117);
            this.nud_CollationStartAddress.Margin = new System.Windows.Forms.Padding(2);
            this.nud_CollationStartAddress.Maximum = new decimal(new int[] {
            8191,
            0,
            0,
            0});
            this.nud_CollationStartAddress.Name = "nud_CollationStartAddress";
            this.nud_CollationStartAddress.Size = new System.Drawing.Size(77, 26);
            this.nud_CollationStartAddress.TabIndex = 26;
            this.nud_CollationStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_CollationDataLength
            // 
            this.lbl_CollationDataLength.AutoSize = true;
            this.lbl_CollationDataLength.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_CollationDataLength.Location = new System.Drawing.Point(31, 163);
            this.lbl_CollationDataLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CollationDataLength.Name = "lbl_CollationDataLength";
            this.lbl_CollationDataLength.Size = new System.Drawing.Size(185, 19);
            this.lbl_CollationDataLength.TabIndex = 25;
            this.lbl_CollationDataLength.Text = "照合バイト数 (10進数)";
            // 
            // lbl_CollationStartAddress
            // 
            this.lbl_CollationStartAddress.AutoSize = true;
            this.lbl_CollationStartAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_CollationStartAddress.Location = new System.Drawing.Point(31, 118);
            this.lbl_CollationStartAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CollationStartAddress.Name = "lbl_CollationStartAddress";
            this.lbl_CollationStartAddress.Size = new System.Drawing.Size(174, 19);
            this.lbl_CollationStartAddress.TabIndex = 24;
            this.lbl_CollationStartAddress.Text = "先頭アドレス(16進数)";
            // 
            // txb_CollationIPAddress2
            // 
            this.txb_CollationIPAddress2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txb_CollationIPAddress2.Location = new System.Drawing.Point(232, 72);
            this.txb_CollationIPAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txb_CollationIPAddress2.Name = "txb_CollationIPAddress2";
            this.txb_CollationIPAddress2.Size = new System.Drawing.Size(200, 26);
            this.txb_CollationIPAddress2.TabIndex = 22;
            // 
            // lbl_IPAddress2
            // 
            this.lbl_IPAddress2.AutoSize = true;
            this.lbl_IPAddress2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_IPAddress2.Location = new System.Drawing.Point(31, 74);
            this.lbl_IPAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IPAddress2.Name = "lbl_IPAddress2";
            this.lbl_IPAddress2.Size = new System.Drawing.Size(152, 19);
            this.lbl_IPAddress2.TabIndex = 21;
            this.lbl_IPAddress2.Text = "V680S IPアドレス2";
            // 
            // btn_Collation
            // 
            this.btn_Collation.Location = new System.Drawing.Point(582, 26);
            this.btn_Collation.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Collation.Name = "btn_Collation";
            this.btn_Collation.Size = new System.Drawing.Size(118, 50);
            this.btn_Collation.TabIndex = 17;
            this.btn_Collation.Text = "照合開始";
            this.btn_Collation.UseVisualStyleBackColor = true;
            this.btn_Collation.Click += new System.EventHandler(this.btnRFID1Read_Click);
            // 
            // dgv_CollationResult
            // 
            this.dgv_CollationResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_CollationResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CollationResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_CollationAddress_Decimal,
            this.Column_CollationAddress_Hex,
            this.Column_CollationData1,
            this.Column_CollationData2,
            this.Column_CollationResult});
            this.dgv_CollationResult.Location = new System.Drawing.Point(22, 214);
            this.dgv_CollationResult.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_CollationResult.Name = "dgv_CollationResult";
            this.dgv_CollationResult.RowHeadersWidth = 51;
            this.dgv_CollationResult.RowTemplate.Height = 24;
            this.dgv_CollationResult.Size = new System.Drawing.Size(680, 194);
            this.dgv_CollationResult.TabIndex = 13;
            // 
            // Column_CollationAddress_Decimal
            // 
            this.Column_CollationAddress_Decimal.HeaderText = "アドレス (10進数)";
            this.Column_CollationAddress_Decimal.MinimumWidth = 6;
            this.Column_CollationAddress_Decimal.Name = "Column_CollationAddress_Decimal";
            this.Column_CollationAddress_Decimal.Width = 120;
            // 
            // Column_CollationAddress_Hex
            // 
            this.Column_CollationAddress_Hex.HeaderText = "アドレス (16進数)";
            this.Column_CollationAddress_Hex.MinimumWidth = 6;
            this.Column_CollationAddress_Hex.Name = "Column_CollationAddress_Hex";
            this.Column_CollationAddress_Hex.Width = 120;
            // 
            // Column_CollationData1
            // 
            this.Column_CollationData1.HeaderText = "読取り結果1 (16進数)";
            this.Column_CollationData1.MinimumWidth = 6;
            this.Column_CollationData1.Name = "Column_CollationData1";
            this.Column_CollationData1.Width = 132;
            // 
            // Column_CollationData2
            // 
            this.Column_CollationData2.HeaderText = "読取り結果2 (16進数)";
            this.Column_CollationData2.MinimumWidth = 6;
            this.Column_CollationData2.Name = "Column_CollationData2";
            this.Column_CollationData2.Width = 132;
            // 
            // Column_CollationResult
            // 
            this.Column_CollationResult.HeaderText = "照合結果";
            this.Column_CollationResult.MinimumWidth = 6;
            this.Column_CollationResult.Name = "Column_CollationResult";
            this.Column_CollationResult.Width = 120;
            // 
            // txb_CollationIPAddress1
            // 
            this.txb_CollationIPAddress1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txb_CollationIPAddress1.Location = new System.Drawing.Point(232, 26);
            this.txb_CollationIPAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txb_CollationIPAddress1.Name = "txb_CollationIPAddress1";
            this.txb_CollationIPAddress1.Size = new System.Drawing.Size(200, 26);
            this.txb_CollationIPAddress1.TabIndex = 12;
            // 
            // lbl_IPAddress1
            // 
            this.lbl_IPAddress1.AutoSize = true;
            this.lbl_IPAddress1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_IPAddress1.Location = new System.Drawing.Point(31, 29);
            this.lbl_IPAddress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_IPAddress1.Name = "lbl_IPAddress1";
            this.lbl_IPAddress1.Size = new System.Drawing.Size(152, 19);
            this.lbl_IPAddress1.TabIndex = 2;
            this.lbl_IPAddress1.Text = "V680S IPアドレス1";
            // 
            // tab_DataTransfer
            // 
            this.tab_DataTransfer.Controls.Add(this.label2);
            this.tab_DataTransfer.Controls.Add(this.lbl_Message);
            this.tab_DataTransfer.Controls.Add(this.btn_Transfar);
            this.tab_DataTransfer.Controls.Add(this.label9);
            this.tab_DataTransfer.Controls.Add(this.nud_TransfarDataLength);
            this.tab_DataTransfer.Controls.Add(this.nud_TransfarStartAddress);
            this.tab_DataTransfer.Controls.Add(this.txb_TransfarIPAddress2);
            this.tab_DataTransfer.Controls.Add(this.txb_TransfarIPAddress1);
            this.tab_DataTransfer.Controls.Add(this.lbl_TransfarDataLength);
            this.tab_DataTransfer.Controls.Add(this.lbl_TransfarStartAddress);
            this.tab_DataTransfer.Controls.Add(this.lbl_TransfarIPAddress2);
            this.tab_DataTransfer.Controls.Add(this.lbl_TransfarIPAddress1);
            this.tab_DataTransfer.Location = new System.Drawing.Point(4, 28);
            this.tab_DataTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.tab_DataTransfer.Name = "tab_DataTransfer";
            this.tab_DataTransfer.Padding = new System.Windows.Forms.Padding(2);
            this.tab_DataTransfer.Size = new System.Drawing.Size(725, 432);
            this.tab_DataTransfer.TabIndex = 3;
            this.tab_DataTransfer.Text = "データ転送";
            this.tab_DataTransfer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(117, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "※IPアドレス1のキャリアから読みだしたデータを、";
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Message.Location = new System.Drawing.Point(265, 302);
            this.lbl_Message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(290, 19);
            this.lbl_Message.TabIndex = 36;
            this.lbl_Message.Text = "IPアドレス2のキャリアに書き込みます。";
            // 
            // btn_Transfar
            // 
            this.btn_Transfar.Location = new System.Drawing.Point(582, 26);
            this.btn_Transfar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Transfar.Name = "btn_Transfar";
            this.btn_Transfar.Size = new System.Drawing.Size(118, 50);
            this.btn_Transfar.TabIndex = 35;
            this.btn_Transfar.Text = "転送開始";
            this.btn_Transfar.UseVisualStyleBackColor = true;
            this.btn_Transfar.Click += new System.EventHandler(this.btn_Transfar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(314, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "(H)";
            // 
            // nud_TransfarDataLength
            // 
            this.nud_TransfarDataLength.Location = new System.Drawing.Point(232, 162);
            this.nud_TransfarDataLength.Margin = new System.Windows.Forms.Padding(2);
            this.nud_TransfarDataLength.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.nud_TransfarDataLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_TransfarDataLength.Name = "nud_TransfarDataLength";
            this.nud_TransfarDataLength.Size = new System.Drawing.Size(77, 26);
            this.nud_TransfarDataLength.TabIndex = 33;
            this.nud_TransfarDataLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_TransfarDataLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_TransfarStartAddress
            // 
            this.nud_TransfarStartAddress.Hexadecimal = true;
            this.nud_TransfarStartAddress.Location = new System.Drawing.Point(232, 117);
            this.nud_TransfarStartAddress.Margin = new System.Windows.Forms.Padding(2);
            this.nud_TransfarStartAddress.Maximum = new decimal(new int[] {
            8191,
            0,
            0,
            0});
            this.nud_TransfarStartAddress.Name = "nud_TransfarStartAddress";
            this.nud_TransfarStartAddress.Size = new System.Drawing.Size(77, 26);
            this.nud_TransfarStartAddress.TabIndex = 32;
            this.nud_TransfarStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txb_TransfarIPAddress2
            // 
            this.txb_TransfarIPAddress2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txb_TransfarIPAddress2.Location = new System.Drawing.Point(232, 72);
            this.txb_TransfarIPAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txb_TransfarIPAddress2.Name = "txb_TransfarIPAddress2";
            this.txb_TransfarIPAddress2.Size = new System.Drawing.Size(200, 26);
            this.txb_TransfarIPAddress2.TabIndex = 31;
            // 
            // txb_TransfarIPAddress1
            // 
            this.txb_TransfarIPAddress1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txb_TransfarIPAddress1.Location = new System.Drawing.Point(232, 26);
            this.txb_TransfarIPAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txb_TransfarIPAddress1.Name = "txb_TransfarIPAddress1";
            this.txb_TransfarIPAddress1.Size = new System.Drawing.Size(200, 26);
            this.txb_TransfarIPAddress1.TabIndex = 30;
            // 
            // lbl_TransfarDataLength
            // 
            this.lbl_TransfarDataLength.AutoSize = true;
            this.lbl_TransfarDataLength.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TransfarDataLength.Location = new System.Drawing.Point(31, 163);
            this.lbl_TransfarDataLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TransfarDataLength.Name = "lbl_TransfarDataLength";
            this.lbl_TransfarDataLength.Size = new System.Drawing.Size(185, 19);
            this.lbl_TransfarDataLength.TabIndex = 29;
            this.lbl_TransfarDataLength.Text = "転送バイト数 (10進数)";
            // 
            // lbl_TransfarStartAddress
            // 
            this.lbl_TransfarStartAddress.AutoSize = true;
            this.lbl_TransfarStartAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TransfarStartAddress.Location = new System.Drawing.Point(31, 118);
            this.lbl_TransfarStartAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TransfarStartAddress.Name = "lbl_TransfarStartAddress";
            this.lbl_TransfarStartAddress.Size = new System.Drawing.Size(174, 19);
            this.lbl_TransfarStartAddress.TabIndex = 28;
            this.lbl_TransfarStartAddress.Text = "先頭アドレス(16進数)";
            // 
            // lbl_TransfarIPAddress2
            // 
            this.lbl_TransfarIPAddress2.AutoSize = true;
            this.lbl_TransfarIPAddress2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TransfarIPAddress2.Location = new System.Drawing.Point(31, 74);
            this.lbl_TransfarIPAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TransfarIPAddress2.Name = "lbl_TransfarIPAddress2";
            this.lbl_TransfarIPAddress2.Size = new System.Drawing.Size(152, 19);
            this.lbl_TransfarIPAddress2.TabIndex = 27;
            this.lbl_TransfarIPAddress2.Text = "V680S IPアドレス2";
            // 
            // lbl_TransfarIPAddress1
            // 
            this.lbl_TransfarIPAddress1.AutoSize = true;
            this.lbl_TransfarIPAddress1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TransfarIPAddress1.Location = new System.Drawing.Point(31, 29);
            this.lbl_TransfarIPAddress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TransfarIPAddress1.Name = "lbl_TransfarIPAddress1";
            this.lbl_TransfarIPAddress1.Size = new System.Drawing.Size(152, 19);
            this.lbl_TransfarIPAddress1.TabIndex = 26;
            this.lbl_TransfarIPAddress1.Text = "V680S IPアドレス1";
            // 
            // tab_DataClear1
            // 
            this.tab_DataClear1.Controls.Add(this.label6);
            this.tab_DataClear1.Controls.Add(this.btn_RFIDReset);
            this.tab_DataClear1.Controls.Add(this.nud_ResetDataLength);
            this.tab_DataClear1.Controls.Add(this.nud_ResetStartAddress);
            this.tab_DataClear1.Controls.Add(this.label5);
            this.tab_DataClear1.Controls.Add(this.lbl_ResetDataLength);
            this.tab_DataClear1.Controls.Add(this.lbl_ResetStartAddress);
            this.tab_DataClear1.Controls.Add(this.txb_ResetIPAddress);
            this.tab_DataClear1.Controls.Add(this.lbl_ResetIPAddress);
            this.tab_DataClear1.Location = new System.Drawing.Point(4, 28);
            this.tab_DataClear1.Margin = new System.Windows.Forms.Padding(2);
            this.tab_DataClear1.Name = "tab_DataClear1";
            this.tab_DataClear1.Padding = new System.Windows.Forms.Padding(2);
            this.tab_DataClear1.Size = new System.Drawing.Size(725, 432);
            this.tab_DataClear1.TabIndex = 4;
            this.tab_DataClear1.Text = "ID初期化";
            this.tab_DataClear1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(144, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(427, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "※指定された範囲のアドレスに\"00\"(H)を書き込みます。";
            // 
            // btn_RFIDReset
            // 
            this.btn_RFIDReset.Location = new System.Drawing.Point(582, 26);
            this.btn_RFIDReset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RFIDReset.Name = "btn_RFIDReset";
            this.btn_RFIDReset.Size = new System.Drawing.Size(118, 50);
            this.btn_RFIDReset.TabIndex = 18;
            this.btn_RFIDReset.Text = "初期化開始";
            this.btn_RFIDReset.UseVisualStyleBackColor = true;
            this.btn_RFIDReset.Click += new System.EventHandler(this.btn_RFIDReset_Click);
            // 
            // nud_ResetDataLength
            // 
            this.nud_ResetDataLength.Location = new System.Drawing.Point(232, 118);
            this.nud_ResetDataLength.Margin = new System.Windows.Forms.Padding(2);
            this.nud_ResetDataLength.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.nud_ResetDataLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_ResetDataLength.Name = "nud_ResetDataLength";
            this.nud_ResetDataLength.Size = new System.Drawing.Size(77, 26);
            this.nud_ResetDataLength.TabIndex = 17;
            this.nud_ResetDataLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_ResetDataLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_ResetStartAddress
            // 
            this.nud_ResetStartAddress.Hexadecimal = true;
            this.nud_ResetStartAddress.Location = new System.Drawing.Point(232, 72);
            this.nud_ResetStartAddress.Margin = new System.Windows.Forms.Padding(2);
            this.nud_ResetStartAddress.Maximum = new decimal(new int[] {
            8191,
            0,
            0,
            0});
            this.nud_ResetStartAddress.Name = "nud_ResetStartAddress";
            this.nud_ResetStartAddress.Size = new System.Drawing.Size(77, 26);
            this.nud_ResetStartAddress.TabIndex = 16;
            this.nud_ResetStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(314, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "(H)";
            // 
            // lbl_ResetDataLength
            // 
            this.lbl_ResetDataLength.AutoSize = true;
            this.lbl_ResetDataLength.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ResetDataLength.Location = new System.Drawing.Point(31, 120);
            this.lbl_ResetDataLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ResetDataLength.Name = "lbl_ResetDataLength";
            this.lbl_ResetDataLength.Size = new System.Drawing.Size(204, 19);
            this.lbl_ResetDataLength.TabIndex = 14;
            this.lbl_ResetDataLength.Text = "初期化バイト数 (10進数)";
            // 
            // lbl_ResetStartAddress
            // 
            this.lbl_ResetStartAddress.AutoSize = true;
            this.lbl_ResetStartAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ResetStartAddress.Location = new System.Drawing.Point(31, 74);
            this.lbl_ResetStartAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ResetStartAddress.Name = "lbl_ResetStartAddress";
            this.lbl_ResetStartAddress.Size = new System.Drawing.Size(180, 19);
            this.lbl_ResetStartAddress.TabIndex = 13;
            this.lbl_ResetStartAddress.Text = "先頭アドレス (16進数)";
            // 
            // txb_ResetIPAddress
            // 
            this.txb_ResetIPAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txb_ResetIPAddress.Location = new System.Drawing.Point(232, 26);
            this.txb_ResetIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txb_ResetIPAddress.Name = "txb_ResetIPAddress";
            this.txb_ResetIPAddress.Size = new System.Drawing.Size(200, 26);
            this.txb_ResetIPAddress.TabIndex = 11;
            // 
            // lbl_ResetIPAddress
            // 
            this.lbl_ResetIPAddress.AutoSize = true;
            this.lbl_ResetIPAddress.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ResetIPAddress.Location = new System.Drawing.Point(31, 29);
            this.lbl_ResetIPAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ResetIPAddress.Name = "lbl_ResetIPAddress";
            this.lbl_ResetIPAddress.Size = new System.Drawing.Size(142, 19);
            this.lbl_ResetIPAddress.TabIndex = 12;
            this.lbl_ResetIPAddress.Text = "V680S IPアドレス";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_File,
            this.Menu_Tool});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_File
            // 
            this.Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_FormClose});
            this.Menu_File.Name = "Menu_File";
            this.Menu_File.Size = new System.Drawing.Size(53, 20);
            this.Menu_File.Text = "ファイル";
            // 
            // MenuItem_FormClose
            // 
            this.MenuItem_FormClose.Name = "MenuItem_FormClose";
            this.MenuItem_FormClose.Size = new System.Drawing.Size(98, 22);
            this.MenuItem_FormClose.Text = "終了";
            this.MenuItem_FormClose.Click += new System.EventHandler(this.MenuItem_FormClose_Click);
            // 
            // Menu_Tool
            // 
            this.Menu_Tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Setting});
            this.Menu_Tool.Name = "Menu_Tool";
            this.Menu_Tool.Size = new System.Drawing.Size(46, 20);
            this.Menu_Tool.Text = "ツール";
            // 
            // MenuItem_Setting
            // 
            this.MenuItem_Setting.Name = "MenuItem_Setting";
            this.MenuItem_Setting.Size = new System.Drawing.Size(122, 22);
            this.MenuItem_Setting.Text = "動作設定";
            this.MenuItem_Setting.Click += new System.EventHandler(this.MenuItem_Setting_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 511);
            this.Controls.Add(this.tabCtrl_ModeSwitch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(650, 550);
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
            this.tab_Collation.ResumeLayout(false);
            this.tab_Collation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CollationDataLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CollationStartAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CollationResult)).EndInit();
            this.tab_DataTransfer.ResumeLayout(false);
            this.tab_DataTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TransfarDataLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_TransfarStartAddress)).EndInit();
            this.tab_DataClear1.ResumeLayout(false);
            this.tab_DataClear1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ResetDataLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ResetStartAddress)).EndInit();
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
        private System.Windows.Forms.Button btn_Collation;
        private System.Windows.Forms.DataGridView dgv_CollationResult;
        private System.Windows.Forms.TextBox txb_CollationIPAddress1;
        private System.Windows.Forms.Label lbl_IPAddress1;
        private System.Windows.Forms.TextBox txb_CollationIPAddress2;
        private System.Windows.Forms.Label lbl_IPAddress2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_CollationDataLength;
        private System.Windows.Forms.NumericUpDown nud_CollationStartAddress;
        private System.Windows.Forms.Label lbl_CollationDataLength;
        private System.Windows.Forms.Label lbl_CollationStartAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CollationAddress_Decimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CollationAddress_Hex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CollationData1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CollationData2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CollationResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ReadAddress_Decimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ReadAddress_Hex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ReadData_Binary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ReadData_ASCII;
        private System.Windows.Forms.NumericUpDown nud_ResetDataLength;
        private System.Windows.Forms.NumericUpDown nud_ResetStartAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ResetDataLength;
        private System.Windows.Forms.Label lbl_ResetStartAddress;
        private System.Windows.Forms.TextBox txb_ResetIPAddress;
        private System.Windows.Forms.Label lbl_ResetIPAddress;
        private System.Windows.Forms.Button btn_RFIDReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_WriteData;
        private System.Windows.Forms.Button btn_OutputCSV2;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button btn_Transfar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nud_TransfarDataLength;
        private System.Windows.Forms.NumericUpDown nud_TransfarStartAddress;
        private System.Windows.Forms.TextBox txb_TransfarIPAddress2;
        private System.Windows.Forms.TextBox txb_TransfarIPAddress1;
        private System.Windows.Forms.Label lbl_TransfarDataLength;
        private System.Windows.Forms.Label lbl_TransfarStartAddress;
        private System.Windows.Forms.Label lbl_TransfarIPAddress2;
        private System.Windows.Forms.Label lbl_TransfarIPAddress1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}

