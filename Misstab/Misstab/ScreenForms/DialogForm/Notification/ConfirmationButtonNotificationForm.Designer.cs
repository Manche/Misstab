namespace Misstab.ScreenForms.DialogForm.Notification
{
    partial class ConfirmationButtonNotificationForm
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
            cmdConfirmed = new Button();
            txtNotification = new TextBox();
            SuspendLayout();
            // 
            // cmdConfirmed
            // 
            cmdConfirmed.Location = new Point(12, 12);
            cmdConfirmed.Name = "cmdConfirmed";
            cmdConfirmed.Size = new Size(75, 23);
            cmdConfirmed.TabIndex = 0;
            cmdConfirmed.Text = "確認";
            cmdConfirmed.UseVisualStyleBackColor = true;
            cmdConfirmed.Click += cmdConfirmed_Click;
            // 
            // txtNotification
            // 
            txtNotification.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNotification.Location = new Point(12, 41);
            txtNotification.Multiline = true;
            txtNotification.Name = "txtNotification";
            txtNotification.ReadOnly = true;
            txtNotification.Size = new Size(632, 190);
            txtNotification.TabIndex = 1;
            // 
            // ConfirmationButtonNotificationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 243);
            Controls.Add(txtNotification);
            Controls.Add(cmdConfirmed);
            Name = "ConfirmationButtonNotificationForm";
            Text = "ConfirmationButtonNotificationForm";
            FormClosing += ConfirmationButtonNotificationForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdConfirmed;
        private TextBox txtNotification;
    }
}