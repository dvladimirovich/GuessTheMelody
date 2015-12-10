namespace GuessTheMelody
{
    partial class FrmGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblCounter1 = new System.Windows.Forms.Label();
            this.lblCounter2 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblSongsCounter = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMusicDuration = new System.Windows.Forms.Label();
            this.lblSongsCountTxt = new System.Windows.Forms.Label();
            this.lblMusicDurTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(140, 204);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(205, 51);
            this.WMP.TabIndex = 0;
            this.WMP.Visible = false;
            this.WMP.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.WMP_OpenStateChange);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(12, 290);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(122, 43);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayer1.Location = new System.Drawing.Point(12, 9);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(125, 33);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Игрок 1";
            this.lblPlayer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPlayer2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPlayer2.Location = new System.Drawing.Point(227, 9);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(125, 33);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "Игрок 2";
            this.lblPlayer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCounter1
            // 
            this.lblCounter1.AutoSize = true;
            this.lblCounter1.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCounter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCounter1.Location = new System.Drawing.Point(58, 58);
            this.lblCounter1.Name = "lblCounter1";
            this.lblCounter1.Size = new System.Drawing.Size(32, 33);
            this.lblCounter1.TabIndex = 2;
            this.lblCounter1.Text = "0";
            this.lblCounter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCounter2
            // 
            this.lblCounter2.AutoSize = true;
            this.lblCounter2.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCounter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCounter2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCounter2.Location = new System.Drawing.Point(275, 58);
            this.lblCounter2.Name = "lblCounter2";
            this.lblCounter2.Size = new System.Drawing.Size(32, 33);
            this.lblCounter2.TabIndex = 2;
            this.lblCounter2.Text = "0";
            this.lblCounter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPause.Location = new System.Drawing.Point(140, 290);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(68, 43);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContinue.Location = new System.Drawing.Point(214, 290);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(138, 43);
            this.btnContinue.TabIndex = 3;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblSongsCounter
            // 
            this.lblSongsCounter.AutoSize = true;
            this.lblSongsCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblSongsCounter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSongsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSongsCounter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSongsCounter.Location = new System.Drawing.Point(176, 110);
            this.lblSongsCounter.Name = "lblSongsCounter";
            this.lblSongsCounter.Size = new System.Drawing.Size(32, 33);
            this.lblSongsCounter.TabIndex = 2;
            this.lblSongsCounter.Text = "0";
            this.lblSongsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 261);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(339, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 50;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMusicDuration
            // 
            this.lblMusicDuration.AutoSize = true;
            this.lblMusicDuration.BackColor = System.Drawing.Color.Transparent;
            this.lblMusicDuration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblMusicDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMusicDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMusicDuration.Location = new System.Drawing.Point(176, 149);
            this.lblMusicDuration.Name = "lblMusicDuration";
            this.lblMusicDuration.Size = new System.Drawing.Size(32, 33);
            this.lblMusicDuration.TabIndex = 2;
            this.lblMusicDuration.Text = "0";
            this.lblMusicDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSongsCountTxt
            // 
            this.lblSongsCountTxt.AutoSize = true;
            this.lblSongsCountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSongsCountTxt.Location = new System.Drawing.Point(52, 119);
            this.lblSongsCountTxt.Name = "lblSongsCountTxt";
            this.lblSongsCountTxt.Size = new System.Drawing.Size(118, 16);
            this.lblSongsCountTxt.TabIndex = 4;
            this.lblSongsCountTxt.Text = "Осталось песен: ";
            // 
            // lblMusicDurTxt
            // 
            this.lblMusicDurTxt.AutoSize = true;
            this.lblMusicDurTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMusicDurTxt.Location = new System.Drawing.Point(12, 158);
            this.lblMusicDurTxt.Name = "lblMusicDurTxt";
            this.lblMusicDurTxt.Size = new System.Drawing.Size(158, 16);
            this.lblMusicDurTxt.TabIndex = 4;
            this.lblMusicDurTxt.Text = "Длительность музыки: ";
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuessTheMelody.Properties.Resources.music_2;
            this.ClientSize = new System.Drawing.Size(364, 345);
            this.Controls.Add(this.lblMusicDurTxt);
            this.Controls.Add(this.lblSongsCountTxt);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblCounter2);
            this.Controls.Add(this.lblMusicDuration);
            this.Controls.Add(this.lblSongsCounter);
            this.Controls.Add(this.lblCounter1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.WMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(380, 383);
            this.MinimumSize = new System.Drawing.Size(380, 383);
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGame_FormClosed);
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblCounter1;
        private System.Windows.Forms.Label lblCounter2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblSongsCounter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMusicDuration;
        private System.Windows.Forms.Label lblSongsCountTxt;
        private System.Windows.Forms.Label lblMusicDurTxt;
    }
}