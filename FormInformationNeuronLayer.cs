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
    public partial class FormInformationNeuronLayer : Form
    {
        Neuron neuron;
        public FormInformationNeuronLayer(Neuron neuron)
        {
            InitializeComponent();
            this.neuron = neuron;
            Console.WriteLine(this.neuron.functieInputValue.ToString() + " " + this.neuron.functieActivareValue.ToString() + " " + this.neuron.functieOutputValue.ToString());
            this.textBoxFunctieInput.Text = this.neuron.functieInputValue.ToString("N35");
            this.textBoxFunctieActivare.Text = this.neuron.functieActivareValue.ToString("N35");
            this.textBoxFunctieOutput.Text = this.neuron.functieOutputValue.ToString("N35");
        }
    }
}
