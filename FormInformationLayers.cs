using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect2
{
    public partial class FormInformationLayers : Form
    {
        List<Neuron> neuroni;
        public int layerNumber;
        public FormInformationLayers(int layerNumber, List<Neuron> neuroni)
        {
            InitializeComponent();
            this.layerNumber = layerNumber;
            this.Text = this.Text + layerNumber;
            this.neuroni = neuroni;
            for (int i = 0; i < neuroni.Count; ++i)
            {
                if (neuroni[i].layer == this.layerNumber)
                {
                    this.comboBoxFunctieInput.Text = this.neuroni[i].functieInput;
                    this.comboBoxFunctieActivare.Text = this.neuroni[i].functieActivare;
                    this.comboBoxFunctieOutput.Text = this.neuroni[i].functieOutput;
                    this.numericUpDownTeta.Value = (decimal)this.neuroni[i].valoareTeta;
                    this.numericUpDownAlfa.Value = (decimal)this.neuroni[i].valoareAlfa;
                    if (this.neuroni[i].functieActivare == "Sigmoidala" || this.neuroni[i].functieActivare == "Tangenta")
                        this.labelAlfa.Text = "g:";
                    break;
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            this.Close();
            this.Dispose();
            for(int i=0; i<neuroni.Count; ++i)
            {
                neuroni[i].Calculeaza();
            }
        }

        private void comboBoxFunctieInput_TextChanged(object sender, EventArgs e)
        {
            for(int i=0; i<neuroni.Count; ++i)
            {
                if(neuroni[i].layer == this.layerNumber)
                {
                    neuroni[i].functieInput = comboBoxFunctieInput.Text;
                }
            }
        }

        private void comboBoxFunctieActivare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxFunctieActivare.Text == "Sigmoidala" || this.comboBoxFunctieActivare.Text == "Tangenta")
                this.labelAlfa.Text = "g:";
            else
                this.labelAlfa.Text = "α:";

            for (int i = 0; i < neuroni.Count; ++i)
            {
                if (neuroni[i].layer == this.layerNumber)
                {
                    neuroni[i].functieActivare = comboBoxFunctieActivare.Text;
                }
            }
        }

        private void comboBoxFunctieOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < neuroni.Count; ++i)
            {
                if (neuroni[i].layer == this.layerNumber)
                {
                    neuroni[i].functieOutput = comboBoxFunctieOutput.Text;
                }
            }
        }

        private void numericUpDownTeta_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < neuroni.Count; ++i)
            {
                if (neuroni[i].layer == this.layerNumber)
                {
                    neuroni[i].valoareTeta = (double)numericUpDownTeta.Value;
                }
            }
        }

        private void numericUpDownAlfa_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < neuroni.Count; ++i)
            {
                if (neuroni[i].layer == this.layerNumber)
                {
                    neuroni[i].valoareAlfa = (double)numericUpDownAlfa.Value;
                }
            }
        }
    }
}
