namespace GuessTheMelody
{
    partial class FrmParams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParams));
            this.lbMusicTrack = new System.Windows.Forms.ListBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnClearList = new System.Windows.Forms.Button();
            this.chkbAllDirectories = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbGameSettings = new System.Windows.Forms.GroupBox();
            this.lblGameDuration = new System.Windows.Forms.Label();
            this.lblMusicDuration = new System.Windows.Forms.Label();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.chkbRandomStart = new System.Windows.Forms.CheckBox();
            this.gbGameSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMusicTrack
            // 
            this.lbMusicTrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbMusicTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMusicTrack.FormattingEnabled = true;
            this.lbMusicTrack.ItemHeight = 16;
            this.lbMusicTrack.Location = new System.Drawing.Point(0, 0);
            this.lbMusicTrack.Name = "lbMusicTrack";
            this.lbMusicTrack.Size = new System.Drawing.Size(421, 180);
            this.lbMusicTrack.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 186);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(104, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Выбрать папку";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(122, 186);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 1;
            this.btnClearList.Text = "Очистить";
            this.btnClearList.UseVisualStyleBackColor = true;
            // 
            // chkbAllDirectories
            // 
            this.chkbAllDirectories.AutoSize = true;
            this.chkbAllDirectories.Location = new System.Drawing.Point(291, 190);
            this.chkbAllDirectories.Name = "chkbAllDirectories";
            this.chkbAllDirectories.Size = new System.Drawing.Size(118, 17);
            this.chkbAllDirectories.TabIndex = 2;
            this.chkbAllDirectories.Text = "Вложенные папки";
            this.chkbAllDirectories.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(334, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(253, 341);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbGameSettings
            // 
            this.gbGameSettings.Controls.Add(this.cbMusicDuration);
            this.gbGameSettings.Controls.Add(this.cbGameDuration);
            this.gbGameSettings.Controls.Add(this.lblMusicDuration);
            this.gbGameSettings.Controls.Add(this.chkbRandomStart);
            this.gbGameSettings.Controls.Add(this.lblGameDuration);
            this.gbGameSettings.Location = new System.Drawing.Point(12, 215);
            this.gbGameSettings.Name = "gbGameSettings";
            this.gbGameSettings.Size = new System.Drawing.Size(397, 120);
            this.gbGameSettings.TabIndex = 4;
            this.gbGameSettings.TabStop = false;
            this.gbGameSettings.Text = "Настройки игры";
            // 
            // lblGameDuration
            // 
            this.lblGameDuration.AutoSize = true;
            this.lblGameDuration.Location = new System.Drawing.Point(7, 32);
            this.lblGameDuration.Name = "lblGameDuration";
            this.lblGameDuration.Size = new System.Drawing.Size(169, 13);
            this.lblGameDuration.TabIndex = 0;
            this.lblGameDuration.Text = "Продолжительность игры (сек.)";
            // 
            // lblMusicDuration
            // 
            this.lblMusicDuration.AutoSize = true;
            this.lblMusicDuration.Location = new System.Drawing.Point(7, 59);
            this.lblMusicDuration.Name = "lblMusicDuration";
            this.lblMusicDuration.Size = new System.Drawing.Size(116, 13);
            this.lblMusicDuration.TabIndex = 0;
            this.lblMusicDuration.Text = "Время на ответ (сек.)";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120"});
            this.cbGameDuration.Location = new System.Drawing.Point(182, 29);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(41, 21);
            this.cbGameDuration.TabIndex = 1;
            this.cbGameDuration.Text = "60";
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbMusicDuration.Location = new System.Drawing.Point(182, 56);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(41, 21);
            this.cbMusicDuration.TabIndex = 1;
            this.cbMusicDuration.Text = "20";
            // 
            // chkbRandomStart
            // 
            this.chkbRandomStart.AutoSize = true;
            this.chkbRandomStart.Location = new System.Drawing.Point(10, 85);
            this.chkbRandomStart.Name = "chkbRandomStart";
            this.chkbRandomStart.Size = new System.Drawing.Size(112, 17);
            this.chkbRandomStart.TabIndex = 2;
            this.chkbRandomStart.Text = "Случайный старт";
            this.chkbRandomStart.UseVisualStyleBackColor = true;
            // 
            // FrmParams
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(421, 374);
            this.Controls.Add(this.gbGameSettings);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chkbAllDirectories);
            this.Controls.Add(this.btnClearList);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.lbMusicTrack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(437, 412);
            this.MinimumSize = new System.Drawing.Size(437, 412);
            this.Name = "FrmParams";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FrmParams_Load);
            this.gbGameSettings.ResumeLayout(false);
            this.gbGameSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMusicTrack;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.CheckBox chkbAllDirectories;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbGameSettings;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.Label lblMusicDuration;
        private System.Windows.Forms.Label lblGameDuration;
        private System.Windows.Forms.CheckBox chkbRandomStart;
    }
}