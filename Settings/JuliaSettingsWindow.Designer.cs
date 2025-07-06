
namespace Fractals.Settings
{
    partial class JuliaSettingsWindow
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
            this.cRealText = new System.Windows.Forms.TextBox();
            this.cRealInput = new System.Windows.Forms.TextBox();
            this.cImagineText = new System.Windows.Forms.TextBox();
            this.cImagineInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cRealText
            // 
            this.cRealText.BackColor = System.Drawing.SystemColors.Control;
            this.cRealText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cRealText.Location = new System.Drawing.Point(12, 12);
            this.cRealText.Name = "cRealText";
            this.cRealText.ReadOnly = true;
            this.cRealText.Size = new System.Drawing.Size(210, 16);
            this.cRealText.TabIndex = 0;
            this.cRealText.TabStop = false;
            this.cRealText.Text = "Real part of С";
            this.cRealText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cRealInput
            // 
            this.cRealInput.Location = new System.Drawing.Point(12, 34);
            this.cRealInput.Name = "cRealInput";
            this.cRealInput.Size = new System.Drawing.Size(210, 23);
            this.cRealInput.TabIndex = 0;
            this.cRealInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cImagineText
            // 
            this.cImagineText.BackColor = System.Drawing.SystemColors.Control;
            this.cImagineText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cImagineText.Location = new System.Drawing.Point(12, 76);
            this.cImagineText.Name = "cImagineText";
            this.cImagineText.ReadOnly = true;
            this.cImagineText.Size = new System.Drawing.Size(210, 16);
            this.cImagineText.TabIndex = 2;
            this.cImagineText.TabStop = false;
            this.cImagineText.Text = "Imagine part of С";
            this.cImagineText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cImagineInput
            // 
            this.cImagineInput.Location = new System.Drawing.Point(12, 98);
            this.cImagineInput.Name = "cImagineInput";
            this.cImagineInput.Size = new System.Drawing.Size(210, 23);
            this.cImagineInput.TabIndex = 2;
            this.cImagineInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // JuliaSettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(234, 147);
            this.Controls.Add(this.cImagineInput);
            this.Controls.Add(this.cImagineText);
            this.Controls.Add(this.cRealInput);
            this.Controls.Add(this.cRealText);
            this.Name = "JuliaSettingsWindow";
            this.Text = "Julia Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.Load += new System.EventHandler(this.LoadSettings);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cRealText;
        private System.Windows.Forms.TextBox cRealInput;
        private System.Windows.Forms.TextBox cImagineText;
        private System.Windows.Forms.TextBox cImagineInput;
    }
}