namespace Arduino
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ss_Round = new Arduino.SevenSegment();
            this.ss_HightScoreOnes = new Arduino.SevenSegment();
            this.ss_HightScoreTens = new Arduino.SevenSegment();
            this.ss_HightScoreHundreds = new Arduino.SevenSegment();
            this.ss_ScoreOnes = new Arduino.SevenSegment();
            this.ss_ScoreTens = new Arduino.SevenSegment();
            this.ss_ScoreHundreds = new Arduino.SevenSegment();
            this.ss_TimeOnes = new Arduino.SevenSegment();
            this.ss_TimeTens = new Arduino.SevenSegment();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(241, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "High Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(159, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Round";
            // 
            // ss_Round
            // 
            this.ss_Round.ColorBackground = System.Drawing.Color.Transparent;
            this.ss_Round.ColorDark = System.Drawing.Color.Transparent;
            this.ss_Round.ColorLight = System.Drawing.Color.Red;
            this.ss_Round.CustomPattern = 0;
            this.ss_Round.DecimalOn = false;
            this.ss_Round.DecimalShow = true;
            this.ss_Round.ElementWidth = 10;
            this.ss_Round.ItalicFactor = 0F;
            this.ss_Round.Location = new System.Drawing.Point(72, 15);
            this.ss_Round.Name = "ss_Round";
            this.ss_Round.Padding = new System.Windows.Forms.Padding(4);
            this.ss_Round.Size = new System.Drawing.Size(19, 28);
            this.ss_Round.TabIndex = 12;
            this.ss_Round.TabStop = false;
            this.ss_Round.Value = null;
            // 
            // ss_HightScoreOnes
            // 
            this.ss_HightScoreOnes.ColorBackground = System.Drawing.Color.Transparent;
            this.ss_HightScoreOnes.ColorDark = System.Drawing.Color.Transparent;
            this.ss_HightScoreOnes.ColorLight = System.Drawing.Color.Red;
            this.ss_HightScoreOnes.CustomPattern = 0;
            this.ss_HightScoreOnes.DecimalOn = false;
            this.ss_HightScoreOnes.DecimalShow = true;
            this.ss_HightScoreOnes.ElementWidth = 10;
            this.ss_HightScoreOnes.ItalicFactor = 0F;
            this.ss_HightScoreOnes.Location = new System.Drawing.Point(340, 145);
            this.ss_HightScoreOnes.Name = "ss_HightScoreOnes";
            this.ss_HightScoreOnes.Padding = new System.Windows.Forms.Padding(4);
            this.ss_HightScoreOnes.Size = new System.Drawing.Size(32, 64);
            this.ss_HightScoreOnes.TabIndex = 7;
            this.ss_HightScoreOnes.TabStop = false;
            this.ss_HightScoreOnes.Value = null;
            // 
            // ss_HightScoreTens
            // 
            this.ss_HightScoreTens.ColorBackground = System.Drawing.Color.Transparent;
            this.ss_HightScoreTens.ColorDark = System.Drawing.Color.Transparent;
            this.ss_HightScoreTens.ColorLight = System.Drawing.Color.Red;
            this.ss_HightScoreTens.CustomPattern = 0;
            this.ss_HightScoreTens.DecimalOn = false;
            this.ss_HightScoreTens.DecimalShow = true;
            this.ss_HightScoreTens.ElementWidth = 10;
            this.ss_HightScoreTens.ItalicFactor = 0F;
            this.ss_HightScoreTens.Location = new System.Drawing.Point(302, 145);
            this.ss_HightScoreTens.Name = "ss_HightScoreTens";
            this.ss_HightScoreTens.Padding = new System.Windows.Forms.Padding(4);
            this.ss_HightScoreTens.Size = new System.Drawing.Size(32, 64);
            this.ss_HightScoreTens.TabIndex = 6;
            this.ss_HightScoreTens.TabStop = false;
            this.ss_HightScoreTens.Value = null;
            // 
            // ss_HightScoreHundreds
            // 
            this.ss_HightScoreHundreds.ColorBackground = System.Drawing.Color.Transparent;
            this.ss_HightScoreHundreds.ColorDark = System.Drawing.Color.Transparent;
            this.ss_HightScoreHundreds.ColorLight = System.Drawing.Color.Red;
            this.ss_HightScoreHundreds.CustomPattern = 0;
            this.ss_HightScoreHundreds.DecimalOn = false;
            this.ss_HightScoreHundreds.DecimalShow = true;
            this.ss_HightScoreHundreds.ElementWidth = 10;
            this.ss_HightScoreHundreds.ItalicFactor = 0F;
            this.ss_HightScoreHundreds.Location = new System.Drawing.Point(264, 145);
            this.ss_HightScoreHundreds.Name = "ss_HightScoreHundreds";
            this.ss_HightScoreHundreds.Padding = new System.Windows.Forms.Padding(4);
            this.ss_HightScoreHundreds.Size = new System.Drawing.Size(32, 64);
            this.ss_HightScoreHundreds.TabIndex = 5;
            this.ss_HightScoreHundreds.TabStop = false;
            this.ss_HightScoreHundreds.Value = null;
            // 
            // ss_ScoreOnes
            // 
            this.ss_ScoreOnes.ColorBackground = System.Drawing.Color.Transparent;
            this.ss_ScoreOnes.ColorDark = System.Drawing.Color.Transparent;
            this.ss_ScoreOnes.ColorLight = System.Drawing.Color.Red;
            this.ss_ScoreOnes.CustomPattern = 0;
            this.ss_ScoreOnes.DecimalOn = false;
            this.ss_ScoreOnes.DecimalShow = true;
            this.ss_ScoreOnes.ElementWidth = 10;
            this.ss_ScoreOnes.ItalicFactor = 0F;
            this.ss_ScoreOnes.Location = new System.Drawing.Point(106, 145);
            this.ss_ScoreOnes.Name = "ss_ScoreOnes";
            this.ss_ScoreOnes.Padding = new System.Windows.Forms.Padding(4);
            this.ss_ScoreOnes.Size = new System.Drawing.Size(32, 64);
            this.ss_ScoreOnes.TabIndex = 4;
            this.ss_ScoreOnes.TabStop = false;
            this.ss_ScoreOnes.Value = null;
            // 
            // ss_ScoreTens
            // 
            this.ss_ScoreTens.ColorBackground = System.Drawing.Color.Transparent;
            this.ss_ScoreTens.ColorDark = System.Drawing.Color.Transparent;
            this.ss_ScoreTens.ColorLight = System.Drawing.Color.Red;
            this.ss_ScoreTens.CustomPattern = 0;
            this.ss_ScoreTens.DecimalOn = false;
            this.ss_ScoreTens.DecimalShow = true;
            this.ss_ScoreTens.ElementWidth = 10;
            this.ss_ScoreTens.ItalicFactor = 0F;
            this.ss_ScoreTens.Location = new System.Drawing.Point(68, 145);
            this.ss_ScoreTens.Name = "ss_ScoreTens";
            this.ss_ScoreTens.Padding = new System.Windows.Forms.Padding(4);
            this.ss_ScoreTens.Size = new System.Drawing.Size(32, 64);
            this.ss_ScoreTens.TabIndex = 3;
            this.ss_ScoreTens.TabStop = false;
            this.ss_ScoreTens.Value = null;
            // 
            // ss_ScoreHundreds
            // 
            this.ss_ScoreHundreds.ColorBackground = System.Drawing.Color.Transparent;
            this.ss_ScoreHundreds.ColorDark = System.Drawing.Color.Transparent;
            this.ss_ScoreHundreds.ColorLight = System.Drawing.Color.Red;
            this.ss_ScoreHundreds.CustomPattern = 0;
            this.ss_ScoreHundreds.DecimalOn = false;
            this.ss_ScoreHundreds.DecimalShow = true;
            this.ss_ScoreHundreds.ElementWidth = 10;
            this.ss_ScoreHundreds.ItalicFactor = 0F;
            this.ss_ScoreHundreds.Location = new System.Drawing.Point(30, 145);
            this.ss_ScoreHundreds.Name = "ss_ScoreHundreds";
            this.ss_ScoreHundreds.Padding = new System.Windows.Forms.Padding(4);
            this.ss_ScoreHundreds.Size = new System.Drawing.Size(32, 64);
            this.ss_ScoreHundreds.TabIndex = 2;
            this.ss_ScoreHundreds.TabStop = false;
            this.ss_ScoreHundreds.Value = null;
            // 
            // ss_TimeOnes
            // 
            this.ss_TimeOnes.ColorBackground = System.Drawing.Color.Transparent;
            this.ss_TimeOnes.ColorDark = System.Drawing.Color.Transparent;
            this.ss_TimeOnes.ColorLight = System.Drawing.Color.Red;
            this.ss_TimeOnes.CustomPattern = 0;
            this.ss_TimeOnes.DecimalOn = false;
            this.ss_TimeOnes.DecimalShow = true;
            this.ss_TimeOnes.ElementWidth = 10;
            this.ss_TimeOnes.ItalicFactor = 0F;
            this.ss_TimeOnes.Location = new System.Drawing.Point(203, 46);
            this.ss_TimeOnes.Name = "ss_TimeOnes";
            this.ss_TimeOnes.Padding = new System.Windows.Forms.Padding(4);
            this.ss_TimeOnes.Size = new System.Drawing.Size(32, 64);
            this.ss_TimeOnes.TabIndex = 1;
            this.ss_TimeOnes.TabStop = false;
            this.ss_TimeOnes.Value = null;
            // 
            // ss_TimeTens
            // 
            this.ss_TimeTens.ColorBackground = System.Drawing.Color.Transparent;
            this.ss_TimeTens.ColorDark = System.Drawing.Color.Transparent;
            this.ss_TimeTens.ColorLight = System.Drawing.Color.Red;
            this.ss_TimeTens.CustomPattern = 0;
            this.ss_TimeTens.DecimalOn = false;
            this.ss_TimeTens.DecimalShow = true;
            this.ss_TimeTens.ElementWidth = 10;
            this.ss_TimeTens.ItalicFactor = 0F;
            this.ss_TimeTens.Location = new System.Drawing.Point(165, 46);
            this.ss_TimeTens.Name = "ss_TimeTens";
            this.ss_TimeTens.Padding = new System.Windows.Forms.Padding(4);
            this.ss_TimeTens.Size = new System.Drawing.Size(32, 64);
            this.ss_TimeTens.TabIndex = 0;
            this.ss_TimeTens.TabStop = false;
            this.ss_TimeTens.Value = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(406, 229);
            this.Controls.Add(this.ss_Round);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ss_HightScoreOnes);
            this.Controls.Add(this.ss_HightScoreTens);
            this.Controls.Add(this.ss_HightScoreHundreds);
            this.Controls.Add(this.ss_ScoreOnes);
            this.Controls.Add(this.ss_ScoreTens);
            this.Controls.Add(this.ss_ScoreHundreds);
            this.Controls.Add(this.ss_TimeOnes);
            this.Controls.Add(this.ss_TimeTens);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SevenSegment ss_TimeTens;
        private System.Windows.Forms.Timer timer1;
        private SevenSegment ss_TimeOnes;
        private SevenSegment ss_ScoreHundreds;
        private SevenSegment ss_ScoreTens;
        private SevenSegment ss_ScoreOnes;
        private SevenSegment ss_HightScoreOnes;
        private SevenSegment ss_HightScoreTens;
        private SevenSegment ss_HightScoreHundreds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private SevenSegment ss_Round;




    }
}

