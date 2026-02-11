namespace Misstab.ScreenForms.DialogForm.Template
{
    partial class TimeLineViewSetting_FontView
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            lblDispText = new Label();
            txtColorDisp = new TextBox();
            cmdChangeForeSetting = new Button();
            cmdChangeBackSetting = new Button();
            SuspendLayout();
            // 
            // lblDispText
            // 
            lblDispText.AutoSize = true;
            lblDispText.Location = new Point(0, 6);
            lblDispText.Name = "lblDispText";
            lblDispText.Size = new Size(38, 15);
            lblDispText.TabIndex = 0;
            lblDispText.Text = "label1";
            // 
            // txtColorDisp
            // 
            txtColorDisp.Location = new Point(138, 3);
            txtColorDisp.Name = "txtColorDisp";
            txtColorDisp.ReadOnly = true;
            txtColorDisp.ShortcutsEnabled = false;
            txtColorDisp.Size = new Size(122, 23);
            txtColorDisp.TabIndex = 1;
            txtColorDisp.Text = "文字色";
            // 
            // cmdChangeForeSetting
            // 
            cmdChangeForeSetting.Location = new Point(266, 3);
            cmdChangeForeSetting.Name = "cmdChangeForeSetting";
            cmdChangeForeSetting.Size = new Size(75, 23);
            cmdChangeForeSetting.TabIndex = 2;
            cmdChangeForeSetting.Text = "文字色";
            cmdChangeForeSetting.UseVisualStyleBackColor = true;
            cmdChangeForeSetting.Click += cmdChangeForeSetting_Click;
            // 
            // cmdChangeBackSetting
            // 
            cmdChangeBackSetting.Location = new Point(347, 3);
            cmdChangeBackSetting.Name = "cmdChangeBackSetting";
            cmdChangeBackSetting.Size = new Size(75, 23);
            cmdChangeBackSetting.TabIndex = 2;
            cmdChangeBackSetting.Text = "背景色";
            cmdChangeBackSetting.UseVisualStyleBackColor = true;
            cmdChangeBackSetting.Click += cmdChangeBackSetting_Click;
            // 
            // TimeLineViewSetting_FontView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmdChangeBackSetting);
            Controls.Add(cmdChangeForeSetting);
            Controls.Add(txtColorDisp);
            Controls.Add(lblDispText);
            Name = "TimeLineViewSetting_FontView";
            Size = new Size(489, 29);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDispText;
        private TextBox txtColorDisp;
        private Button cmdChangeForeSetting;
        private Button cmdChangeBackSetting;
    }
}
