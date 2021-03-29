namespace Proiect2
{
    partial class FormCreateNew
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
            this.labelNrNeuroniInput = new System.Windows.Forms.Label();
            this.numericUpDownNeuroniInput = new System.Windows.Forms.NumericUpDown();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelNrNeuroniOutput = new System.Windows.Forms.Label();
            this.numericUpDownNeuroniOutput = new System.Windows.Forms.NumericUpDown();
            this.labelNrHiddenLayers = new System.Windows.Forms.Label();
            this.numericUpDownHiddenLayers = new System.Windows.Forms.NumericUpDown();
            this.panelNrNeuroniHiddenLayers = new System.Windows.Forms.Panel();
            this.numericUpDownNeuroniHiddenLayer2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNeuroniHiddenLayer1 = new System.Windows.Forms.NumericUpDown();
            this.labelNrNeuroniHiddenLayer2 = new System.Windows.Forms.Label();
            this.labelNrNeuroniHiddenLayer1 = new System.Windows.Forms.Label();
            this.numericUpDownNeuroniHiddenLayer0 = new System.Windows.Forms.NumericUpDown();
            this.labelNrNeuroniHiddenLayer0 = new System.Windows.Forms.Label();
            this.labelHiddenLayers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuroniInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuroniOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHiddenLayers)).BeginInit();
            this.panelNrNeuroniHiddenLayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuroniHiddenLayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuroniHiddenLayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuroniHiddenLayer0)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNrNeuroniInput
            // 
            this.labelNrNeuroniInput.AutoSize = true;
            this.labelNrNeuroniInput.Location = new System.Drawing.Point(12, 9);
            this.labelNrNeuroniInput.Name = "labelNrNeuroniInput";
            this.labelNrNeuroniInput.Size = new System.Drawing.Size(130, 13);
            this.labelNrNeuroniInput.TabIndex = 0;
            this.labelNrNeuroniInput.Text = "Numar neuroni input layer:";
            // 
            // numericUpDownNeuroniInput
            // 
            this.numericUpDownNeuroniInput.Location = new System.Drawing.Point(189, 7);
            this.numericUpDownNeuroniInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNeuroniInput.Name = "numericUpDownNeuroniInput";
            this.numericUpDownNeuroniInput.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownNeuroniInput.TabIndex = 1;
            this.numericUpDownNeuroniInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(85, 244);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelNrNeuroniOutput
            // 
            this.labelNrNeuroniOutput.AutoSize = true;
            this.labelNrNeuroniOutput.Location = new System.Drawing.Point(12, 48);
            this.labelNrNeuroniOutput.Name = "labelNrNeuroniOutput";
            this.labelNrNeuroniOutput.Size = new System.Drawing.Size(137, 13);
            this.labelNrNeuroniOutput.TabIndex = 3;
            this.labelNrNeuroniOutput.Text = "Numar neuroni output layer:";
            // 
            // numericUpDownNeuroniOutput
            // 
            this.numericUpDownNeuroniOutput.Location = new System.Drawing.Point(189, 46);
            this.numericUpDownNeuroniOutput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNeuroniOutput.Name = "numericUpDownNeuroniOutput";
            this.numericUpDownNeuroniOutput.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownNeuroniOutput.TabIndex = 4;
            this.numericUpDownNeuroniOutput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNrHiddenLayers
            // 
            this.labelNrHiddenLayers.AutoSize = true;
            this.labelNrHiddenLayers.Location = new System.Drawing.Point(12, 86);
            this.labelNrHiddenLayers.Name = "labelNrHiddenLayers";
            this.labelNrHiddenLayers.Size = new System.Drawing.Size(106, 13);
            this.labelNrHiddenLayers.TabIndex = 5;
            this.labelNrHiddenLayers.Text = "Numar hidden layers:";
            // 
            // numericUpDownHiddenLayers
            // 
            this.numericUpDownHiddenLayers.Location = new System.Drawing.Point(189, 84);
            this.numericUpDownHiddenLayers.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownHiddenLayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHiddenLayers.Name = "numericUpDownHiddenLayers";
            this.numericUpDownHiddenLayers.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownHiddenLayers.TabIndex = 6;
            this.numericUpDownHiddenLayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHiddenLayers.ValueChanged += new System.EventHandler(this.numericUpDownNrHiddenLayers_ValueChanged);
            // 
            // panelNrNeuroniHiddenLayers
            // 
            this.panelNrNeuroniHiddenLayers.Controls.Add(this.numericUpDownNeuroniHiddenLayer2);
            this.panelNrNeuroniHiddenLayers.Controls.Add(this.numericUpDownNeuroniHiddenLayer1);
            this.panelNrNeuroniHiddenLayers.Controls.Add(this.labelNrNeuroniHiddenLayer2);
            this.panelNrNeuroniHiddenLayers.Controls.Add(this.labelNrNeuroniHiddenLayer1);
            this.panelNrNeuroniHiddenLayers.Controls.Add(this.numericUpDownNeuroniHiddenLayer0);
            this.panelNrNeuroniHiddenLayers.Controls.Add(this.labelNrNeuroniHiddenLayer0);
            this.panelNrNeuroniHiddenLayers.Location = new System.Drawing.Point(15, 138);
            this.panelNrNeuroniHiddenLayers.Name = "panelNrNeuroniHiddenLayers";
            this.panelNrNeuroniHiddenLayers.Size = new System.Drawing.Size(218, 100);
            this.panelNrNeuroniHiddenLayers.TabIndex = 7;
            // 
            // numericUpDownNeuroniHiddenLayer2
            // 
            this.numericUpDownNeuroniHiddenLayer2.Location = new System.Drawing.Point(174, 73);
            this.numericUpDownNeuroniHiddenLayer2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNeuroniHiddenLayer2.Name = "numericUpDownNeuroniHiddenLayer2";
            this.numericUpDownNeuroniHiddenLayer2.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownNeuroniHiddenLayer2.TabIndex = 13;
            this.numericUpDownNeuroniHiddenLayer2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNeuroniHiddenLayer2.Visible = false;
            // 
            // numericUpDownNeuroniHiddenLayer1
            // 
            this.numericUpDownNeuroniHiddenLayer1.Location = new System.Drawing.Point(174, 40);
            this.numericUpDownNeuroniHiddenLayer1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNeuroniHiddenLayer1.Name = "numericUpDownNeuroniHiddenLayer1";
            this.numericUpDownNeuroniHiddenLayer1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownNeuroniHiddenLayer1.TabIndex = 12;
            this.numericUpDownNeuroniHiddenLayer1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNeuroniHiddenLayer1.Visible = false;
            // 
            // labelNrNeuroniHiddenLayer2
            // 
            this.labelNrNeuroniHiddenLayer2.AutoSize = true;
            this.labelNrNeuroniHiddenLayer2.Location = new System.Drawing.Point(-3, 75);
            this.labelNrNeuroniHiddenLayer2.Name = "labelNrNeuroniHiddenLayer2";
            this.labelNrNeuroniHiddenLayer2.Size = new System.Drawing.Size(148, 13);
            this.labelNrNeuroniHiddenLayer2.TabIndex = 11;
            this.labelNrNeuroniHiddenLayer2.Text = "Numar neuroni hidden layer 2:";
            this.labelNrNeuroniHiddenLayer2.Visible = false;
            // 
            // labelNrNeuroniHiddenLayer1
            // 
            this.labelNrNeuroniHiddenLayer1.AutoSize = true;
            this.labelNrNeuroniHiddenLayer1.Location = new System.Drawing.Point(-3, 42);
            this.labelNrNeuroniHiddenLayer1.Name = "labelNrNeuroniHiddenLayer1";
            this.labelNrNeuroniHiddenLayer1.Size = new System.Drawing.Size(148, 13);
            this.labelNrNeuroniHiddenLayer1.TabIndex = 10;
            this.labelNrNeuroniHiddenLayer1.Text = "Numar neuroni hidden layer 1:";
            this.labelNrNeuroniHiddenLayer1.Visible = false;
            // 
            // numericUpDownNeuroniHiddenLayer0
            // 
            this.numericUpDownNeuroniHiddenLayer0.Location = new System.Drawing.Point(174, 8);
            this.numericUpDownNeuroniHiddenLayer0.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNeuroniHiddenLayer0.Name = "numericUpDownNeuroniHiddenLayer0";
            this.numericUpDownNeuroniHiddenLayer0.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownNeuroniHiddenLayer0.TabIndex = 9;
            this.numericUpDownNeuroniHiddenLayer0.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNrNeuroniHiddenLayer0
            // 
            this.labelNrNeuroniHiddenLayer0.AutoSize = true;
            this.labelNrNeuroniHiddenLayer0.Location = new System.Drawing.Point(-3, 10);
            this.labelNrNeuroniHiddenLayer0.Name = "labelNrNeuroniHiddenLayer0";
            this.labelNrNeuroniHiddenLayer0.Size = new System.Drawing.Size(148, 13);
            this.labelNrNeuroniHiddenLayer0.TabIndex = 0;
            this.labelNrNeuroniHiddenLayer0.Text = "Numar neuroni hidden layer 0:";
            // 
            // labelHiddenLayers
            // 
            this.labelHiddenLayers.AutoSize = true;
            this.labelHiddenLayers.Location = new System.Drawing.Point(12, 122);
            this.labelHiddenLayers.Name = "labelHiddenLayers";
            this.labelHiddenLayers.Size = new System.Drawing.Size(74, 13);
            this.labelHiddenLayers.TabIndex = 8;
            this.labelHiddenLayers.Text = "Hidden layers:";
            // 
            // FormCreateNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 274);
            this.Controls.Add(this.labelHiddenLayers);
            this.Controls.Add(this.panelNrNeuroniHiddenLayers);
            this.Controls.Add(this.numericUpDownHiddenLayers);
            this.Controls.Add(this.labelNrHiddenLayers);
            this.Controls.Add(this.numericUpDownNeuroniOutput);
            this.Controls.Add(this.labelNrNeuroniOutput);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.numericUpDownNeuroniInput);
            this.Controls.Add(this.labelNrNeuroniInput);
            this.Name = "FormCreateNew";
            this.Text = "FormCreateNew";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuroniInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuroniOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHiddenLayers)).EndInit();
            this.panelNrNeuroniHiddenLayers.ResumeLayout(false);
            this.panelNrNeuroniHiddenLayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuroniHiddenLayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuroniHiddenLayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNeuroniHiddenLayer0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNrNeuroniInput;
        private System.Windows.Forms.NumericUpDown numericUpDownNeuroniInput;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelNrNeuroniOutput;
        private System.Windows.Forms.NumericUpDown numericUpDownNeuroniOutput;
        private System.Windows.Forms.Label labelNrHiddenLayers;
        private System.Windows.Forms.NumericUpDown numericUpDownHiddenLayers;
        private System.Windows.Forms.Panel panelNrNeuroniHiddenLayers;
        private System.Windows.Forms.Label labelHiddenLayers;
        private System.Windows.Forms.NumericUpDown numericUpDownNeuroniHiddenLayer0;
        private System.Windows.Forms.Label labelNrNeuroniHiddenLayer0;
        private System.Windows.Forms.NumericUpDown numericUpDownNeuroniHiddenLayer2;
        private System.Windows.Forms.NumericUpDown numericUpDownNeuroniHiddenLayer1;
        private System.Windows.Forms.Label labelNrNeuroniHiddenLayer2;
        private System.Windows.Forms.Label labelNrNeuroniHiddenLayer1;
    }
}