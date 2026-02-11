namespace Misstab.ScreenForms.DialogForm.Setting
{
    partial class TimeLineOverAllSetting
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
            button1 = new Button();
            button2 = new Button();
            tabControl1 = new TabControl();
            tbSummary = new TabPage();
            chkVisible = new CheckBox();
            chkUpdateTL = new CheckBox();
            cmdDeleteTimeLine = new Button();
            chkPhyscalDelete = new CheckBox();
            chkLowSpecMode = new CheckBox();
            tbDrive = new TabPage();
            chkUnlimitedLineCount = new CheckBox();
            numMaxLineCount = new NumericUpDown();
            label1 = new Label();
            tbFontColor = new TabPage();
            fbPostRenote = new Misstab.ScreenForms.DialogForm.Template.TimeLineViewSetting_FontView();
            fbPostCW = new Misstab.ScreenForms.DialogForm.Template.TimeLineViewSetting_FontView();
            fbPostChannel = new Misstab.ScreenForms.DialogForm.Template.TimeLineViewSetting_FontView();
            fbPostUnion = new Misstab.ScreenForms.DialogForm.Template.TimeLineViewSetting_FontView();
            fbPostLocal = new Misstab.ScreenForms.DialogForm.Template.TimeLineViewSetting_FontView();
            fbPostFollower = new Misstab.ScreenForms.DialogForm.Template.TimeLineViewSetting_FontView();
            fbPostDirect = new Misstab.ScreenForms.DialogForm.Template.TimeLineViewSetting_FontView();
            fbPostHome = new Misstab.ScreenForms.DialogForm.Template.TimeLineViewSetting_FontView();
            fbPostPublic = new Misstab.ScreenForms.DialogForm.Template.TimeLineViewSetting_FontView();
            fbPostReplyed = new Misstab.ScreenForms.DialogForm.Template.TimeLineViewSetting_FontView();
            mailControlForm1 = new Misstab.Common.Notification.Mail.MailControlForm();
            txtDescription = new TextBox();
            cmdSaveColorTheme = new Button();
            cmdLoadColorTheme = new Button();
            tabControl1.SuspendLayout();
            tbSummary.SuspendLayout();
            tbDrive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxLineCount).BeginInit();
            tbFontColor.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "保存";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 12);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "キャンセル";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tbSummary);
            tabControl1.Controls.Add(tbDrive);
            tabControl1.Controls.Add(tbFontColor);
            tabControl1.Location = new Point(3, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 306);
            tabControl1.TabIndex = 2;
            // 
            // tbSummary
            // 
            tbSummary.Controls.Add(chkVisible);
            tbSummary.Controls.Add(chkUpdateTL);
            tbSummary.Controls.Add(cmdDeleteTimeLine);
            tbSummary.Controls.Add(chkPhyscalDelete);
            tbSummary.Controls.Add(chkLowSpecMode);
            tbSummary.Location = new Point(4, 24);
            tbSummary.Name = "tbSummary";
            tbSummary.Padding = new Padding(3);
            tbSummary.Size = new Size(788, 278);
            tbSummary.TabIndex = 0;
            tbSummary.Text = "全般";
            tbSummary.UseVisualStyleBackColor = true;
            // 
            // chkVisible
            // 
            chkVisible.AutoSize = true;
            chkVisible.Location = new Point(6, 81);
            chkVisible.Name = "chkVisible";
            chkVisible.Size = new Size(69, 19);
            chkVisible.TabIndex = 4;
            chkVisible.Text = "表示する";
            chkVisible.UseVisualStyleBackColor = true;
            // 
            // chkUpdateTL
            // 
            chkUpdateTL.AutoSize = true;
            chkUpdateTL.Location = new Point(6, 56);
            chkUpdateTL.Name = "chkUpdateTL";
            chkUpdateTL.Size = new Size(102, 19);
            chkUpdateTL.TabIndex = 3;
            chkUpdateTL.Text = "表示を更新する";
            chkUpdateTL.UseVisualStyleBackColor = true;
            // 
            // cmdDeleteTimeLine
            // 
            cmdDeleteTimeLine.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 128);
            cmdDeleteTimeLine.ForeColor = Color.Red;
            cmdDeleteTimeLine.Location = new Point(6, 249);
            cmdDeleteTimeLine.Name = "cmdDeleteTimeLine";
            cmdDeleteTimeLine.Size = new Size(240, 23);
            cmdDeleteTimeLine.TabIndex = 2;
            cmdDeleteTimeLine.Text = "このタイムラインを削除する";
            cmdDeleteTimeLine.UseVisualStyleBackColor = true;
            // 
            // chkPhyscalDelete
            // 
            chkPhyscalDelete.AutoSize = true;
            chkPhyscalDelete.Enabled = false;
            chkPhyscalDelete.Location = new Point(6, 31);
            chkPhyscalDelete.Name = "chkPhyscalDelete";
            chkPhyscalDelete.Size = new Size(99, 19);
            chkPhyscalDelete.TabIndex = 1;
            chkPhyscalDelete.Text = "物理削除モード";
            chkPhyscalDelete.UseVisualStyleBackColor = true;
            // 
            // chkLowSpecMode
            // 
            chkLowSpecMode.AutoSize = true;
            chkLowSpecMode.Location = new Point(6, 6);
            chkLowSpecMode.Name = "chkLowSpecMode";
            chkLowSpecMode.Size = new Size(99, 19);
            chkLowSpecMode.TabIndex = 0;
            chkLowSpecMode.Text = "低スペックモード";
            chkLowSpecMode.UseVisualStyleBackColor = true;
            chkLowSpecMode.CheckedChanged += chkLowSpecMode_CheckedChanged;
            // 
            // tbDrive
            // 
            tbDrive.Controls.Add(chkUnlimitedLineCount);
            tbDrive.Controls.Add(numMaxLineCount);
            tbDrive.Controls.Add(label1);
            tbDrive.Location = new Point(4, 24);
            tbDrive.Name = "tbDrive";
            tbDrive.Padding = new Padding(3);
            tbDrive.Size = new Size(788, 278);
            tbDrive.TabIndex = 1;
            tbDrive.Text = "動作";
            tbDrive.UseVisualStyleBackColor = true;
            // 
            // chkUnlimitedLineCount
            // 
            chkUnlimitedLineCount.AutoSize = true;
            chkUnlimitedLineCount.Location = new Point(323, 11);
            chkUnlimitedLineCount.Name = "chkUnlimitedLineCount";
            chkUnlimitedLineCount.Size = new Size(62, 19);
            chkUnlimitedLineCount.TabIndex = 2;
            chkUnlimitedLineCount.Text = "無制限";
            chkUnlimitedLineCount.UseVisualStyleBackColor = true;
            // 
            // numMaxLineCount
            // 
            numMaxLineCount.Location = new Point(67, 11);
            numMaxLineCount.Maximum = new decimal(new int[] { 1661992959, 1808227885, 5, 0 });
            numMaxLineCount.Name = "numMaxLineCount";
            numMaxLineCount.Size = new Size(250, 23);
            numMaxLineCount.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 13);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "最大行数";
            // 
            // tbFontColor
            // 
            tbFontColor.AutoScroll = true;
            tbFontColor.Controls.Add(cmdLoadColorTheme);
            tbFontColor.Controls.Add(cmdSaveColorTheme);
            tbFontColor.Controls.Add(fbPostRenote);
            tbFontColor.Controls.Add(fbPostCW);
            tbFontColor.Controls.Add(fbPostChannel);
            tbFontColor.Controls.Add(fbPostUnion);
            tbFontColor.Controls.Add(fbPostLocal);
            tbFontColor.Controls.Add(fbPostFollower);
            tbFontColor.Controls.Add(fbPostDirect);
            tbFontColor.Controls.Add(fbPostHome);
            tbFontColor.Controls.Add(fbPostPublic);
            tbFontColor.Controls.Add(fbPostReplyed);
            tbFontColor.Controls.Add(mailControlForm1);
            tbFontColor.Location = new Point(4, 24);
            tbFontColor.Name = "tbFontColor";
            tbFontColor.Size = new Size(788, 278);
            tbFontColor.TabIndex = 2;
            tbFontColor.Text = "表示色";
            tbFontColor.UseVisualStyleBackColor = true;
            // 
            // fbPostRenote
            // 
            fbPostRenote.DispBackColor = "FFFFFF";
            fbPostRenote.DispFrontColor = "000000";
            fbPostRenote.DispText = "リノート";
            fbPostRenote.Location = new Point(5, 273);
            fbPostRenote.Name = "fbPostRenote";
            fbPostRenote.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            fbPostRenote.Size = new Size(489, 29);
            fbPostRenote.TabIndex = 1;
            // 
            // fbPostCW
            // 
            fbPostCW.DispBackColor = "FFFFFF";
            fbPostCW.DispFrontColor = "000000";
            fbPostCW.DispText = "投稿(CW)";
            fbPostCW.Location = new Point(5, 247);
            fbPostCW.Name = "fbPostCW";
            fbPostCW.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            fbPostCW.Size = new Size(489, 29);
            fbPostCW.TabIndex = 1;
            // 
            // fbPostChannel
            // 
            fbPostChannel.DispBackColor = "FFFFFF";
            fbPostChannel.DispFrontColor = "000000";
            fbPostChannel.DispText = "投稿(チャンネル)";
            fbPostChannel.Location = new Point(5, 221);
            fbPostChannel.Name = "fbPostChannel";
            fbPostChannel.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            fbPostChannel.Size = new Size(489, 29);
            fbPostChannel.TabIndex = 1;
            // 
            // fbPostUnion
            // 
            fbPostUnion.DispBackColor = "FFFFFF";
            fbPostUnion.DispFrontColor = "000000";
            fbPostUnion.DispText = "連合あり";
            fbPostUnion.Location = new Point(5, 195);
            fbPostUnion.Name = "fbPostUnion";
            fbPostUnion.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            fbPostUnion.Size = new Size(489, 29);
            fbPostUnion.TabIndex = 1;
            // 
            // fbPostLocal
            // 
            fbPostLocal.DispBackColor = "FFFFFF";
            fbPostLocal.DispFrontColor = "000000";
            fbPostLocal.DispText = "ローカルのみ";
            fbPostLocal.Location = new Point(5, 169);
            fbPostLocal.Name = "fbPostLocal";
            fbPostLocal.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            fbPostLocal.Size = new Size(489, 29);
            fbPostLocal.TabIndex = 1;
            // 
            // fbPostFollower
            // 
            fbPostFollower.DispBackColor = "FFFFFF";
            fbPostFollower.DispFrontColor = "000000";
            fbPostFollower.DispText = "投稿(フォロワー)";
            fbPostFollower.Location = new Point(5, 143);
            fbPostFollower.Name = "fbPostFollower";
            fbPostFollower.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            fbPostFollower.Size = new Size(489, 29);
            fbPostFollower.TabIndex = 1;
            // 
            // fbPostDirect
            // 
            fbPostDirect.DispBackColor = "FFFFFF";
            fbPostDirect.DispFrontColor = "000000";
            fbPostDirect.DispText = "投稿(DM)";
            fbPostDirect.Location = new Point(5, 117);
            fbPostDirect.Name = "fbPostDirect";
            fbPostDirect.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            fbPostDirect.Size = new Size(489, 29);
            fbPostDirect.TabIndex = 1;
            // 
            // fbPostHome
            // 
            fbPostHome.DispBackColor = "FFFFFF";
            fbPostHome.DispFrontColor = "000000";
            fbPostHome.DispText = "投稿(ホーム)";
            fbPostHome.Location = new Point(5, 91);
            fbPostHome.Name = "fbPostHome";
            fbPostHome.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            fbPostHome.Size = new Size(489, 29);
            fbPostHome.TabIndex = 1;
            // 
            // fbPostPublic
            // 
            fbPostPublic.DispBackColor = "FFFFFF";
            fbPostPublic.DispFrontColor = "000000";
            fbPostPublic.DispText = "投稿(パブリック)";
            fbPostPublic.Location = new Point(5, 65);
            fbPostPublic.Name = "fbPostPublic";
            fbPostPublic.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            fbPostPublic.Size = new Size(489, 29);
            fbPostPublic.TabIndex = 1;
            // 
            // fbPostReplyed
            // 
            fbPostReplyed.DispBackColor = "FFFFFF";
            fbPostReplyed.DispFrontColor = "000000";
            fbPostReplyed.DispText = "リプライ";
            fbPostReplyed.Location = new Point(5, 39);
            fbPostReplyed.Name = "fbPostReplyed";
            fbPostReplyed.Setting_Mode = Template.TimeLineViewSetting_FontView.SETTING_MODE.BOTH;
            fbPostReplyed.Size = new Size(489, 29);
            fbPostReplyed.TabIndex = 1;
            // 
            // mailControlForm1
            // 
            mailControlForm1.AutoSize = true;
            mailControlForm1.Location = new Point(0, 0);
            mailControlForm1.Name = "mailControlForm1";
            mailControlForm1.Size = new Size(10, 10);
            mailControlForm1.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Enabled = false;
            txtDescription.Location = new Point(3, 349);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(796, 100);
            txtDescription.TabIndex = 3;
            // 
            // cmdSaveColorTheme
            // 
            cmdSaveColorTheme.Location = new Point(3, 3);
            cmdSaveColorTheme.Name = "cmdSaveColorTheme";
            cmdSaveColorTheme.Size = new Size(75, 23);
            cmdSaveColorTheme.TabIndex = 2;
            cmdSaveColorTheme.Text = "保存";
            cmdSaveColorTheme.UseVisualStyleBackColor = true;
            cmdSaveColorTheme.Click += cmdSaveColorTheme_Click;
            // 
            // cmdLoadColorTheme
            // 
            cmdLoadColorTheme.Location = new Point(84, 3);
            cmdLoadColorTheme.Name = "cmdLoadColorTheme";
            cmdLoadColorTheme.Size = new Size(75, 23);
            cmdLoadColorTheme.TabIndex = 2;
            cmdLoadColorTheme.Text = "読み込み";
            cmdLoadColorTheme.UseVisualStyleBackColor = true;
            cmdLoadColorTheme.Click += cmdLoadColorTheme_Click;
            // 
            // TimeLineOverAllSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDescription);
            Controls.Add(tabControl1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TimeLineOverAllSetting";
            Text = "タイムライン環境設定";
            Load += TimeLineOverAllSetting_Load;
            tabControl1.ResumeLayout(false);
            tbSummary.ResumeLayout(false);
            tbSummary.PerformLayout();
            tbDrive.ResumeLayout(false);
            tbDrive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxLineCount).EndInit();
            tbFontColor.ResumeLayout(false);
            tbFontColor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TabControl tabControl1;
        private TabPage tbSummary;
        private TabPage tbDrive;
        private CheckBox chkLowSpecMode;
        private CheckBox chkPhyscalDelete;
        private TextBox txtDescription;
        private Button cmdDeleteTimeLine;
        private NumericUpDown numMaxLineCount;
        private Label label1;
        private CheckBox chkUnlimitedLineCount;
        private CheckBox chkUpdateTL;
        private CheckBox chkVisible;
        private TabPage tbFontColor;
        private Common.Notification.Mail.MailControlForm mailControlForm1;
        private Template.TimeLineViewSetting_FontView fbPostUnion;
        private Template.TimeLineViewSetting_FontView fbPostLocal;
        private Template.TimeLineViewSetting_FontView fbPostFollower;
        private Template.TimeLineViewSetting_FontView fbPostDirect;
        private Template.TimeLineViewSetting_FontView fbPostHome;
        private Template.TimeLineViewSetting_FontView fbPostPublic;
        private Template.TimeLineViewSetting_FontView fbPostReplyed;
        private Template.TimeLineViewSetting_FontView fbPostCW;
        private Template.TimeLineViewSetting_FontView fbPostChannel;
        private Template.TimeLineViewSetting_FontView fbPostRenote;
        private Button cmdLoadColorTheme;
        private Button cmdSaveColorTheme;
    }
}