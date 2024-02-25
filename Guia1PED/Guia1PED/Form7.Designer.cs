namespace Guia1PED
{
    partial class Form7
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
            components = new System.ComponentModel.Container();
            timermov = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timermov
            // 
            timermov.Tick += timermov_Tick;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Name = "Form7";
            Text = "Snake";
            Load += Form7_Load;
            Paint += Form7_Paint;
            KeyDown += Form7_KeyDown;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timermov;
    }
}