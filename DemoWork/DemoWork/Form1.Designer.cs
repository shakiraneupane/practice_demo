namespace DemoWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRun = new Button();
            txtInput = new TextBox();
            OutputBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)OutputBox).BeginInit();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(66, 30);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(112, 34);
            btnRun.TabIndex = 0;
            btnRun.Text = "button1";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click_1;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(215, 80);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(308, 194);
            txtInput.TabIndex = 1;
            // 
            // OutputBox
            // 
            OutputBox.BackColor = SystemColors.AppWorkspace;
            OutputBox.Location = new Point(615, 80);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(302, 194);
            OutputBox.TabIndex = 2;
            OutputBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 366);
            Controls.Add(OutputBox);
            Controls.Add(txtInput);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)OutputBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private TextBox txtInput;
        private PictureBox OutputBox;
    }
}
