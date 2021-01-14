namespace V680S_Reader_Writer
{
    partial class Dialog_Setting
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
            this.Lbl_RFIDCarrierSize = new System.Windows.Forms.Label();
            this.Nud_RFIDCarrierSize = new System.Windows.Forms.NumericUpDown();
            this.Rdb_ModbusMode = new System.Windows.Forms.RadioButton();
            this.Rdb_EthernetIPMode = new System.Windows.Forms.RadioButton();
            this.Lbl_CommunicationMode = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_RFIDCarrierSizeUnit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_RFIDCarrierSize)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_RFIDCarrierSize
            // 
            this.Lbl_RFIDCarrierSize.AutoSize = true;
            this.Lbl_RFIDCarrierSize.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_RFIDCarrierSize.Location = new System.Drawing.Point(40, 39);
            this.Lbl_RFIDCarrierSize.Name = "Lbl_RFIDCarrierSize";
            this.Lbl_RFIDCarrierSize.Size = new System.Drawing.Size(213, 24);
            this.Lbl_RFIDCarrierSize.TabIndex = 14;
            this.Lbl_RFIDCarrierSize.Text = "IDキャリア メモリサイズ";
            // 
            // Nud_RFIDCarrierSize
            // 
            this.Nud_RFIDCarrierSize.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Nud_RFIDCarrierSize.Location = new System.Drawing.Point(305, 37);
            this.Nud_RFIDCarrierSize.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.Nud_RFIDCarrierSize.Name = "Nud_RFIDCarrierSize";
            this.Nud_RFIDCarrierSize.Size = new System.Drawing.Size(103, 30);
            this.Nud_RFIDCarrierSize.TabIndex = 15;
            this.Nud_RFIDCarrierSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Rdb_ModbusMode
            // 
            this.Rdb_ModbusMode.AutoSize = true;
            this.Rdb_ModbusMode.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Rdb_ModbusMode.Location = new System.Drawing.Point(305, 106);
            this.Rdb_ModbusMode.Name = "Rdb_ModbusMode";
            this.Rdb_ModbusMode.Size = new System.Drawing.Size(165, 28);
            this.Rdb_ModbusMode.TabIndex = 16;
            this.Rdb_ModbusMode.TabStop = true;
            this.Rdb_ModbusMode.Text = "Modbus/TCP";
            this.Rdb_ModbusMode.UseVisualStyleBackColor = true;
            // 
            // Rdb_EthernetIPMode
            // 
            this.Rdb_EthernetIPMode.AutoSize = true;
            this.Rdb_EthernetIPMode.Enabled = false;
            this.Rdb_EthernetIPMode.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Rdb_EthernetIPMode.Location = new System.Drawing.Point(305, 153);
            this.Rdb_EthernetIPMode.Name = "Rdb_EthernetIPMode";
            this.Rdb_EthernetIPMode.Size = new System.Drawing.Size(150, 28);
            this.Rdb_EthernetIPMode.TabIndex = 17;
            this.Rdb_EthernetIPMode.TabStop = true;
            this.Rdb_EthernetIPMode.Text = "Ethernet/IP";
            this.Rdb_EthernetIPMode.UseVisualStyleBackColor = true;
            // 
            // Lbl_CommunicationMode
            // 
            this.Lbl_CommunicationMode.AutoSize = true;
            this.Lbl_CommunicationMode.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_CommunicationMode.Location = new System.Drawing.Point(40, 109);
            this.Lbl_CommunicationMode.Name = "Lbl_CommunicationMode";
            this.Lbl_CommunicationMode.Size = new System.Drawing.Size(106, 24);
            this.Lbl_CommunicationMode.TabIndex = 18;
            this.Lbl_CommunicationMode.Text = "通信方式";
            // 
            // btn_Save
            // 
            this.btn_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Save.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Save.Location = new System.Drawing.Point(174, 224);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(144, 44);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Cancel.Location = new System.Drawing.Point(345, 224);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(144, 44);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "キャンセル";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_RFIDCarrierSizeUnit
            // 
            this.lbl_RFIDCarrierSizeUnit.AutoSize = true;
            this.lbl_RFIDCarrierSizeUnit.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_RFIDCarrierSizeUnit.Location = new System.Drawing.Point(414, 39);
            this.lbl_RFIDCarrierSizeUnit.Name = "lbl_RFIDCarrierSizeUnit";
            this.lbl_RFIDCarrierSizeUnit.Size = new System.Drawing.Size(64, 24);
            this.lbl_RFIDCarrierSizeUnit.TabIndex = 21;
            this.lbl_RFIDCarrierSizeUnit.Text = "バイト";
            // 
            // Dialog_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 298);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_RFIDCarrierSizeUnit);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.Lbl_CommunicationMode);
            this.Controls.Add(this.Rdb_EthernetIPMode);
            this.Controls.Add(this.Rdb_ModbusMode);
            this.Controls.Add(this.Nud_RFIDCarrierSize);
            this.Controls.Add(this.Lbl_RFIDCarrierSize);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dialog_Setting";
            this.Text = "動作設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dialog_Setting_FormClosing);
            this.Load += new System.EventHandler(this.Dialog_Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_RFIDCarrierSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_RFIDCarrierSize;
        private System.Windows.Forms.NumericUpDown Nud_RFIDCarrierSize;
        private System.Windows.Forms.RadioButton Rdb_ModbusMode;
        private System.Windows.Forms.RadioButton Rdb_EthernetIPMode;
        private System.Windows.Forms.Label Lbl_CommunicationMode;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_RFIDCarrierSizeUnit;
    }
}