
namespace Fractals.Settings
{
    partial class NewtonSettingsWindow
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
            this.xMultiplierText = new System.Windows.Forms.TextBox();
            this.xMultiplierInput = new System.Windows.Forms.TextBox();
            this.yMultiplierText = new System.Windows.Forms.TextBox();
            this.yMultiplierInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // xMultiplierText
            // 
            this.xMultiplierText.BackColor = System.Drawing.SystemColors.Control;
            this.xMultiplierText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xMultiplierText.Location = new System.Drawing.Point(12, 12);
            this.xMultiplierText.Name = "xMultiplierText";
            this.xMultiplierText.ReadOnly = true;
            this.xMultiplierText.Size = new System.Drawing.Size(210, 16);
            this.xMultiplierText.TabIndex = 0;
            this.xMultiplierText.TabStop = false;
            this.xMultiplierText.Text = "Multiplier X";
            this.xMultiplierText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xMultiplierInput
            // 
            this.xMultiplierInput.Location = new System.Drawing.Point(12, 34);
            this.xMultiplierInput.Name = "xMultiplierInput";
            this.xMultiplierInput.Size = new System.Drawing.Size(210, 23);
            this.xMultiplierInput.TabIndex = 0;
            this.xMultiplierInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // yMultiplierText
            // 
            this.yMultiplierText.BackColor = System.Drawing.SystemColors.Control;
            this.yMultiplierText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yMultiplierText.Location = new System.Drawing.Point(12, 76);
            this.yMultiplierText.Name = "yMultiplierText";
            this.yMultiplierText.ReadOnly = true;
            this.yMultiplierText.Size = new System.Drawing.Size(210, 16);
            this.yMultiplierText.TabIndex = 1;
            this.yMultiplierText.TabStop = false;
            this.yMultiplierText.Text = "Multiplier Y";
            this.yMultiplierText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yMultiplierInput
            // 
            this.yMultiplierInput.Location = new System.Drawing.Point(12, 98);
            this.yMultiplierInput.Name = "yMultiplierInput";
            this.yMultiplierInput.Size = new System.Drawing.Size(210, 23);
            this.yMultiplierInput.TabIndex = 1;
            this.yMultiplierInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NewtonSettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(234, 147);
            this.Controls.Add(this.yMultiplierInput);
            this.Controls.Add(this.yMultiplierText);
            this.Controls.Add(this.xMultiplierInput);
            this.Controls.Add(this.xMultiplierText);
            this.Name = "NewtonSettingsWindow";
            this.Text = "Newton Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SaveSettings);
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xMultiplierText;
        private System.Windows.Forms.TextBox xMultiplierInput;
        private System.Windows.Forms.TextBox yMultiplierText;
        private System.Windows.Forms.TextBox yMultiplierInput;
    }
}