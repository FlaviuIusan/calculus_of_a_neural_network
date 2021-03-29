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
    public partial class FormInformationNeuronWeight : Form
    {
        Neuron neuron;
        List<Neuron> neuroni;
        public FormInformationNeuronWeight(Neuron neuron, List<Neuron> neuroni)
        {
            InitializeComponent();
            this.neuron = neuron;
            this.neuroni = neuroni;
            Point pointLabel = new Point(10, 15);
            Point pointNumericUpDown = new Point(100, 12);
            for(int i=0; i<this.neuron.numarInputs; ++i)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Text += "Weight input " + i + ":";
                label.Location = pointLabel;
                this.Controls.Add(label);
                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Size = new Size(45, 10);
                numericUpDown.Location = pointNumericUpDown;
                numericUpDown.Minimum = -100;
                numericUpDown.Increment = (decimal)0.01;
                numericUpDown.DecimalPlaces = 2;
                numericUpDown.Value = (decimal)neuron.weights[i];
                numericUpDown.ValueChanged += UpdateWeight;
                numericUpDown.Tag = i;
                this.Controls.Add(numericUpDown);
                pointLabel.Y += 50;
                pointNumericUpDown.Y += 50;
            }

            Button button = new Button();
            button.Text = "Ok";
            button.Click += ButtonOkClicked;
            button.Location = new Point(pointLabel.X + 35, pointLabel.Y);
            this.Controls.Add(button);
        }

        private void UpdateWeight(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            int numar = (int)numericUpDown.Tag;
            neuron.weights[numar] = (double)numericUpDown.Value;
        }

        private void ButtonOkClicked(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            for (int i = 0; i < neuroni.Count; ++i)
            {
                neuroni[i].Calculeaza();
            }
        }
    }
}
