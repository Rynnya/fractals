
namespace Fractals
{
    partial class MainWindow
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
            this.drawFractal = new System.Windows.Forms.Button();
            this.fractalColor = new System.Windows.Forms.Button();
            this.fieldColor = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.PictureBox();
            this.selectType = new System.Windows.Forms.TabControl();
            this.geometricFractals = new System.Windows.Forms.TabPage();
            this.geometricAmountOfIterationsSelect = new System.Windows.Forms.ComboBox();
            this.geometricAmountOfIterations = new System.Windows.Forms.TextBox();
            this.geometricType = new System.Windows.Forms.TextBox();
            this.geometricTypeSelect = new System.Windows.Forms.ComboBox();
            this.dynamicFractals = new System.Windows.Forms.TabPage();
            this.dynamicSettings = new System.Windows.Forms.Button();
            this.dynamicTypeSelect = new System.Windows.Forms.ComboBox();
            this.dynamicType = new System.Windows.Forms.TextBox();
            this.stochasticFractals = new System.Windows.Forms.TabPage();
            this.stochasticPlasma = new System.Windows.Forms.RadioButton();
            this.stochasticFractalTree = new System.Windows.Forms.RadioButton();
            this.fractalColorDialog = new System.Windows.Forms.ColorDialog();
            this.fieldColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).BeginInit();
            this.selectType.SuspendLayout();
            this.geometricFractals.SuspendLayout();
            this.dynamicFractals.SuspendLayout();
            this.stochasticFractals.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawFractal
            // 
            this.drawFractal.Location = new System.Drawing.Point(913, 455);
            this.drawFractal.Name = "drawFractal";
            this.drawFractal.Size = new System.Drawing.Size(330, 45);
            this.drawFractal.TabIndex = 0;
            this.drawFractal.TabStop = false;
            this.drawFractal.Text = "Draw";
            this.drawFractal.UseVisualStyleBackColor = true;
            this.drawFractal.Click += new System.EventHandler(this.Draw);
            // 
            // fractalColor
            // 
            this.fractalColor.Location = new System.Drawing.Point(913, 506);
            this.fractalColor.Name = "fractalColor";
            this.fractalColor.Size = new System.Drawing.Size(162, 45);
            this.fractalColor.TabIndex = 0;
            this.fractalColor.TabStop = false;
            this.fractalColor.Text = "Fractal color";
            this.fractalColor.UseVisualStyleBackColor = true;
            this.fractalColor.Click += new System.EventHandler(this.ChangeFractalColor);
            // 
            // fieldColor
            // 
            this.fieldColor.Location = new System.Drawing.Point(1081, 506);
            this.fieldColor.Name = "fieldColor";
            this.fieldColor.Size = new System.Drawing.Size(162, 45);
            this.fieldColor.TabIndex = 0;
            this.fieldColor.TabStop = false;
            this.fieldColor.Text = "Field color";
            this.fieldColor.UseVisualStyleBackColor = true;
            this.fieldColor.Click += new System.EventHandler(this.ChangeFieldColor);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.White;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.Location = new System.Drawing.Point(12, 12);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(895, 539);
            this.outputBox.TabIndex = 5;
            this.outputBox.TabStop = false;
            // 
            // selectType
            // 
            this.selectType.Controls.Add(this.geometricFractals);
            this.selectType.Controls.Add(this.dynamicFractals);
            this.selectType.Controls.Add(this.stochasticFractals);
            this.selectType.ItemSize = new System.Drawing.Size(110, 20);
            this.selectType.Location = new System.Drawing.Point(914, 13);
            this.selectType.Name = "selectType";
            this.selectType.SelectedIndex = 0;
            this.selectType.Size = new System.Drawing.Size(329, 411);
            this.selectType.TabIndex = 6;
            this.selectType.SelectedIndexChanged += new System.EventHandler(this.FractalTypeChanged);
            // 
            // geometricFractals
            // 
            this.geometricFractals.Controls.Add(this.geometricAmountOfIterationsSelect);
            this.geometricFractals.Controls.Add(this.geometricAmountOfIterations);
            this.geometricFractals.Controls.Add(this.geometricType);
            this.geometricFractals.Controls.Add(this.geometricTypeSelect);
            this.geometricFractals.Location = new System.Drawing.Point(4, 24);
            this.geometricFractals.Name = "geometricFractals";
            this.geometricFractals.Padding = new System.Windows.Forms.Padding(3);
            this.geometricFractals.Size = new System.Drawing.Size(321, 383);
            this.geometricFractals.TabIndex = 0;
            this.geometricFractals.Text = "Geometric";
            this.geometricFractals.UseVisualStyleBackColor = true;
            // 
            // geometricAmountOfIterationsSelect
            // 
            this.geometricAmountOfIterationsSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.geometricAmountOfIterationsSelect.FormattingEnabled = true;
            this.geometricAmountOfIterationsSelect.Location = new System.Drawing.Point(7, 93);
            this.geometricAmountOfIterationsSelect.Name = "geometricAmountOfIterationsSelect";
            this.geometricAmountOfIterationsSelect.Size = new System.Drawing.Size(308, 23);
            this.geometricAmountOfIterationsSelect.TabIndex = 3;
            // 
            // geometricAmountOfIterations
            // 
            this.geometricAmountOfIterations.BackColor = System.Drawing.SystemColors.Window;
            this.geometricAmountOfIterations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.geometricAmountOfIterations.Location = new System.Drawing.Point(6, 70);
            this.geometricAmountOfIterations.Name = "geometricAmountOfIterations";
            this.geometricAmountOfIterations.ReadOnly = true;
            this.geometricAmountOfIterations.Size = new System.Drawing.Size(309, 16);
            this.geometricAmountOfIterations.TabIndex = 2;
            this.geometricAmountOfIterations.Text = "Amount of iterations";
            // 
            // geometricType
            // 
            this.geometricType.BackColor = System.Drawing.SystemColors.Window;
            this.geometricType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.geometricType.Location = new System.Drawing.Point(6, 6);
            this.geometricType.Name = "geometricType";
            this.geometricType.ReadOnly = true;
            this.geometricType.Size = new System.Drawing.Size(309, 16);
            this.geometricType.TabIndex = 1;
            this.geometricType.Text = "Fractal type";
            // 
            // geometricTypeSelect
            // 
            this.geometricTypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.geometricTypeSelect.FormattingEnabled = true;
            this.geometricTypeSelect.Items.AddRange(new object[] {
            "Koch Curve",
            "Hilbert Curve",
            "Sierpinski Curve",
            "Sierpinski Triangle",
            "Harter Dragon",
            "Bush"});
            this.geometricTypeSelect.Location = new System.Drawing.Point(6, 29);
            this.geometricTypeSelect.Name = "geometricTypeSelect";
            this.geometricTypeSelect.Size = new System.Drawing.Size(309, 23);
            this.geometricTypeSelect.TabIndex = 0;
            this.geometricTypeSelect.SelectedIndexChanged += new System.EventHandler(this.GeometricTypeChanged);
            // 
            // dynamicFractals
            // 
            this.dynamicFractals.Controls.Add(this.dynamicSettings);
            this.dynamicFractals.Controls.Add(this.dynamicTypeSelect);
            this.dynamicFractals.Controls.Add(this.dynamicType);
            this.dynamicFractals.Location = new System.Drawing.Point(4, 24);
            this.dynamicFractals.Name = "dynamicFractals";
            this.dynamicFractals.Padding = new System.Windows.Forms.Padding(3);
            this.dynamicFractals.Size = new System.Drawing.Size(321, 383);
            this.dynamicFractals.TabIndex = 1;
            this.dynamicFractals.Text = "Dynamic";
            this.dynamicFractals.UseVisualStyleBackColor = true;
            // 
            // dynamicSettings
            // 
            this.dynamicSettings.Location = new System.Drawing.Point(7, 71);
            this.dynamicSettings.Name = "dynamicSettings";
            this.dynamicSettings.Size = new System.Drawing.Size(308, 23);
            this.dynamicSettings.TabIndex = 4;
            this.dynamicSettings.Text = "Settings";
            this.dynamicSettings.UseVisualStyleBackColor = true;
            this.dynamicSettings.Click += new System.EventHandler(this.DynamicSettingsOpen);
            // 
            // dynamicTypeSelect
            // 
            this.dynamicTypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dynamicTypeSelect.FormattingEnabled = true;
            this.dynamicTypeSelect.Items.AddRange(new object[] {
            "Julia Set",
            "Newton Fractal"});
            this.dynamicTypeSelect.Location = new System.Drawing.Point(6, 28);
            this.dynamicTypeSelect.Name = "dynamicTypeSelect";
            this.dynamicTypeSelect.Size = new System.Drawing.Size(309, 23);
            this.dynamicTypeSelect.TabIndex = 3;
            // 
            // dynamicType
            // 
            this.dynamicType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dynamicType.Location = new System.Drawing.Point(6, 6);
            this.dynamicType.Name = "dynamicType";
            this.dynamicType.Size = new System.Drawing.Size(312, 16);
            this.dynamicType.TabIndex = 2;
            this.dynamicType.Text = "Fractal type";
            // 
            // stochasticFractals
            // 
            this.stochasticFractals.Controls.Add(this.stochasticPlasma);
            this.stochasticFractals.Controls.Add(this.stochasticFractalTree);
            this.stochasticFractals.Location = new System.Drawing.Point(4, 24);
            this.stochasticFractals.Name = "stochasticFractals";
            this.stochasticFractals.Size = new System.Drawing.Size(321, 383);
            this.stochasticFractals.TabIndex = 2;
            this.stochasticFractals.Text = "Stochastic";
            this.stochasticFractals.UseVisualStyleBackColor = true;
            // 
            // stochasticPlasma
            // 
            this.stochasticPlasma.AutoSize = true;
            this.stochasticPlasma.Location = new System.Drawing.Point(19, 46);
            this.stochasticPlasma.Name = "stochasticPlasma";
            this.stochasticPlasma.Size = new System.Drawing.Size(67, 19);
            this.stochasticPlasma.TabIndex = 1;
            this.stochasticPlasma.Text = "Plasma";
            this.stochasticPlasma.UseVisualStyleBackColor = true;
            // 
            // stochasticFractalTree
            // 
            this.stochasticFractalTree.AutoSize = true;
            this.stochasticFractalTree.Checked = true;
            this.stochasticFractalTree.Location = new System.Drawing.Point(19, 21);
            this.stochasticFractalTree.Name = "stochasticFractalTree";
            this.stochasticFractalTree.Size = new System.Drawing.Size(138, 19);
            this.stochasticFractalTree.TabIndex = 0;
            this.stochasticFractalTree.TabStop = true;
            this.stochasticFractalTree.Text = "Fractal tree";
            this.stochasticFractalTree.UseVisualStyleBackColor = true;
            // 
            // fractalColorDialog
            // 
            this.fractalColorDialog.AnyColor = true;
            this.fractalColorDialog.FullOpen = true;
            // 
            // fieldColorDialog
            // 
            this.fieldColorDialog.AnyColor = true;
            this.fieldColorDialog.FullOpen = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 563);
            this.Controls.Add(this.selectType);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.fieldColor);
            this.Controls.Add(this.fractalColor);
            this.Controls.Add(this.drawFractal);
            this.Name = "MainWindow";
            this.Text = "Fractals";
            this.Load += new System.EventHandler(this.PreRenderEvent);
            ((System.ComponentModel.ISupportInitialize)(this.outputBox)).EndInit();
            this.selectType.ResumeLayout(false);
            this.geometricFractals.ResumeLayout(false);
            this.geometricFractals.PerformLayout();
            this.dynamicFractals.ResumeLayout(false);
            this.dynamicFractals.PerformLayout();
            this.stochasticFractals.ResumeLayout(false);
            this.stochasticFractals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawFractal;
        private System.Windows.Forms.Button fractalColor;
        private System.Windows.Forms.Button fieldColor;
        private System.Windows.Forms.PictureBox outputBox;
        private System.Windows.Forms.TabControl selectType;
        private System.Windows.Forms.TabPage geometricFractals;
        private System.Windows.Forms.TabPage dynamicFractals;
        private System.Windows.Forms.TabPage stochasticFractals;
        private System.Windows.Forms.TextBox geometricType;
        private System.Windows.Forms.ComboBox geometricTypeSelect;
        private System.Windows.Forms.ComboBox geometricAmountOfIterationsSelect;
        private System.Windows.Forms.TextBox geometricAmountOfIterations;
        private System.Windows.Forms.ComboBox dynamicTypeSelect;
        private System.Windows.Forms.TextBox dynamicType;
        private System.Windows.Forms.Button dynamicSettings;
        private System.Windows.Forms.RadioButton stochasticPlasma;
        private System.Windows.Forms.RadioButton stochasticFractalTree;
        private System.Windows.Forms.ColorDialog fractalColorDialog;
        private System.Windows.Forms.ColorDialog fieldColorDialog;
    }
}

