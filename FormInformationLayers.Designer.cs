namespace Proiect2
{
    partial class FormInformationLayers
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
            this.labelInputFunction = new System.Windows.Forms.Label();
            this.comboBoxFunctieInput = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelActivationFunction = new System.Windows.Forms.Label();
            this.labelOutputFunction = new System.Windows.Forms.Label();
            this.comboBoxFunctieActivare = new System.Windows.Forms.ComboBox();
            this.comboBoxFunctieOutput = new System.Windows.Forms.ComboBox();
            this.labelTeta = new System.Windows.Forms.Label();
            this.labelAlfa = new System.Windows.Forms.Label();
            this.numericUpDownTeta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAlfa = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlfa)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInputFunction
            // 
            this.labelInputFunction.AutoSize = true;
            this.labelInputFunction.Location = new System.Drawing.Point(12, 9);
            this.labelInputFunction.Name = "labelInputFunction";
            this.labelInputFunction.Size = new System.Drawing.Size(78, 13);
            this.labelInputFunction.TabIndex = 0;
            this.labelInputFunction.Text = "Input Function:";
            // 
            // comboBoxFunctieInput
            // 
            this.comboBoxFunctieInput.FormattingEnabled = true;
            this.comboBoxFunctieInput.Items.AddRange(new object[] {
            "Suma",
            "Produs",
            "Max",
            "Min"});
            this.comboBoxFunctieInput.Location = new System.Drawing.Point(163, 6);
            this.comboBoxFunctieInput.Name = "comboBoxFunctieInput";
            this.comboBoxFunctieInput.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFunctieInput.TabIndex = 1;
            this.comboBoxFunctieInput.Text = "Suma";
            this.comboBoxFunctieInput.TextChanged += new System.EventHandler(this.comboBoxFunctieInput_TextChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(96, 266);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelActivationFunction
            // 
            this.labelActivationFunction.AutoSize = true;
            this.labelActivationFunction.Location = new System.Drawing.Point(12, 62);
            this.labelActivationFunction.Name = "labelActivationFunction";
            this.labelActivationFunction.Size = new System.Drawing.Size(101, 13);
            this.labelActivationFunction.TabIndex = 3;
            this.labelActivationFunction.Text = "Activation Function:";
            // 
            // labelOutputFunction
            // 
            this.labelOutputFunction.AutoSize = true;
            this.labelOutputFunction.Location = new System.Drawing.Point(12, 177);
            this.labelOutputFunction.Name = "labelOutputFunction";
            this.labelOutputFunction.Size = new System.Drawing.Size(86, 13);
            this.labelOutputFunction.TabIndex = 4;
            this.labelOutputFunction.Text = "Output Function:";
            // 
            // comboBoxFunctieActivare
            // 
            this.comboBoxFunctieActivare.FormattingEnabled = true;
            this.comboBoxFunctieActivare.Items.AddRange(new object[] {
            "Liniara",
            "Semn",
            "Sigmoidala",
            "Treapta",
            "Tangenta"});
            this.comboBoxFunctieActivare.Location = new System.Drawing.Point(163, 59);
            this.comboBoxFunctieActivare.Name = "comboBoxFunctieActivare";
            this.comboBoxFunctieActivare.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFunctieActivare.TabIndex = 5;
            this.comboBoxFunctieActivare.Text = "Liniara";
            this.comboBoxFunctieActivare.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunctieActivare_SelectedIndexChanged);
            // 
            // comboBoxFunctieOutput
            // 
            this.comboBoxFunctieOutput.FormattingEnabled = true;
            this.comboBoxFunctieOutput.Items.AddRange(new object[] {
            "Real",
            "Binar"});
            this.comboBoxFunctieOutput.Location = new System.Drawing.Point(163, 174);
            this.comboBoxFunctieOutput.Name = "comboBoxFunctieOutput";
            this.comboBoxFunctieOutput.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFunctieOutput.TabIndex = 6;
            this.comboBoxFunctieOutput.Text = "Real";
            this.comboBoxFunctieOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunctieOutput_SelectedIndexChanged);
            // 
            // labelTeta
            // 
            this.labelTeta.AutoSize = true;
            this.labelTeta.Location = new System.Drawing.Point(32, 117);
            this.labelTeta.Name = "labelTeta";
            this.labelTeta.Size = new System.Drawing.Size(16, 13);
            this.labelTeta.TabIndex = 7;
            this.labelTeta.Text = "θ:";
            // 
            // labelAlfa
            // 
            this.labelAlfa.AutoSize = true;
            this.labelAlfa.Location = new System.Drawing.Point(190, 117);
            this.labelAlfa.Name = "labelAlfa";
            this.labelAlfa.Size = new System.Drawing.Size(17, 13);
            this.labelAlfa.TabIndex = 8;
            this.labelAlfa.Text = "α:";
            // 
            // numericUpDownTeta
            // 
            this.numericUpDownTeta.DecimalPlaces = 2;
            this.numericUpDownTeta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownTeta.Location = new System.Drawing.Point(64, 115);
            this.numericUpDownTeta.Name = "numericUpDownTeta";
            this.numericUpDownTeta.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownTeta.TabIndex = 9;
            this.numericUpDownTeta.ValueChanged += new System.EventHandler(this.numericUpDownTeta_ValueChanged);
            // 
            // numericUpDownAlfa
            // 
            this.numericUpDownAlfa.DecimalPlaces = 2;
            this.numericUpDownAlfa.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownAlfa.Location = new System.Drawing.Point(224, 115);
            this.numericUpDownAlfa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAlfa.Name = "numericUpDownAlfa";
            this.numericUpDownAlfa.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownAlfa.TabIndex = 10;
            this.numericUpDownAlfa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAlfa.ValueChanged += new System.EventHandler(this.numericUpDownAlfa_ValueChanged);
            // 
            // FormInformationLayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 315);
            this.Controls.Add(this.numericUpDownAlfa);
            this.Controls.Add(this.numericUpDownTeta);
            this.Controls.Add(this.labelAlfa);
            this.Controls.Add(this.labelTeta);
            this.Controls.Add(this.comboBoxFunctieOutput);
            this.Controls.Add(this.comboBoxFunctieActivare);
            this.Controls.Add(this.labelOutputFunction);
            this.Controls.Add(this.labelActivationFunction);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxFunctieInput);
            this.Controls.Add(this.labelInputFunction);
            this.Name = "FormInformationLayers";
            this.Text = "FormInformationLayers";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInputFunction;
        private System.Windows.Forms.ComboBox comboBoxFunctieInput;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelActivationFunction;
        private System.Windows.Forms.Label labelOutputFunction;
        private System.Windows.Forms.ComboBox comboBoxFunctieActivare;
        private System.Windows.Forms.ComboBox comboBoxFunctieOutput;
        private System.Windows.Forms.Label labelTeta;
        private System.Windows.Forms.Label labelAlfa;
        private System.Windows.Forms.NumericUpDown numericUpDownTeta;
        private System.Windows.Forms.NumericUpDown numericUpDownAlfa;
    }
}