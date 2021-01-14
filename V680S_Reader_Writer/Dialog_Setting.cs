using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V680S_Reader_Writer.Class;

namespace V680S_Reader_Writer
{
    public partial class Dialog_Setting : Form
    {
        string errMsg = "";

        #region"イニシャライズ"

        public Dialog_Setting()
        {
            InitializeComponent();
        }

        #endregion

        #region"イベント"

        #region"フォーム"

        #region"フォームロード"

        /// <summary>
        /// ダイアログ起動時
        /// </summary>
        /// <param name="sender">センダー</param>
        /// <param name="e">イベントハンドラ</param>
        private void Dialog_Setting_Load(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} フォームの呼び出し処理を開始します。");

                // フォーム初期化
                DialogReset();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} フォームの呼び出し処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n Dialog_Setting_Load() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} フォームの呼び出し処理を中断します。");

            }

        }

        #endregion

        #region"フォーム終了直前"

        /// <summary>
        /// ダイアログの修了直前
        /// </summary>
        /// <param name="sender">センダー</param>
        /// <param name="e">イベントハンドラ</param>
        private void Dialog_Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "設定ダイアログを閉じます。\r\nよろしいですか？";

            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} フォームの終了確認処理を開始します。");

                if (!Cls_CommonFunctions.FormCloseCheck(msg))
                {
                    e.Cancel = true;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} フォームの終了確認処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n Dialog_Setting_FormClosing() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} フォームの終了確認処理を中断します。");

            }

        }

        #endregion

        #endregion

        #region"ボタン"

        #region"保存"

        /// <summary>
        /// 保存ボタンのクリックイベント
        /// </summary>
        /// <param name="sender">センダー</param>
        /// <param name="e">イベントハンドラ</param>
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string msg = "設定値を保存します。\n\rよろしいですか？";
            string caption = "確認";
            string mode = "Modbus";

            decimal d_RFIDCarrierSize = Nud_RFIDCarrierSize.Value;

            int i_RFIDCarrierSize = 0;

            bool modbus = Rdb_ModbusMode.Checked;
            bool ethernet = Rdb_EthernetIPMode.Checked;

            MessageBoxButtons msbBtn = MessageBoxButtons.OKCancel;
            MessageBoxIcon msbIcon = MessageBoxIcon.Question;
            MessageBoxDefaultButton msbDefBtn = MessageBoxDefaultButton.Button2;

            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 動作設定の保存ボタンがクリックされました。");

                DialogResult dialogResult = MessageBox.Show(msg, caption, msbBtn, msbIcon, msbDefBtn);

                if (dialogResult == DialogResult.OK)
                {
                    i_RFIDCarrierSize = (int)d_RFIDCarrierSize;
                    
                    if(ethernet == true && modbus == false)
                    {
                        mode = "EthernetIP";
                    }

                    Cls_CommonFunctions.WriteXml(i_RFIDCarrierSize, mode);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 動作設定の保存中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n btn_Save_Click() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 動作設定の保存を中断します。");

            }

        }

        #endregion

        #endregion

        #endregion

        #region"非公開メソッド"

        #region"初期化処理"

        /// <summary>
        /// ダイアログの初期化処理
        /// </summary>
        private void DialogReset()
        {
            int communicationMode = 0;

            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} ダイアログの初期化処理を開始します。");

                Nud_RFIDCarrierSize.Value = FormMain.RFIDCarrierSize;

                communicationMode = FormMain.communicationProtocol;

                if (communicationMode == 1)
                {
                    Rdb_EthernetIPMode.Checked = true;
                    Rdb_ModbusMode.Checked = false;

                }
                else
                {
                    Rdb_EthernetIPMode.Checked = false;
                    Rdb_ModbusMode.Checked = true;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} ダイアログの初期化処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n DialogReset() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} ダイアログの初期化処理を中断します。");

            }

        }

        #endregion

        #endregion

    }

}
