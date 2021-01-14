using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using V680S_Reader_Writer.Class;
using System.Diagnostics;
using System.Reflection;

namespace V680S_Reader_Writer
{
    public partial class FormMain : Form
    {
        #region"固定値"

        public static int serverPort_ETN = 502;
        public static int serverPort_EIP = 7090;
        public static int readTimeout = 10000;
        public static int writeTimeout = 10000;
        public static int RFIDCarrierSize = 8192;

        // 通信プロトコル　Modbus：0　Ethernet IP：1
        public static int communicationProtocol = 0;

        // Binaly：0　ASCII：1
        int inputMode = 0;
        
        string errMsg = "";

        static char separateChar = ',';
        static char inputChar_1 = '1';
        static char inputChar_2 = '2';
        static char inputChar_3 = '3';
        static char inputChar_4 = '4';
        static char inputChar_5 = '5';
        static char inputChar_6 = '6';
        static char inputChar_7 = '7';
        static char inputChar_8 = '8';
        static char inputChar_9 = '9';
        static char inputChar_0 = '0';
        static char inputChar_A = 'A';
        static char inputChar_B = 'B';
        static char inputChar_C = 'C';
        static char inputChar_D = 'D';
        static char inputChar_E = 'E';
        static char inputChar_F = 'F';
        static char inputChar_a = 'a';
        static char inputChar_b = 'b';
        static char inputChar_c = 'c';
        static char inputChar_d = 'd';
        static char inputChar_e = 'e';
        static char inputChar_f = 'f';

        static int readMaxByte = 250;
        static int writeMaxByte = 226;

        static byte[] transactionIdentifier = new byte[] { 0x00, 0x00 };
        static byte[] protocolIdentifier = new byte[] { 0x00, 0x00 };
        static byte[] unitIdentifier = new byte[] { 0xFF };
        static byte[] functionCode_R = new byte[] { 0x03 };
        static byte[] functionCode_W = new byte[] { 0x10 };
        static byte[] errorRegNo = new byte[] { 0xC7, 0x00 };
        static byte[] errorWordCount = new byte[] { 0x00, 0x7D };

        static byte exceptionCode = 0x00;

        static byte[] fieldLength;
        static byte[] registerNo;
        static byte[] wordCount;
        static byte[] byteCount;

        // 接続先サーバー情報
        static string m_serverAddress;
        static int m_serverPort;
        static int m_readTimeout;
        static int m_writeTimeout;

        // TCP通信ハンドル
        static TcpClient m_client;
        static NetworkStream m_tcpStream;

        #endregion

        #region"イニシャライズ"

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion

        #region"公開メソッド"

        #region"イベント"

        #region"フォーム"

        #region"フォームロード"

        /// <summary>
        /// メインフォームのロードイベント
        /// </summary>
        /// <param name="sender">センダー</param>
        /// <param name="e">イベントハンドラ</param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} フォームの呼び出しを検知しました。");

                bool isError = false;

                isError = Cls_CommonFunctions.ReadXml();

                if (isError)
                {
                    Close();

                }

                // バージョン番号を取得
                FileVersionInfo verInfo = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);

                string formTitle = this.Text;

                if (verInfo.FilePrivatePart == 0)
                {
                    formTitle = formTitle + "_Ver" + verInfo.FileMajorPart.ToString() + "." + verInfo.FileMinorPart.ToString() + verInfo.FileBuildPart.ToString();

                }
                else
                {
                    formTitle = formTitle + "_Ver" + verInfo.FileMajorPart.ToString() + "." + verInfo.FileMinorPart.ToString() + verInfo.FileBuildPart.ToString() + "-" + verInfo.FilePrivatePart.ToString();

                }

