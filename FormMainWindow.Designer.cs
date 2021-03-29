namespace Proiect2
{
    partial class FormMainWindow
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
            this.buttonCreateNew = new System.Windows.Forms.Button();
            this.panelReprezentareNeuroni = new System.Windows.Forms.Panel();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonLayer1 = new System.Windows.Forms.Button();
            this.buttonLayer2 = new System.Windows.Forms.Button();
            this.buttonLayer3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateNew
            // 
            this.buttonCreateNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonCreateNew.Location = new System.Drawing.Point(434, 404);
            this.buttonCreateNew.Name = "buttonCreateNew";
            this.buttonCreateNew.Size = new System.Drawing.Size(97, 34);
            this.buttonCreateNew.TabIndex = 0;
            this.buttonCreateNew.Text = "Create new neural network";
            this.buttonCreateNew.UseVisualStyleBackColor = true;
            this.buttonCreateNew.Click += new System.EventHandler(this.buttonCreateNew_Click);
            // 
            // panelReprezentareNeuroni
            // 
            this.panelReprezentareNeuroni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReprezentareNeuroni.Location = new System.Drawing.Point(12, 42);
            this.panelReprezentareNeuroni.Name = "panelReprezentareNeuroni";
            this.panelReprezentareNeuroni.Size = new System.Drawing.Size(1007, 356);
            this.panelReprezentareNeuroni.TabIndex = 1;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(319, 13);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(96, 23);
            this.buttonOutput.TabIndex = 2;
            this.buttonOutput.Text = "Output";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Visible = false;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // buttonLayer1
            // 
            this.buttonLayer1.Location = new System.Drawing.Point(12, 13);
            this.buttonLayer1.Name = "buttonLayer1";
            this.buttonLayer1.Size = new System.Drawing.Size(96, 23);
            this.buttonLayer1.TabIndex = 3;
            this.buttonLayer1.Text = "Layer1";
            this.buttonLayer1.UseVisualStyleBackColor = true;
            this.buttonLayer1.Visible = false;
            this.buttonLayer1.Click += new System.EventHandler(this.buttonLayer1_Click);
            // 
            // buttonLayer2
            // 
            this.buttonLayer2.Location = new System.Drawing.Point(114, 13);
            this.buttonLayer2.Name = "buttonLayer2";
            this.buttonLayer2.Size = new System.Drawing.Size(96, 23);
            this.buttonLayer2.TabIndex = 4;
            this.buttonLayer2.Text = "Layer2";
            this.buttonLayer2.UseVisualStyleBackColor = true;
            this.buttonLayer2.Visible = false;
            this.buttonLayer2.Click += new System.EventHandler(this.buttonLayer2_Click);
            // 
            // buttonLayer3
            // 
            this.buttonLayer3.Location = new System.Drawing.Point(216, 13);
            this.buttonLayer3.Name = "buttonLayer3";
            this.buttonLayer3.Size = new System.Drawing.Size(96, 23);
            this.buttonLayer3.TabIndex = 4;
            this.buttonLayer3.Text = "Layer3";
            this.buttonLayer3.UseVisualStyleBackColor = true;
            this.buttonLayer3.Visible = false;
            this.buttonLayer3.Click += new System.EventHandler(this.buttonLayer3_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 450);
            this.Controls.Add(this.buttonLayer2);
            this.Controls.Add(this.buttonLayer3);
            this.Controls.Add(this.buttonLayer1);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.panelReprezentareNeuroni);
            this.Controls.Add(this.buttonCreateNew);
            this.Name = "FormMainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateNew;
        private System.Windows.Forms.Panel panelReprezentareNeuroni;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonLayer1;
        private System.Windows.Forms.Button buttonLayer2;
        private System.Windows.Forms.Button buttonLayer3;
    }
}

