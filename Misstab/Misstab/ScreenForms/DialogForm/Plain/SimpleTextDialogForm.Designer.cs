namespace Misstab.ScreenForms.DialogForm.Plain
{
    partial class SimpleTextDialogForm
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
            txtInputBox = new TextBox();
            cmdYesOK = new Button();
            cmdNoCancel = new Button();
            cmdAddFunc1 = new Button();
            cmdAddFunc2 = new Button();
            cmdAddFunc3 = new Button();
            cmdAddFunc4 = new Button();
            cmdAddFunc5 = new Button();
            SuspendLayout();
            // 
            // txtInputBox
            // 
            txtInputBox.Location = new Point(12, 12);
            txtInputBox.Name = "txtInputBox";
            txtInputBox.Size = new Size(760, 23);
            txtInputBox.TabIndex = 0;
            // 
            // cmdYesOK
            // 
            cmdYesOK.Location = new Point(12, 41);
            cmdYesOK.Name = "cmdYesOK";
            cmdYesOK.Size = new Size(75, 23);
            cmdYesOK.TabIndex = 1;
            cmdYesOK.Text = "button1";
            cmdYesOK.UseVisualStyleBackColor = true;
            cmdYesOK.Click += cmdYesOK_Click;
            // 
            // cmdNoCancel
            // 
            cmdNoCancel.Location = new Point(93, 41);
            cmdNoCancel.Name = "cmdNoCancel";
            cmdNoCancel.Size = new Size(75, 23);
            cmdNoCancel.TabIndex = 2;
            cmdNoCancel.Text = "button2";
            cmdNoCancel.UseVisualStyleBackColor = true;
            cmdNoCancel.Click += cmdNoCancel_Click;
            // 
            // cmdAddFunc1
            // 
            cmdAddFunc1.Location = new Point(373, 41);
            cmdAddFunc1.Name = "cmdAddFunc1";
            cmdAddFunc1.Size = new Size(75, 23);
            cmdAddFunc1.TabIndex = 3;
            cmdAddFunc1.Text = "button1";
            cmdAddFunc1.UseVisualStyleBackColor = true;
            // 
            // cmdAddFunc2
            // 
            cmdAddFunc2.Location = new Point(454, 41);
            cmdAddFunc2.Name = "cmdAddFunc2";
            cmdAddFunc2.Size = new Size(75, 23);
            cmdAddFunc2.TabIndex = 3;
            cmdAddFunc2.Text = "button1";
            cmdAddFunc2.UseVisualStyleBackColor = true;
            // 
            // cmdAddFunc3
            // 
            cmdAddFunc3.Location = new Point(535, 41);
            cmdAddFunc3.Name = "cmdAddFunc3";
            cmdAddFunc3.Size = new Size(75, 23);
            cmdAddFunc3.TabIndex = 3;
            cmdAddFunc3.Text = "button1";
            cmdAddFunc3.UseVisualStyleBackColor = true;
            // 
            // cmdAddFunc4
            // 
            cmdAddFunc4.Location = new Point(616, 41);
            cmdAddFunc4.Name = "cmdAddFunc4";
            cmdAddFunc4.Size = new Size(75, 23);
            cmdAddFunc4.TabIndex = 3;
            cmdAddFunc4.Text = "button1";
            cmdAddFunc4.UseVisualStyleBackColor = true;
            // 
            // cmdAddFunc5
            // 
            cmdAddFunc5.Location = new Point(697, 41);
            cmdAddFunc5.Name = "cmdAddFunc5";
            cmdAddFunc5.Size = new Size(75, 23);
            cmdAddFunc5.TabIndex = 3;
            cmdAddFunc5.Text = "button1";
            cmdAddFunc5.UseVisualStyleBackColor = true;
            // 
            // SimpleTextDialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 72);
            Controls.Add(cmdAddFunc5);
            Controls.Add(cmdAddFunc4);
            Controls.Add(cmdAddFunc3);
            Controls.Add(cmdAddFunc2);
            Controls.Add(cmdAddFunc1);
            Controls.Add(cmdNoCancel);
            Controls.Add(cmdYesOK);
            Controls.Add(txtInputBox);
            Name = "SimpleTextDialogForm";
            Text = "SimpleTextDialogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputBox;
        private Button cmdYesOK;
        private Button cmdNoCancel;
        private Button cmdAddFunc1;
        private Button cmdAddFunc2;
        private Button cmdAddFunc3;
        private Button cmdAddFunc4;
        private Button cmdAddFunc5;
    }
}