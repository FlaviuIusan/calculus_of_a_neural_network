namespace Proiect2
{
    partial class FormInformationNeuronLayer
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
            this.labelFunctieInput = new System.Windows.Forms.Label();
            this.labelFunctieActivare = new System.Windows.Forms.Label();
            this.labelFunctieOutput = new System.Windows.Forms.Label();
            this.textBoxFunctieInput = new System.Windows.Forms.TextBox();
            this.textBoxFunctieActivare = new System.Windows.Forms.TextBox();
            this.textBoxFunctieOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFunctieInput
            // 
            this.labelFunctieInput.AutoSize = true;
            this.labelFunctieInput.Location = new System.Drawing.Point(13, 13);
            this.labelFunctieInput.Name = "labelFunctieInput";
            this.labelFunctieInput.Size = new System.Drawing.Size(75, 13);
            this.labelFunctieInput.TabIndex = 0;
            this.labelFunctieInput.Text = "Input function:";
            // 
            // labelFunctieActivare
            // 
            this.labelFunctieActivare.AutoSize = true;
            this.labelFunctieActivare.Location = new System.Drawing.Point(12, 71);
            this.labelFunctieActivare.Name = "labelFunctieActivare";
            this.labelFunctieActivare.Size = new System.Drawing.Size(98, 13);
            this.labelFunctieActivare.TabIndex = 1;
            this.labelFunctieActivare.Text = "Activation function:";
            // 
            // labelFunctieOutput
            // 
            this.labelFunctieOutput.AutoSize = true;
            this.labelFunctieOutput.Location = new System.Drawing.Point(12, 134);
            this.labelFunctieOutput.Name = "labelFunctieOutput";
            this.labelFunctieOutput.Size = new System.Drawing.Size(83, 13);
            this.labelFunctieOutput.TabIndex = 2;
            this.labelFunctieOutput.Text = "Output function:";
            // 
            // textBoxFunctieInput
            // 
            this.textBoxFunctieInput.Location = new System.Drawing.Point(124, 10);
            this.textBoxFunctieInput.Name = "textBoxFunctieInput";
            this.textBoxFunctieInput.ReadOnly = true;
            this.textBoxFunctieInput.Size = new System.Drawing.Size(231, 20);
            this.textBoxFunctieInput.TabIndex = 3;
            // 
            // textBoxFunctieActivare
            // 
            this.textBoxFunctieActivare.Location = new System.Drawing.Point(124, 68);
            this.textBoxFunctieActivare.Name = "textBoxFunctieActivare";
            this.textBoxFunctieActivare.ReadOnly = true;
            this.textBoxFunctieActivare.Size = new System.Drawing.Size(231, 20);
            this.textBoxFunctieActivare.TabIndex = 4;
            // 
            // textBoxFunctieOutput
            // 
            this.textBoxFunctieOutput.Location = new System.Drawing.Point(124, 131);
            this.textBoxFunctieOutput.Name = "textBoxFunctieOutput";
            this.textBoxFunctieOutput.ReadOnly = true;
            this.textBoxFunctieOutput.Size = new System.Drawing.Size(231, 20);
            this.textBoxFunctieOutput.TabIndex = 5;
            // 
            // FormInformationNeuronLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 199);
            this.Controls.Add(this.textBoxFunctieOutput);
            this.Controls.Add(this.textBoxFunctieActivare);
            this.Controls.Add(this.textBoxFunctieInput);
            this.Controls.Add(this.labelFunctieOutput);
            this.Controls.Add(this.labelFunctieActivare);
            this.Controls.Add(this.labelFunctieInput);
            this.Name = "FormInformationNeuronLayer";
            this.Text = "FormInformationNeuronLayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFunctieInput;
        private System.Windows.Forms.Label labelFunctieActivare;
        private System.Windows.Forms.Label labelFunctieOutput;
        private System.Windows.Forms.TextBox textBoxFunctieInput;
        private System.Windows.Forms.TextBox textBoxFunctieActivare;
        private System.Windows.Forms.TextBox textBoxFunctieOutput;
    }
}