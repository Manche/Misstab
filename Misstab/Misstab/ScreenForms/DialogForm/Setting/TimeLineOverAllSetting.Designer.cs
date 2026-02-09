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
            chkLowSpecMode = new CheckBox();
            tbDrive = new TabPage();
            chkPhyscalDelete = new CheckBox();
            txtDescription = new TextBox();
            tabControl1.SuspendLayout();
            tbSummary.SuspendLayout();
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
            tabControl1.Location = new Point(3, 41);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 306);
            tabControl1.TabIndex = 2;
            // 
            // tbSummary
            // 
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
            tbDrive.Location = new Point(4, 24);
            tbDrive.Name = "tbDrive";
            tbDrive.Padding = new Padding(3);
            tbDrive.Size = new Size(788, 378);
            tbDrive.TabIndex = 1;
            tbDrive.Text = "動作";
            tbDrive.UseVisualStyleBackColor = true;
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
            // txtDescription
            // 
            txtDescription.Enabled = false;
            txtDescription.Location = new Point(3, 349);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(796, 100);
            txtDescription.TabIndex = 3;
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
    }
}