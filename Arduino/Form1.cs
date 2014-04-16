using Firmata.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino
{
    public partial class Form1 : Form
    {
        private ArduinoConnect arduinoC;
        private bool isConnectSuccess = false;
        private int startGameDigitalPin = 8; //開始按鈕
        private int infraredAnalogPin = 0; //紅外線數值

        private bool isGameStart = false;
        int counter = 60;
        int score = 0;
        int highScore = 0;

        public Form1()
        {
            InitializeComponent();

            InitSevenSegment();

            this.Text = "Scoreboard"; //標題
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //無邊框

            timer1.Interval = 1000; // 設定每秒觸發一次
            timer1.Enabled = true; // 啟動 Timer

            try
            {
                arduinoC = new ArduinoConnect("COM2", 57600);      // New a Arduino Object
                arduinoC.Open(); // Open COM Port
                isConnectSuccess = true;

                //arduinoC.pinMode(11, ArduinoConnect.INPUT);
            }
            catch
            {
            }

            //PlayMusic("1.mp3", "play");

        }

        private void InitSevenSegment()
        {
            counter = 60;
            //ss_TimeTens.DecimalShow = true;
            //ss_TimeTens.DecimalOn = true;
            ss_TimeTens.Value = (counter / 10).ToString();
            ss_TimeOnes.Value = (counter % 10).ToString();

            score = 0;
            ss_ScoreHundreds.Value = "0";
            ss_ScoreTens.Value = "0";
            ss_ScoreOnes.Value = "0";

            ss_HightScoreHundreds.Value = (highScore / 10).ToString();
            ss_HightScoreTens.Value = (highScore / 10).ToString();
            ss_HightScoreOnes.Value = (highScore / 10).ToString();

            ss_Round.Value = "1";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (arduinoC.digitalRead(startGameDigitalPin) == 1)
            {
                isGameStart = true;
                InitSevenSegment();
            }

            if (counter <= 0)
                isGameStart = false;

            if (isGameStart)
            {
                counter--;
                ss_TimeTens.Value = (counter / 10).ToString();
                ss_TimeOnes.Value = (counter % 10).ToString();

                if (arduinoC.analogRead(infraredAnalogPin) >= 10)
                {
                    if (counter > 15)
                        score += 2;
                    else if (counter > 0)
                        score += 3;
                }
            }
            else if (score >= highScore)
                highScore = score;
        }

        #region 移動視窗
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public const int WM_SYSCOMMAND = 0X0112;
        public const int SC_MOVE = 0XF010;
        public const int HTCAPTION = 0X0002;

        private void Form1_MouseDown(object sender, MouseEventArgs e) //滑鼠按下
        {
            //if (e.Y > 65)
            //    return;

            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) //滑鼠移動
        {
            //if (e.Y < 65)
            this.Cursor = Cursors.SizeAll;
            //else
            //    this.Cursor = Cursors.Default;
        }
        #endregion

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (isConnectSuccess)
                    arduinoC.Close();

                this.Close();
            }
        }


        #region 撥放音樂
        [DllImport("winmm.dll")]
        public static extern int mciSendString(string m_strCmd, string m_strReceive, int m_v1, int m_v2);

        [DllImport("Kernel32", CharSet = CharSet.Auto)]
        static extern Int32 GetShortPathName(String path, StringBuilder shortPath, Int32 shortPathLength);

        /// <summary>
        /// 使用 WindowsAPI 中的 mciSendString 播放音樂
        /// </summary>
        /// <param name="name">檔案名稱</param>
        /// <param name="command">命令 = play / pause / stop</param>
        private static void PlayMusic(string name, string command)
        {
            StringBuilder shortpath = new StringBuilder();
            int result = GetShortPathName(name, shortpath, shortpath.Capacity);
            name = shortpath.ToString();
            string buf = string.Empty;

            mciSendString(command + " " + name, buf, buf.Length, 0); //播放 
        }
        #endregion
    }
}
