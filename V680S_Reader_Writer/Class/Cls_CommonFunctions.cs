using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace V680S_Reader_Writer.Class
{
    class Cls_CommonFunctions
    {
        static string errMsg = "";

        #region"共通機能"

        #region"メッセージ表示"

        /// <summary>
        /// メッセージ表示
        /// </summary>
        /// <param name="msg_">表示テキスト</param>
        public static void ErrorMessageView(string msg_)
        {
            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} メッセージの表示を開始します。");

                MessageBox.Show(msg_);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} メッセージの表示中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n ErrorMessageView() \r\n" + ex.Message;

                ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} メッセージの表示を中断します。");

            }

        }

        #endregion

        #region"XML読み書き"

        #region"XML読み込み"

        /// <summary>
        /// XML読み込み
        /// </summary>
        public static bool ReadXml()
        {
            string st_ServerPort_ETN = "";
            string st_ServerPort_EIP = "";
            string st_ReadTimeout = "";
            string st_WriteTimeout = "";
            string st_RFIDCarrierSize = "";
            string st_communicationProtocol = "";
            string msg = "";

            bool IsError = false;

            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} XMLファイルの読み込みを開始します。");

                XElement xml = XElement.Load(@".\setting\App_Setting.xml");

                IEnumerable<XElement> infos = from item in xml.Elements("AppSetting") select item;

                // XML読出し
                foreach (XElement info in infos)
                {
                    st_ServerPort_ETN = info.Element("ModbusPortNo").Value;
                    st_ServerPort_EIP = info.Element("EthernetIPPortNo").Value;
                    st_ReadTimeout = info.Element("ReadTimeout").Value;
                    st_WriteTimeout = info.Element("WriteTimeout").Value;
                    st_RFIDCarrierSize = info.Element("RFIDCarrierSize").Value;
                    st_communicationProtocol = info.Element("CommunicationProtocol").Value;

                }

                // int変換
                if (!(int.TryParse(st_ServerPort_ETN, out FormMain.serverPort_ETN)))
                {
                    msg = "Modbus通信のポート番号が不正です。\n\r設定を確認してください。\n\rデフォルト：502";

                    ErrorMessageView(msg);

                    IsError = true;

                }

                if (!(int.TryParse(st_ServerPort_EIP, out FormMain.serverPort_EIP)))
                {
                    msg = "Ethernet IP通信のポート番号が不正です。\n\r設定を確認してください。\n\rデフォルト：7090";

                    ErrorMessageView(msg);

                    IsError = true;

                }

                if (!(int.TryParse(st_ReadTimeout, out FormMain.readTimeout)))
                {
                    msg = "読取りタイムアウトの設定値が不正です。\n\r設定を確認してください。\n\rデフォルト：10000ms";

                    ErrorMessageView(msg);

                    IsError = true;

                }

                if (!(int.TryParse(st_WriteTimeout, out FormMain.writeTimeout)))
                {
                    msg = "書込みタイムアウトの設定値が不正です。\n\r設定を確認してください。\n\rデフォルト：10000ms";

                    ErrorMessageView(msg);

                    IsError = true;

                }

                if (!(int.TryParse(st_RFIDCarrierSize, out FormMain.RFIDCarrierSize)))
                {
                    msg = "IDキャリアの最大アドレスの設定値が不正です。\n\r設定を確認してください。\n\rデフォルト：8192 bytes";

                    ErrorMessageView(msg);

                    IsError = true;

                }
                else if (FormMain.RFIDCarrierSize > 8192 || FormMain.RFIDCarrierSize < 0)
                {
                    msg = "IDキャリアの最大アドレスの設定値が範囲外です。\n\r設定を確認してください。\n\r設定可能範囲：0 ～ 8192 bytes";

                    ErrorMessageView(msg);

                    IsError = true;

                }

                // 通信プロトコルを確認
                if (st_communicationProtocol == "Modbus")
                {
                    FormMain.communicationProtocol = 0;

                }
                else if (st_communicationProtocol == "EthernetIP")
                {
                    FormMain.communicationProtocol = 1;

                }
                else
                {
                    msg = "通信プロトコルの設定値が不正です。\n\r設定を確認してください。\n\rデフォルト：Modbus";

                    ErrorMessageView(msg);

                    IsError = true;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} XMLファイルの読み込み中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n ReadXml() \r\n" + ex.Message;

                ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} メッセージの表示を中断します。");

            }

            return IsError;

        }

        #endregion

        #region"XML書込み"

        public static void WriteXml(int RFIDCarrierSize_, string mode_)
        {
            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} XMLファイルの書込みを開始します。");

                XElement xml = XElement.Load(@".\setting\App_Setting.xml");

                XElement info = (from item in xml.Elements("AppSetting") select item).Single();

                info.Element("RFIDCarrierSize").Value = RFIDCarrierSize_.ToString();
                info.Element("CommunicationProtocol").Value = mode_;

                xml.Save(@".\setting\App_Setting.xml");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} XMLファイルの書込み中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n WriteXml() \r\n" + ex.Message;

                ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} XMLファイルの書込みを中断します。");

            }

        }

        #endregion

        #endregion

        #region"終了処理"

        /// <summary>
        /// フォームの修了確認
        /// </summary>
        /// /// <returns>終了フラグ (Trueなら終了する)</returns>
        public static bool FormCloseCheck(string msg_)
        {
            bool ret = false;

            string caption = "確認";

            MessageBoxButtons msbBtn = MessageBoxButtons.OKCancel;
            MessageBoxIcon msbIcon = MessageBoxIcon.Question;
            MessageBoxDefaultButton msbDefBtn = MessageBoxDefaultButton.Button2;

            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 修了確認処理を開始します。");

                DialogResult dialogResult = MessageBox.Show(msg_, caption, msbBtn, msbIcon, msbDefBtn);

                if (dialogResult == DialogResult.OK)
                {
                    ret = true;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 修了確認処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n MenuItem_FormClose_Click() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 修了確認処理を中断します。");

            }

            return ret;

        }

        #endregion

        #region"CSVファイル出力"

        /// <summary>
        /// CSVファイルへデータを出力する
        /// </summary>
        /// <param name="savePath__">保存先パス</param>
        /// <param name="outputData_">出力データ</param>
        public static void OutputCSV(string savePath__, string[][] outputData_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} CSV出力を開始します。");

            try
            {
                // CSVファイル出力
                File.WriteAllLines(savePath__, outputData_.Select(val => string.Join(",", val)));

                MessageBox.Show("ファイルを保存しました。");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} CSV出力を中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n OutputCSV() \r\n" + ex.Message;

                ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} CSV出力を中断します。");

            }

        }

        #endregion

        #endregion

    }
}