                // フォームタイトルを更新
                this.Text = formTitle;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} フォームの呼び出し処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n FormMain_Load() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} フォームの呼び出しを中断します。");

            }

        }

        #endregion

        #region"フォーム終了直前"

        /// <summary>
        /// フォーム修了前
        /// </summary>
        /// <param name="sender">センダー</param>
        /// <param name="e">イベントハンドラ</param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} フォームの終了を検知しました。");

                string msg = "アプリケーションを終了します。\r\nよろしいですか？";

                if (!Cls_CommonFunctions.FormCloseCheck(msg))
                {
                    e.Cancel = true;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 終了処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n FormMain_FormClosing() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 終了処理を中断します。");

            }

        }

        #endregion

        #endregion

        #region"メニューバー"

        #region"終了"

        /// <summary>
        /// 終了メニューのクリックイベント
        /// </summary>
        /// <param name="sender">センダー</param>
        /// <param name="e">イベントハンドラ</param>
        private void MenuItem_FormClose_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 終了メニューがクリックされました。");

                Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 終了処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n MenuItem_FormClose_Click() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 終了処理中を中断します。");

            }


        }

        #endregion

        #region"動作設定"

        /// <summary>
        /// 動作設定メニューのクリックイベント
        /// </summary>
        /// <param name="sender">センダー</param>
        /// <param name="e">イベントハンドラ</param>
        private void MenuItem_Setting_Click(object sender, EventArgs e)
        {
            bool isError = false;

            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 動作設定メニューがクリックされました。");

                Dialog_Setting dialog = new Dialog_Setting();

                DialogResult dialogResult = dialog.ShowDialog(this);

                // 設定を保存した場合は設定値を再取得
                if (dialogResult == DialogResult.OK)
                {
                    isError = Cls_CommonFunctions.ReadXml();

                    if (isError)
                    {
                        Close();

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 動作設定中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n MenuItem_Setting_Click() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 動作設定を中断します。");

            }

        }

        #endregion

        #endregion

        #region"ボタン"

        #region"RFID読取り"

        /// <summary>
        /// RFID読取りボタンのクリックイベント
        /// </summary>
        /// <param name="sender">センダー</param>
        /// <param name="e">イベント</param>
        private void btn_Read_Click(object sender, EventArgs e)
        {
            decimal readStartAddress = nud_ReadStartAddress.Value;
            decimal readDataLength = nud_ReadDataLength.Value;

            string serverAddress = txb_ReadIPAddress.Text;

            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りボタンがクリックされました。");


                //string msbText = "RFIDからデータを読み取ります。\r\nよろしいですか？";
                //string caption = "確認";

                //MessageBoxButtons msbBtn = MessageBoxButtons.OKCancel;
                //MessageBoxIcon msbIcon = MessageBoxIcon.Question;
                //MessageBoxDefaultButton msbDefBtn = MessageBoxDefaultButton.Button2;

                //DialogResult dialogResult = MessageBox.Show(this, msbText, caption, msbBtn, msbIcon, msbDefBtn);

                //if (dialogResult == DialogResult.OK)
                //{
                //    // グリッド初期化
                //    DGV_ReadData.Rows.Clear();

                //    RFIDReadReady(readStartAddress, readDataLength, serverAddress);

                //}

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} グリッドを初期化します。");
                // グリッド初期化
                DGV_ReadData.Rows.Clear();
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} グリッドを初期化しました。");

                RFIDReadReady(readStartAddress, readDataLength, serverAddress);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n btn_Read_Click() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り処理を中断します。");

            }
            finally
            {

            }

        }

        #endregion

        #region"CSV出力"

        private void btn_OutputCSV_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} CSV出力ボタンがクリックされました。");

            string savePath = "";

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = @"C:\";
            ofd.FileName = "V680S_ReadData.csv";
            ofd.Filter = "csvファイル{*.csv}|*.csv|すべてのファイル{*.*}|*.*";
            ofd.Title = "保存先を指定してください。";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = false;

            try
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    savePath = ofd.FileName;

                    OutputCSVReady(savePath);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} CSV出力処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n btn_OutputCSV_Click() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} CSV出力処理を中断します。");

            }
            finally
            {

            }

        }

        #endregion

        #region"RFID書込み"

        /// <summary>
        /// RFID書込みボタンのクリックイベント
        /// </summary>
        /// <param name="sender">センダー</param>
        /// <param name="e">イベントハンドラ</param>
        private void btn_RFIDWrite_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みボタンがクリックされました。");

            decimal writeStartAddress = nud_WriteStartAddress.Value;

            string serverAddress = txb_WriteIPAddress.Text;
            string st_writeData = txb_WriteData.Text;
            string msbText = "RFIDへデータを書込みます。\r\nよろしいですか？";
            string caption = "確認";

            MessageBoxButtons msbBtn = MessageBoxButtons.OKCancel;
            MessageBoxIcon msbIcon = MessageBoxIcon.Question;
            MessageBoxDefaultButton msbDefBtn = MessageBoxDefaultButton.Button2;

            try
            {
                DialogResult dialogResult = MessageBox.Show(this, msbText, caption, msbBtn, msbIcon, msbDefBtn);

                if (dialogResult == DialogResult.OK)
                {
                    RFIDWriteReady(writeStartAddress, st_writeData, serverAddress);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n btn_RFIDWrite_Click() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

            }
            finally
            {

            }


        }

        #endregion

        #endregion

        #endregion

        #endregion

        #region"非公開メソッド"

        #region"RFID通信"

        #region"RFID接続/切断"

        #region"接続情報セット"

        /// <summary>
        /// 接続情報を更新する
        /// </summary>
        /// <param name="serverAddress_">TCPサーバー (接続先RFID) のIPアドレス</param>
        /// <param name="serverPort_ETN_">RFIDのポート番号</param>
        /// <param name="readTimeout_">読み取りタイムアウト時間</param>
        /// <param name="writeTimeout_">書き込みタイムアウト時間</param>
        /// <returns>接続情報更新完了</returns>
        private bool SetConnectionInfo(string serverAddress__, int serverPort_ETN_, int serverPort_EIP, int readTimeout_, int writeTimeout_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDへの接続情報を更新します。");

            bool ret = false;

            try
            {
                // サーバー情報を更新
                m_serverAddress = serverAddress__;
                m_serverPort = serverPort_ETN_;
                //m_serverPort = serverPort_EIP;
                m_readTimeout = readTimeout_;
                m_writeTimeout = writeTimeout_;

                ret = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDへの接続情報の更新中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n SetConnectionInfo() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDへの接続情報の更新を中断しました。");

            }
            return ret;

        }

        #endregion

        #region"RFID接続"

        /// <summary>
        /// TCPサーバーに接続する
        /// </summary>
        /// <returns>接続成功ならTrue</returns>
        private bool RFIDConnect()
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDへの接続を開始します。");

            bool ret = false;

            try
            {
                m_client = new TcpClient();

                // Modbus/TCPの場合
                // サーバーと接続
                // 接続完了するまでブロッキングする
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")}【Modbus/TCP Client】Connect() : [{m_serverAddress}:{m_serverPort}] に接続します ...");
                m_client.Connect(m_serverAddress, m_serverPort);
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")}【Modbus/TCP Client】Connect() : 接続しました");

                //// Ethernet/IPの場合
                //// サーバーと接続
                //// 接続完了するまでブロッキングする
                //Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")}【TCPClient】Connect() : [{m_serverAddress}:{m_serverPort}] に接続します ...");
                //m_client = new System.Net.Sockets.TcpClient(m_serverAddress, m_serverPort);
                //Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")}【TCPClient】Connect() : 接続しました");

                // 接続完了
                ret = true;

                // ネットワークストリームを取得
                m_tcpStream = m_client.GetStream();

                // 送受信タイムアウト時間を設定
                m_tcpStream.ReadTimeout = m_readTimeout;
                m_tcpStream.WriteTimeout = m_writeTimeout;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDへの接続中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n RFIDConnect() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDへの接続を中断します。");

            }
            return ret;

        }

        #endregion

        #region"RFID切断"

        /// <summary>
        /// TCPサーバーとの接続を切る
        /// </summary>
        public void RFIDDisconnect()
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDとの切断処理を開始します。");

            try
            {
                m_tcpStream?.Close();
                m_client?.Close();

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDとの接続を切断しました。");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDとの切断処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n RFIDDisconnect() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDとの切断処理を中断します。");

            }

        }

        #endregion

        #endregion

        #region"クエリ作成"

        #region"リードクエリ作成"

        /// <summary>
        /// リードクエリ作成
        /// </summary>
        /// <param name="readStartAddress_">RFIDの読取り先頭アドレス</param>
        /// <param name="readDataLength_">RFIDの読取りデータ長</param>
        /// <returns>クエリのバイト配列</returns>
        private byte[] MakeReadQuery(decimal readStartAddress___, decimal readDataLength_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りクエリの作成を開始します。");

            byte[] ret = null;
            byte[] data = new byte[12];

            int dataLength = 0;

            try
            {
                registerNo = BitConverter.GetBytes(((int)readStartAddress___ / 2));

                wordCount = BitConverter.GetBytes(((int)readDataLength_ / 2) + ((int)readDataLength_ % 2));

                // 例外確認
                if (readStartAddress___ % 2 == 1 && readDataLength_ % 2 == 0)
                {
                    // 読取り開始アドレスが奇数アドレス、読取りバイト数が偶数バイトの場合は例外処理
                    wordCount = BitConverter.GetBytes(((int)readDataLength_ / 2) + ((int)readDataLength_ % 2) + 1);

                }

                dataLength = registerNo.Length + wordCount.Length;

                fieldLength = new byte[] { 0x00, (byte)(1 + 1 + dataLength - 4) };

                data[0] = transactionIdentifier[0];
                data[1] = transactionIdentifier[1];
                data[2] = protocolIdentifier[0];
                data[3] = protocolIdentifier[1];
                data[4] = fieldLength[0];
                data[5] = fieldLength[1];
                data[6] = unitIdentifier[0];
                data[7] = functionCode_R[0];
                data[8] = registerNo[1];
                data[9] = registerNo[0];
                data[10] = wordCount[1];
                data[11] = wordCount[0];

                ret = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りクエリの作成中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n MakeReadQuery() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りクエリの作成を中断します。");

            }
            return ret;

        }

        #endregion

        #region"ライトクエリ作成"

        /// <summary>
        /// ライトクエリ作成
        /// </summary>
        /// <param name="writeStartAddress___">書込み先頭アドレス</param>
        /// <param name="writeDataLength_">書込みデータ長</param>
        /// <param name="writeDataArr_">書込みデータの配列</param>
        /// <param name="readResult_">読取り結果の配列</param>
        /// <param name="writeCount_">現在の書込み回数</param>
        /// <param name="writingFlag_">書込み中フラグ</param>
        /// <returns>ライトクエリのバイト配列</returns>
        private byte[] MakeWriteQuery(decimal writeStartAddress___, int writeDataLength_, byte[] writeDataArr_, byte[][] readResult_, int writeCount_, bool writingFlag_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みクエリの作成を開始します。");

            byte[] ret = null;
            byte[] data = null;

            int writeDataCount = 0;
            int dataLength = 0;
            int readAddress1 = 0;
            int readAddress2 = 0;

            int[] readAddressArr = null;

            try
            {
                // 書込みクエリ作成
                registerNo = BitConverter.GetBytes(((int)writeStartAddress___ / 2));

                wordCount = BitConverter.GetBytes((writeDataLength_ / 2) + (writeDataLength_ % 2));

                byteCount = BitConverter.GetBytes(wordCount[0] * 2);

                writeDataCount = writeDataCount + writeDataLength_;

                // 書込みデータ長が奇数バイトなら偶数バイトへ繰り上げ
                if (writeDataLength_ % 2 == 1)
                {
                    writeDataCount = writeDataCount + 1;

                }

                dataLength = registerNo.Length + wordCount.Length + writeDataCount;

                fieldLength = new byte[] { 0x00, (byte)(1 + 1 + dataLength - 4 + 1) };

                data = new byte[fieldLength[1] + 6];

                data[0] = transactionIdentifier[0];
                data[1] = transactionIdentifier[1];
                data[2] = protocolIdentifier[0];
                data[3] = protocolIdentifier[1];
                data[4] = fieldLength[0];
                data[5] = fieldLength[1];
                data[6] = unitIdentifier[0];
                data[7] = functionCode_W[0];
                data[8] = registerNo[1];
                data[9] = registerNo[0];
                data[10] = wordCount[1];
                data[11] = wordCount[0];
                data[12] = byteCount[0];

                for (int i = 0; i < writeDataCount; i++)
                {
                    // 先頭アドレスなら実行
                    if (i == 0)
                    {
                        // 先頭アドレスの偶数奇数を確認
                        if (writeStartAddress___ % 2 == 1)
                        {
                            // 書込み先頭アドレスが奇数なら

                            // 1回目の書込みか確認する
                            if (writeCount_ == 0)
                            {
                                // 1回目
                                data[i + 13] = readResult_[0][i + 9];

                            }
                            else
                            {
                                // 2回目以降
                                data[i + 13] = writeDataArr_[(i + writeCount_ * writeMaxByte) - 1];

                            }

                        }
                        else
                        {
                            // 書込み先頭アドレスが偶数なら
                            data[i + 13] = writeDataArr_[(i + writeCount_ * writeMaxByte)];

                        }

                    }
                    // 終端アドレスの場合は実行
                    else if (i == writeDataCount - 1 && writingFlag_ == false)
                    {
                        // 先頭アドレス、書込みデータ長の偶数/奇数の組み合わせを確認
                        if ((writeStartAddress___ % 2 == 0) && (writeDataLength_ % 2 == 1))
                        {
                            // 先頭アドレスが偶数アドレス　書込みデータ長が奇数バイトの場合
                            // 例　10(H) から3バイト書込む場合
                            readAddressArr = CheckLastData(i, writeCount_);

                            readAddress1 = readAddressArr[0];
                            readAddress2 = readAddressArr[1];

                            data[i + 13] = readResult_[readAddress1][readAddress2];

                        }
                        else if ((writeStartAddress___ % 2 == 1) && (writeDataLength_ % 2 == 0))
                        {
                            // 先頭アドレスが奇数アドレス　書込みデータ長が偶数バイトの場合
                            // 例　11(H) から2バイト書込む場合
                            readAddressArr = CheckLastData(i, writeCount_);

                            readAddress1 = readAddressArr[0];
                            readAddress2 = readAddressArr[1];

                            data[i + 13] = readResult_[readAddress1][readAddress2];

                        }
                        else if ((writeStartAddress___ % 2 == 1) && (writeDataLength_ % 2 == 1))
                        {
                            // 先頭アドレスが奇数アドレス　書込みデータ長が奇数バイトの場合
                            // 例　11(H) から3バイト書込む場合
                            data[i + 13] = writeDataArr_[(i + writeCount_ * writeMaxByte) - 1];

                        }
                        // それ以外
                        else
                        {
                            // 先頭アドレスが偶数アドレス　書込みデータ長が偶数バイトの場合
                            // 例　10(H) から2バイト書込む場合
                            data[i + 13] = writeDataArr_[(i + writeCount_ * writeMaxByte)];

                        }

                    }
                    // 中間データなら
                    else
                    {
                        // 先頭アドレスの偶数奇数を確認
                        if (writeStartAddress___ % 2 == 1)
                        {
                            // 書込み先頭アドレスが奇数なら
                            data[i + 13] = writeDataArr_[(i + writeCount_ * writeMaxByte) - 1];

                        }
                        else
                        {
                            // 書込み先頭アドレスが偶数なら
                            data[i + 13] = writeDataArr_[(i + writeCount_ * writeMaxByte)];

                        }

                    }

                }

                ret = data;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みクエリの作成中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n MakeWriteQuery() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みクエリの作成を中断します。");

            }

            return ret;

        }

        #endregion

        #region"異常取得クエリ作成"

        /// <summary>
        /// 異常取得クエリ作成
        /// </summary>
        /// <returns>クエリのバイト配列</returns>
        private byte[] MakeErrorQuery()
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} エラーコード取得クエリの作成を開始します。");

            byte[] ret = null;
            byte[] data = new byte[12];

            int dataLength = 0;

            try
            {
                registerNo = errorRegNo;
                wordCount = errorWordCount;

                dataLength = registerNo.Length + wordCount.Length;

                fieldLength = new byte[] { 0x00, (byte)(1 + 1 + dataLength) };

                data[0] = transactionIdentifier[0];
                data[1] = transactionIdentifier[1];
                data[2] = protocolIdentifier[0];
                data[3] = protocolIdentifier[1];
                data[4] = fieldLength[0];
                data[5] = fieldLength[1];
                data[6] = unitIdentifier[0];
                data[7] = functionCode_R[0];
                data[8] = registerNo[0];
                data[9] = registerNo[1];
                data[10] = wordCount[0];
                data[11] = wordCount[1];

                ret = data;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} エラーコード取得クエリの作成中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n MakeErrorQuery() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} エラーコード取得クエリの作成を中断します。");

            }
            return ret;

        }

        #endregion

        #endregion

        #region"RFID制御"

        #region"RFID読取り準備"

        /// <summary>
        /// RFIDのデータ読み取り前処理
        /// </summary>
        /// <param name="readStartAddress_">読取り先頭アドレス</param>
        /// <param name="readDataLength_">読取りデータ長</param>
        /// <param name="serverAddress_">読取りRFIDのIPアドレス</param>
        public void RFIDReadReady(decimal readStartAddress_, decimal readDataLength_, string serverAddress_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取り処理を開始します。");

            string msg = "";

            bool errorResponce_R = true;

            bool correctIpAddress = false;
            bool setComplete = false;
            bool connectComplete = false;

            int readCount = 0;

            int[] readInfo = null;


            byte[][] readResult = null;

            try
            {
                // IPアドレスのフォーマットを確認する
                correctIpAddress = CheckIPAddress(serverAddress_);

                // IPアドレスが正常かどうか確認する
                if (correctIpAddress == true)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} IPアドレスの入力は正常です。");

                    // 接続情報をセットする
                    setComplete = SetConnectionInfo(serverAddress_, FormMain.serverPort_ETN, FormMain.serverPort_EIP, FormMain.readTimeout, FormMain.writeTimeout);

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} IPアドレスのフォーマットに誤りがあります。");

                    msg = "IPアドレスの形式が正しくありません。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取り処理を中断します。");

                    return;

                }

                // 接続情報が登録されているか確認する
                if (setComplete == true)
                // 更新完了
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDへの接続情報の更新が完了しました。");

                    // RFIDへ接続する
                    connectComplete = RFIDConnect();

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDへの接続情報が更新されていません。");

                    msg = "RFIDへの接続情報の取得に失敗しました。\r\n管理者に連絡してください。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取り処理を中断します。");

                    return;

                }

                // RFIDと接続状態か確認する
                if (connectComplete == true)
                // 接続完了
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDに接続しました。");
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数の取得を開始します。");

                    // 読取り範囲確認
                    readDataLength_ = CheckReadDataLength(readStartAddress_, readDataLength_);

                    readInfo = new int[2];

                    // 読取り前処理
                    readInfo = GetReadInfo(readDataLength_);


                    readCount = readInfo[0];

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数を取得しました。");

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDに接続していません。");

                    msg = "RFIDとの接続に失敗しました。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取り処理を中断します。");

                    return;

                }

                // 読取り回数が"0"でないか確認する
                if (readCount != 0)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数の取得に成功しました。");

                    readResult = new byte[readCount][];

                    // RFID読取り
                    readResult = RFIDRead(readStartAddress_, readResult, readInfo);

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数が取得できませんでした。");

                    msg = "読取り情報の取得に失敗しました。\r\n管理者に連絡してください。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取り処理を中断します。");

                    return;

                }

                // 読取り結果があるか確認する
                if (readResult != null)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取りレスポンスを受信しました。");

                    // 異常確認
                    errorResponce_R = CheckErrorResponce(readResult);

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取りレスポンスを受信できませんでした。");

                    msg = "データの読取りに失敗しました。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取り処理を中断します。");

                    return;

                }

                // 異常レスポンスがないか確認する
                if (errorResponce_R == false)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り結果は正常です。");

                    // 正常完了なら読取りデータを表示
                    RFIDDataView(readStartAddress_, readDataLength_, readResult);

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取り結果にエラーが含まれます。");

                    // 異常完了ならエラーコードを表示
                    RFIDError();

                }

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取りが完了しました。");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取り処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n RFIDReadReady() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取り処理を中断します。");

            }
            finally
            {
                // 切断処理
                RFIDDisconnect();

            }

        }

        #endregion

        #region"IPアドレスの確認"

        /// <summary>
        /// 文字列がIPアドレスのフォーマットか確認する
        /// </summary>
        /// <param name="serverAddress_">サーバーのIPアドレス</param>
        /// <returns>IPアドレスに変換できればTrue</returns>
        private bool CheckIPAddress(string serverAddress__)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} IPアドレスの入力チェックを開始します。");

            bool ret = false;

            IPAddress ipAdd = null;

            try
            {
                ret = IPAddress.TryParse(serverAddress__, out ipAdd);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} IPアドレスの入力チェック中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n CheckIPAddress() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} IPアドレスの入力チェックを中断します。");

            }

            return ret;

        }

        #endregion

        #region"読取り範囲の確認"

        /// <summary>
        /// 読取り範囲がRFIDキャリアの上限を超えていないか確認
        /// </summary>
        /// <param name="readStartAddress_">読取り開始アドレス</param>
        /// <param name="readDataLength_">読取りデータ点数</param>
        /// <returns>読取りデータ点数</returns>
        private decimal CheckReadDataLength(decimal readStartAddress__, decimal readDataLength__)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りデータ長を確認します。");

            decimal ret = readDataLength__;

            int readRange = 0;

            try
            {
                // 読取り最終アドレスを計算する
                readRange = (int)readStartAddress__ + (int)readDataLength__;

                // 最終アドレスがRFIDキャリアの上限値を超えているか確認する
                if (readRange > FormMain.RFIDCarrierSize)
                {
                    // 上限値を超えている場合、読取り点数を修正する
                    readDataLength__ = FormMain.RFIDCarrierSize - readStartAddress__;
                    ret = readDataLength__;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りデータ長の確認中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n CheckReadDataLength() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りデータ長の確認を中断します。");

            }

            return ret;

        }

        #endregion

        #region"読取り情報取得"
        /// <summary>
        /// RFIDからデータを読み出す回数を算出する
        /// </summary>
        /// <param name="readDataLength_">読取りバイト数</param>
        /// <returns>読取り情報 (読取り先頭アドレス、読取り余剰バイト数)</returns>
        private int[] GetReadInfo(decimal readDataLength__)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り情報の取得を開始します。");

            int[] ret = new int[2];
            int readCount = 0;
            int remainder = 0;

            try
            {
                // 読取り回数算出
                readCount = (int)readDataLength__ / readMaxByte;
                remainder = (int)readDataLength__ % readMaxByte;

                if (remainder > 0)
                {
                    readCount = readCount + 1;

                }
                else
                {
                    remainder = readMaxByte;

                }

                ret[0] = readCount;
                ret[1] = remainder;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り情報の取得中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n GetReadInfo() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り情報の取得を中断します。");

            }

            return ret;

        }

        #endregion

        #region"RFID読取り"

        /// <summary>
        /// RFIDからデータを読み出す
        /// </summary>
        /// <param name="readStartAddress_">読取り先頭アドレス</param>
        /// <param name="result_">RFIDの読取り結果を格納する配列</param>
        /// <param name="readInfo_">読取り情報(読取り先頭アドレス、読取りバイト数)</param>
        /// <returns>RFIDからの読取り結果</returns>
        private byte[][] RFIDRead(decimal readStartAddress__, byte[][] readResult_, int[] readInfo_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りクエリの取得、送信を開始します。");

            byte[] query_Buff = null;
            byte[] recvBuff = null;

            int readCount = readInfo_[0];
            int remainder = readInfo_[1];
            decimal readDataLength = nud_ReadDataLength.Value;

            try
            {
                // 読取り開始アドレスが奇数、読取りデータ長が偶数の場合
                if (readStartAddress__ % 2 == 1 && (int)readDataLength % 2 == 0)
                {
                    // 読取り余剰を調整
                    remainder = remainder + 1;

                }

                // 読取りループ
                for (int i = 0; i < readCount; i++)
                {
                    if (i == readCount - 1)
                    {
                        // 最終読取りなら

                        // 読取りクエリ作成
                        query_Buff = MakeReadQuery(readStartAddress__, remainder);

                    }
                    else
                    {
                        // 先頭アドレスの偶数/奇数を判別
                        if (readStartAddress__ % 2 == 1)
                        {
                            // 奇数なら読取りサイズを調整

                            // 読取りクエリ作成
                            query_Buff = MakeReadQuery(readStartAddress__, readMaxByte - 1);

                            readStartAddress__ = readStartAddress__ + readMaxByte - 1;

                        }
                        else
                        {
                            // 読取りクエリ作成
                            query_Buff = MakeReadQuery(readStartAddress__, readMaxByte);

                            readStartAddress__ = readStartAddress__ + readMaxByte;

                        }

                    }

                    if (query_Buff != null)
                    {
                        Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りクエリを作成しました。");

                        // RFID　データ読取り

                        // クエリ送信
                        recvBuff = QuerySend(query_Buff);

                        Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りクエリを送信しました。");

                        if (recvBuff != null)
                        {
                            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りクエリのレスポンスを受信しました。");

                            // 取得結果を配列に格納
                            readResult_[i] = recvBuff;

                        }

                    }
                    else
                    {
                        Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りクエリの作成に失敗しました。");

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りクエリの取得、送信中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n RFIDRead() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りクエリの取得、送信を中断します。");

            }

            return readResult_;

        }

        #endregion

        #region"RFID書込み準備"

        /// <summary>
        /// RFIDへデータを書き込む回数を算出する
        /// </summary>
        /// <param name="writeDataCount_">書込みデータのデータ長</param>
        /// <returns>書込み情報 (書込み先頭アドレス、書込み余剰バイト数)</returns>
        public void RFIDWriteReady(decimal writeStartAddress_, string st_writeData_, string serverAddress_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの書込み処理を開始します。");

            string msg = "";

            string[] st_writeDataArr = null;

            bool errorResponce_R = true;
            bool errorResponce_W = true;
            bool correctWriteData = false;
            bool correctIpAddress = false;
            bool setComplete = false;
            bool connectComplete = false;

            int readCount = 0;
            int writeCount = 0;
            int writeDataCount = 0;

            int[] readInfo = null;
            int[] writeInfo = null;

            decimal readDataLength = 0;
            decimal resultDataLength = 0;

            byte[][] readResult = null;
            byte[][] writeResult = null;

            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータの入力形式を確認します。");

                // ラジオボタンの状態を確認する
                if (rdbtn_Binary.Checked == false && rdbtn_ASCII.Checked == true)
                {
                    inputMode = 1;

                }

                // ASCII入力でなければ (Binaly入力なら) 入力値を確認する
                if (inputMode != 1)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} Binaly形式です。");

                    // 書込みデータを確認する
                    correctWriteData = CheckWriteData(st_writeData_);

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} ASCII形式です。");

                    correctWriteData = true;

                }

                // 書込みデータが正常か判断する
                if (correctWriteData)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータは正常です。");

                    // IPアドレスのフォーマットを確認する
                    correctIpAddress = CheckIPAddress(serverAddress_);

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータが異常です。");

                    msg = "書込みデータが不正です。\r\n16進数に変換できません。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

                    return;

                }

                // IPアドレスが正しいか確認する
                if (correctIpAddress == true)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} IPアドレスの入力は正常です。");

                    // 接続情報をセットする
                    setComplete = SetConnectionInfo(serverAddress_, serverPort_ETN, serverPort_EIP, readTimeout, writeTimeout);

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} IPアドレスのフォーマットに誤りがあります。");

                    msg = "IPアドレスの形式が正しくありません。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

                    return;

                }

                // 接続情報がセットされているか確認する
                if (setComplete == true)
                // 更新完了
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDへの接続情報の更新が完了しました。");

                    // RFIDへ接続する
                    connectComplete = RFIDConnect();

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDへの接続情報が更新されていません。");

                    msg = "RFIDへの接続情報の取得に失敗しました。\r\n管理者に連絡してください。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

                    return;

                }

                // RFIDと接続状態か確認する
                if (connectComplete == true)
                // 接続完了
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDに接続しました。");
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数の取得を開始します。");

                    // 書込みデータの入力形式を確認する
                    if (inputMode == 1)
                    {
                        // ASCII入力なら1文字区切り
                        st_writeDataArr = new string[1];
                        st_writeDataArr[0] = st_writeData_;
                        writeDataCount = st_writeData_.Length;

                    }
                    else
                    {
                        // Binaly入力ならカンマ区切り
                        st_writeDataArr = st_writeData_.Split(separateChar);
                        writeDataCount = st_writeDataArr.Length;

                    }

                    // 先頭アドレス、書込みデータ長の偶数/奇数の組み合わせを確認
                    if ((writeStartAddress_ % 2 == 1) && (writeDataCount % 2 == 0))
                    {
                        // 先頭アドレスが奇数アドレス　書込みデータ長が偶数バイトの場合
                        // 例　11(H) から2バイト書込む場合
                        writeDataCount = writeDataCount + 2;

                    }

                    readDataLength = writeDataCount;

                    // 読取り範囲確認
                    resultDataLength = CheckReadDataLength(writeStartAddress_, writeDataCount);

                    // IDキャリアのアドレス上限オーバーを確認
                    if (resultDataLength == readDataLength)
                    {
                        // 読取り範囲がキャリアの上限を超えていなければ
                        readInfo = new int[2];

                        // 読取り前処理
                        readInfo = GetReadInfo(readDataLength);

                        readCount = readInfo[0];

                        Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数を取得しました。");

                    }
                    else
                    {
                        Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数の取得中にエラーが発生しました。");

                        msg = "書込みデータのデータ長がIDキャリアの最大アドレスを超えています。";

                        Cls_CommonFunctions.ErrorMessageView(msg);

                        Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

                        return;

                    }

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDに接続していません。");

                    msg = "RFIDとの接続に失敗しました。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

                    return;

                }

                // 読取り回数が"0"出ないことを確認する
                if (readCount != 0)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数の取得に成功しました。");

                    readResult = new byte[readCount][];

                    // RFID読取り
                    readResult = RFIDRead(writeStartAddress_, readResult, readInfo);


                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数の取得に失敗しました。");

                    msg = "読取り情報の取得に失敗しました。\r\n管理者に連絡してください。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

                    return;

                }

                // 読取り結果があるか確認する
                if (readResult != null)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取りレスポンスを受信しました。");

                    // 異常確認
                    errorResponce_R = CheckErrorResponce(readResult);

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取りレスポンスを受信できませんでした。");

                    msg = "データの読取りに失敗しました。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

                    return;

                }

                // 異常応答であるか確認する
                if (errorResponce_R == false)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り結果は正常です。");

                    writeInfo = new int[2];

                    // 書込み前処理
                    writeInfo = GetWriteInfo(writeDataCount);

                    writeCount = writeInfo[0];

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取り結果にエラーが含まれます。");

                    // 異常完了ならエラーコードを表示
                    RFIDError();

                }

                // 書込み回数が"0"でないか確認する
                if (writeCount != 0)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数の取得に成功しました。");

                    writeResult = new byte[writeCount][];

                    // RFIDにデータを書き込む
                    writeResult = RFIDWrite(writeStartAddress_, st_writeDataArr, writeInfo, writeResult, readResult);

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取り回数の取得に失敗しました。");

                    msg = "書込み情報の取得に失敗しました。\r\n管理者に連絡してください。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

                    return;

                }

                // 書込み結果があることを確認する
                if (writeResult != null)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの書込みレスポンスを受信しました。");

                    // 異常確認
                    errorResponce_W = CheckErrorResponce(writeResult);

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの読取りレスポンスを受信できませんでした。");

                    msg = "データの書込みに失敗しました。";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

                    return;

                }

                // 異常応答でないことを確認する
                if (errorResponce_W == false)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み結果は正常です。");
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みに成功しました。");

                    // 正常完了
                    MessageBox.Show("データを書込みました。");

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} RFIDの書込み結果にエラーが含まれます。");

                    // 異常完了ならエラーコードを表示
                    RFIDError();

                }

            }
            catch (Exception ex)
            {
                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n RFIDWriteReady() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

            }
            finally
            {
                // 切断処理
                RFIDDisconnect();

            }

        }

        #endregion

        #region"書込みデータの確認"

        /// <summary>
        /// 書込みデータの確認 (16進数かどうかをチェック)
        /// </summary>
        /// <param name="st_writeData_">書込みデータの入力値</param>
        /// <returns>判定結果 16進数ならTrue</returns>
        private bool CheckWriteData(string st_writeData__)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} Binaly形式の書込みデータの入力チェックを開始します。");

            bool ret = false;

            string st_writeData = st_writeData__;

            int st_writeDataLength = 0;

            try
            {
                // 書込みデータが16進数であるか確認する
                st_writeDataLength = st_writeData.Length;

                // 1～9,、A～F、a～fを 0 に変換する
                st_writeData = st_writeData.Replace(inputChar_1, '0');
                st_writeData = st_writeData.Replace(inputChar_2, '0');
                st_writeData = st_writeData.Replace(inputChar_3, '0');
                st_writeData = st_writeData.Replace(inputChar_4, '0');
                st_writeData = st_writeData.Replace(inputChar_5, '0');
                st_writeData = st_writeData.Replace(inputChar_6, '0');
                st_writeData = st_writeData.Replace(inputChar_7, '0');
                st_writeData = st_writeData.Replace(inputChar_8, '0');
                st_writeData = st_writeData.Replace(inputChar_9, '0');
                st_writeData = st_writeData.Replace(inputChar_A, '0');
                st_writeData = st_writeData.Replace(inputChar_B, '0');
                st_writeData = st_writeData.Replace(inputChar_C, '0');
                st_writeData = st_writeData.Replace(inputChar_D, '0');
                st_writeData = st_writeData.Replace(inputChar_E, '0');
                st_writeData = st_writeData.Replace(inputChar_F, '0');
                st_writeData = st_writeData.Replace(inputChar_a, '0');
                st_writeData = st_writeData.Replace(inputChar_b, '0');
                st_writeData = st_writeData.Replace(inputChar_c, '0');
                st_writeData = st_writeData.Replace(inputChar_d, '0');
                st_writeData = st_writeData.Replace(inputChar_e, '0');
                st_writeData = st_writeData.Replace(inputChar_f, '0');
                st_writeData = st_writeData.Replace(separateChar, '0');

                // 元の文字列の文字数から 0 以外の文字数を引き算
                st_writeDataLength = st_writeData__.Length - st_writeData.Replace(inputChar_0.ToString(), "").Length;

                // 16進数に変換できない文字が含まれているか確認する
                if (st_writeDataLength == st_writeData__.Length)
                {
                    // 一致すれば16進数変換可
                    ret = true;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} Binaly形式の書込みデータの入力チェック中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n CheckWriteData() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} Binaly形式の書込みデータの入力チェックを中断します。");

            }

            return ret;

        }

        #endregion

        #region"書込み情報取得"

        /// <summary>
        /// RFIDへデータを書き込む回数を取得する
        /// </summary>
        /// <param name="writeDataCount_">書込みデータのデータ長</param>
        /// <returns>書込み情報 (書込み先頭アドレス、書込み余剰バイト数)</returns>
        private int[] GetWriteInfo(int writeDataCount_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み情報の取得を開始します。");

            int writeCount = 0;
            int remainder = 1;

            int[] ret = new int[2];

            try
            {
                // 書込み回数算出
                writeCount = writeDataCount_ / writeMaxByte;
                remainder = writeDataCount_ % writeMaxByte;

                if (remainder > 0)
                {
                    writeCount = writeCount + 1;

                }

                ret[0] = writeCount;
                ret[1] = remainder;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み情報の取得中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n GetWriteInfo() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み情報の取得を中断します。");

            }

            return ret;

        }

        #endregion

        #region"RFID書込み"

        /// <summary>
        /// RFIDにデータを書き込む
        /// </summary>
        /// <param name="writeStartAddress__">書込み先頭アドレス</param>
        /// <param name="st_writeDataArr_">書込みデータの文字列配列</param>
        /// <param name="writeInfo_">書込み情報 (書込み回数 / 書込みデータの余剰データ長)</param>
        /// <param name="writeResult_">書込み結果を格納する配列</param>
        /// <param name="readResult_">読取り結果の配列</param>
        /// <returns>書込み結果のバイト配列</returns>
        private byte[][] RFIDWrite(decimal writeStartAddress__, string[] st_writeDataArr_, int[] writeInfo_, byte[][] writeResult_, byte[][] readResult_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みクエリの取得、送信を開始します。");

            byte[][] ret = null;

            bool writingFlag = false;

            int writeCount = writeInfo_[0];
            int remainder = writeInfo_[1];

            string msg = "";

            byte[] writeDataArr = null;
            byte[] query_Buff = null;
            byte[] recvBuff = null;

            try
            {
                if (inputMode == 1)
                {
                    // 書込みデータの型を変換する　(ASCII文字列 → byte配列)
                    writeDataArr = ASCIIDataChange(st_writeDataArr_);

                }
                else
                {
                    // 書込みデータの型を変換する　(Binaly文字列 → byte配列)
                    writeDataArr = BinalyDataChange(st_writeDataArr_);

                }

                if (writeDataArr != null)
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータの型変換に成功しました。");

                    // 書込みループ
                    for (int currentWriteCount = 0; currentWriteCount < writeCount; currentWriteCount++)
                    {
                        writingFlag = true;

                        if (currentWriteCount == writeCount - 1)
                        {
                            // 最終書込みなら
                            writingFlag = false;

                            // 書込みクエリ作成
                            query_Buff = MakeWriteQuery(writeStartAddress__, remainder, writeDataArr, readResult_, currentWriteCount, writingFlag);

                        }
                        else
                        {
                            // 書込みクエリ作成
                            query_Buff = MakeWriteQuery(writeStartAddress__, writeMaxByte, writeDataArr, readResult_, currentWriteCount, writingFlag);

                            // 書込みアドレス更新
                            writeStartAddress__ = writeStartAddress__ + writeMaxByte;

                        }

                        if (query_Buff != null)
                        {
                            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みクエリの取得に成功しました。");

                            // RFID　データ書込み

                            // クエリ送信
                            recvBuff = QuerySend(query_Buff);

                            if (recvBuff != null)
                            {
                                // 取得結果を配列に格納
                                writeResult_[currentWriteCount] = recvBuff;

                            }

                        }

                    }

                }
                else
                {
                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータに誤りがあります。");

                    msg = "書込みデータが不正です。データを確認してください。\r\n入力可能文字：半角英数字　0～9、A～F (大文字 / 小文字問わず)\r\n　　　　　　　','　(カンマ) (区切り文字として使用) \r\n入力可能範囲：00～FF (H)";

                    Cls_CommonFunctions.ErrorMessageView(msg);

                    Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込み処理を中断します。");

                }

                ret = writeResult_;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みクエリの取得、送信中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n RFIDWrite() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みクエリの取得、送信を中断します。");

            }

            return ret;

        }

        #endregion

        #region"Binaly文字列の型変換"

        /// <summary>
        /// Binaly文字列を変換する (string[] → byte[])
        /// </summary>
        /// <param name="st_writeDataArr__">書込みデータの文字列配列</param>
        /// <returns>書込みデータのバイト配列</returns>
        private byte[] BinalyDataChange(string[] st_writeDataArr__)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータの型変換 (ASCII → Byte) を開始します。");

            int i_writeData = 0;

            byte[] writeDataArr = new byte[st_writeDataArr__.Length];
            byte[] ret = null;

            try
            {
                for (int i = 0; i < st_writeDataArr__.Length; i++)
                {
                    // 文字列の16進数をIntに変換
                    i_writeData = Convert.ToInt32(st_writeDataArr__[i], 16);

                    // 1バイトのデータか確認する
                    if (i_writeData <= 255)
                    {
                        // 1バイトなら配列に格納
                        writeDataArr[i] = (byte)i_writeData;

                    }
                    else
                    {
                        // 1バイトより大きい場合は異常
                        return ret;

                    }
                }

                ret = writeDataArr;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータの型変換 (ASCII → Byte) 中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n WriteDataTypeChange() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータの型変換 (ASCII → Byte) を中断します。");

            }

            return ret;

        }

        #endregion

        #region"ASCII文字列の型変換"

        /// <summary>
        /// ASCII文字列を変換する
        /// </summary>
        /// <param name="st_writeDataArr__">書込み文字</param>
        /// <returns>書込みデータのbyte配列</returns>
        private byte[] ASCIIDataChange(string[] st_writeDataArr__)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータの型変換 (ASCII → Byte) を開始します。");

            int i_writeData = 0;
            int loopCount = 0;

            string st_WriteData = string.Join(" ", st_writeDataArr__);

            byte[] writeDataArr = new byte[st_WriteData.Length];
            byte[] ret = null;

            try
            {
                foreach (char c in st_WriteData)
                {
                    // 文字をIntに変換　(char →　Int)
                    i_writeData = ((int)c);

                    // 1バイトのデータか確認する
                    if (i_writeData <= 255)
                    {
                        // 1バイトなら配列に格納
                        writeDataArr[loopCount] = (byte)i_writeData;

                    }
                    else
                    {
                        // 1バイトより大きい場合は異常
                        return ret;

                    }

                    loopCount = loopCount + 1;

                }

                ret = writeDataArr;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータの型変換 (ASCII → Byte) 中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n ASCIIDataChange() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みデータの型変換 (ASCII → Byte) を中断します。");

            }

            return ret;

        }

        #endregion

        #region"終端データの確認"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i_">ループカウンタ (書込みデータの余剰データ長)</param>
        /// <param name="writeCount__">現在の書込み回数</param>
        /// <returns>終端データの読取りアドレスの配列</returns>
        private int[] CheckLastData(int i_, int writeCount__)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みクエリの終端データの確認処理を開始します。");

            int currentAddress = 0;
            int readAddress1 = 0;
            int readAddress2 = 0;


            int[] readAddressArr = new int[2];
            int[] ret = null;

            try
            {
                currentAddress = i_ + writeCount__ * writeMaxByte;

                readAddress1 = currentAddress / readMaxByte;

                readAddress2 = (i_ + writeCount__ * writeMaxByte) + 9;

                // 読取り範囲を超過しているか確認する
                if (readAddress2 > 259)
                {
                    readAddress2 = readAddress2 - readAddress1 * readMaxByte;

                }

                readAddressArr[0] = readAddress1;
                readAddressArr[1] = readAddress2;

                ret = readAddressArr;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みクエリの終端データの確認処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n CheckLastData() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 書込みクエリの終端データの確認処理を中断します。");

            }

            return ret;

        }

        #endregion

        #region"クエリ送受信"

        /// <summary>
        /// クエリを送信し、レスポンスを受信する
        /// </summary>
        /// <param name="query_Buff_">送信するクエリのバイト配列</param>
        /// <returns>受信したレスポンスのバイト配列</returns>
        private byte[] QuerySend(byte[] query_Buff_)
        {
            byte[] recvBuff = null;
            byte[] ret = null;

            try
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} クエリの送信を開始します。");

                // クエリ送信
                m_tcpStream.Write(query_Buff_, 0, query_Buff_.Length);

                // レスポンス受信
                recvBuff = new byte[m_client.ReceiveBufferSize];
                m_tcpStream.Read(recvBuff, 0, recvBuff.Length);

                ret = recvBuff;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} クエリの送信中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n QuerySend() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} クエリの送信を中断します。");

            }

            return ret;

        }

        #endregion

        #region"エラーレスポンス確認"

        /// <summary>
        /// 実行クエリの異常レスポンスを確認
        /// </summary>
        /// <param name="result_">RFIDからのレスポンスバイト配列</param>
        /// <returns>正常完了ならFalse</returns>
        private bool CheckErrorResponce(byte[][] result_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 例外コードの取得を開始します。");

            bool ret = true;

            try
            {
                // 異常レスポンス確認
                for (int i = 0; i < result_.Length; i++)
                {
                    if (result_[i][7] > 128)
                    {
                        ret = true;
                        return ret;

                    }

                }

                ret = false;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 例外コードの取得中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n CheckErrorResponce() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 例外コードの取得を中断します。");

            }

            return ret;

        }
        #endregion

        #region"RFID異常表示"

        /// <summary>
        /// RFIDの異常情報を取得する
        /// </summary>
        private void RFIDError()
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} エラーコードの取得を開始します。");

            byte[] recvBuff = null;
            byte[] query_Buff_ = null;
            byte[] errorCode = new byte[4];

            byte[][] result_ = null;

            try
            {
                // 異常発生なら警告表示

                // 読取りクエリ作成
                query_Buff_ = MakeErrorQuery();

                if (query_Buff_ != null)
                {
                    // クエリ送信
                    recvBuff = QuerySend(query_Buff_);

                    if (recvBuff != null)
                    {
                        result_ = new byte[1][];

                        // 取得結果を配列に格納
                        result_[0] = recvBuff;

                        errorCode[0] = recvBuff[17];
                        errorCode[1] = recvBuff[18];
                        errorCode[2] = recvBuff[19];
                        errorCode[3] = recvBuff[20];

                        exceptionCode = recvBuff[21];

                        string stErrorCode2 = string.Format("{0:X2}", errorCode[1]);

                        string msg = string.Format("IDキャリア読取り中に異常が発生しました。\r\n例外コード{0}\r\nエラーコード{1}{2}", string.Format("{0:X2}", exceptionCode), string.Format("{0:X2}", errorCode[0]), string.Format("{0:X2}", errorCode[1]));

                        // 異常のメッセージを表示
                        Cls_CommonFunctions.ErrorMessageView(msg);

                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} エラーコードの取得中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n RFIDError() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} エラーコードの取得を中断します。");

            }

        }

        #endregion

        #region"RFID読取りデータ表示"

        /// <summary>
        /// RFIDの読取りデータを表示する
        /// </summary>
        /// <param name="readStartAddress_">読取り開始アドレス</param>
        /// <param name="readDataLength_">読取りデータ長</param>
        /// <param name="readResult_">読取りデータを格納する配列</param>
        public void RFIDDataView(decimal readStartAddress__, decimal readDataLength__, byte[][] readResult_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りデータの表示処理を開始します。");

            string h_ResultAddress = "";
            string st_readValueBinaly = "";
            string st_readValueAscii = "";

            byte readValue = 0X00;

            byte[] b_Ascii = new byte[1];

            int d_ResultAddress = (int)nud_ReadStartAddress.Value;
            int resultAddress1 = 0;
            int resultAddress2 = 0;

            try
            {
                // 読取りバイト数が奇数ならループ回数を調整
                if (((int)readStartAddress__ % 2 == 1))
                {
                    readDataLength__ = readDataLength__ + 1;
                }

                resultAddress2 = resultAddress2 + 9;

                // 16進数変換
                for (int i = 1; i <= (int)readDataLength__; i++)
                {
                    // 読取りアドレスを16進数変換
                    h_ResultAddress = d_ResultAddress.ToString("X");

                    // データの取得位置を計算
                    resultAddress1 = (i - 1) / readMaxByte;

                    // IDの読出しデータを取得
                    readValue = readResult_[resultAddress1][resultAddress2];

                    // 読取りデータを16進数変換
                    st_readValueBinaly = readValue.ToString("X");

                    // BinaryをASCIIへ変換する
                    b_Ascii[0] = readValue;
                    st_readValueAscii = Encoding.GetEncoding("shift-jis").GetString(b_Ascii);

                    // 初回かつデータ出力の読取り開始アドレスが奇数なら出力しない (アドレス調整のため)
                    if (!(i == 1 && readStartAddress__ % 2 == 1))
                    {
                        // 上記以外は出力する

                        // グリッドに行を追加
                        DGV_ReadData.Rows.Add(d_ResultAddress, h_ResultAddress, st_readValueBinaly, st_readValueAscii);

                        // オフセットをずらす
                        d_ResultAddress = d_ResultAddress + 1;

                    }

                    resultAddress2 = resultAddress2 + 1;

                    // 読取り範囲が250バイト以上か確認する
                    if (i % readMaxByte == 0)
                    {
                        // 250バイトごとに読取り位置をオフセット
                        // 読取り開始アドレスが偶数なら
                        resultAddress2 = resultAddress2 - readMaxByte;

                    }

                }

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りデータの表示が完了しました。");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りデータの表示処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n RFIDDataView() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りデータの表示処理を中断します。");

            }

        }

        #endregion

        #endregion

        #endregion

        #region"CSVファイル出力準備"

        /// <summary>
        /// CSVファイル出力準備
        /// </summary>
        /// <param name="savePath_">保存先パス</param>
        private void OutputCSVReady(string savePath_)
        {
            Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りデータのCSV出力処理を開始します。");

            string[] rowData = null;

            string[][] outputData = null;

            int dgvRowCount = 0;

            try
            {
                dgvRowCount = DGV_ReadData.Rows.Count;

                outputData = new string[dgvRowCount][];

                for (int i = 0; i < dgvRowCount; i++)
                {
                    if (i == 0)
                    {
                        rowData = new string[3];

                        // ヘッダー情報書込み
                        rowData[0] = "ReadAddress (Decimal)";
                        rowData[1] = "ReadAddress (Hex)";
                        rowData[2] = "ReadData (Hex)";

                    }
                    else
                    {
                        rowData = new string[3];

                        for (int j = 0; j < 3; j++)
                        {
                            // DataGridViewの値を配列に格納
                            rowData[j] = DGV_ReadData.Rows[i - 1].Cells[j].Value.ToString();

                        }

                    }

                    outputData[i] = rowData;

                }

                // CSVファイル出力
                Cls_CommonFunctions.OutputCSV(savePath_, outputData);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りデータのCSV出力処理中にエラーが発生しました。");

                // 異常表示
                errMsg = "エラーが発生しました。管理者へ連絡してください。" + "\r\n \r\n OutputCSVReady() \r\n" + ex.Message;

                Cls_CommonFunctions.ErrorMessageView(errMsg);

                Console.WriteLine($"{System.DateTime.Now.ToString("[yyyy/MM/dd HH:mm:ss]")} 読取りデータのCSV出力処理を中断します。");

            }

        }

        #endregion

        #endregion

    }

}
