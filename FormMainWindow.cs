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
    public partial class FormMainWindow : Form
    {
        public int numarNeuroniInput;
        public int numarNeuroniOutput;
        public int numarHiddenLayers;
        public int[] numarNeuroniHiddenLayers = new int[3];
        public Point[,] points = new Point[5, 20];
        public List<Neuron> neuroni = new List<Neuron>();
        public FormMainWindow()
        {
            InitializeComponent();
        }
        private void buttonCreateNew_Click(object sender, EventArgs e)
        {
            FormCreateNew formCreateNew = new FormCreateNew(this);
            formCreateNew.Show();
        }

        private void ClickNeuron(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Neuron neuron = (Neuron)label.Tag;
            neuron.Calculeaza();
            FormInformationNeuronLayer form = new FormInformationNeuronLayer(neuron);
            form.Text = label.Text;
            form.Show();
            Console.WriteLine("Neuron:" + "Inputs: " + neuron.inputs.Length + " Functie input: " + neuron.functieInput + " Functie activare: " + neuron.functieActivare + " Functie output: " + neuron.functieOutput + " Valoare teta: " + neuron.valoareTeta + " Valoare alfa: " + neuron.valoareAlfa);
        }

        private void ClickWeight(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Neuron neuron = (Neuron)label.Tag;
            FormInformationNeuronWeight form = new FormInformationNeuronWeight(neuron, this.neuroni);
            form.Text = label.Text + " L" + neuron.layer + "N" + neuron.numar;
            if (neuron.layer == numarHiddenLayers)
            {
                form.Text = label.Text + " LOutput" + "N" + neuron.numar;
            }
            form.Show();
        }

        private void Deseneaza(object sender, PaintEventArgs e)
        {
            for(int i=0; i<5; ++i)
            {
                for(int j=0; j<20; ++j)
                {
                    for(int k=0; k<20; ++k)
                    {
                        {
                            try
                            {
                                if (points[i, j].X != 0 && points[i + 1, k].X != 0)
                                {
                                    Console.WriteLine("Punct de la:" + points[i, j].ToString());
                                    Console.WriteLine("Punct la:" + points[i + 1, k].ToString());
                                    e.Graphics.DrawLine(Pens.Black, points[i, j].X + 50, points[i, j].Y + 10, points[i + 1, k].X, points[i + 1, k].Y + 10);
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                        
                    }
                }
            }

            Console.WriteLine("Desenat");
        }

        private void NeuronInputValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            Neuron neuron = (Neuron)numericUpDown.Tag;
            neuron.functieOutputValue = (double)numericUpDown.Value;
            for (int i = 0; i < neuroni.Count; ++i)
            {
                this.neuroni[i].Calculeaza();
            }
        }

        public void MetodaApelataDeCreate()
        {
            Console.WriteLine("Input" + numarNeuroniInput.ToString());
            Console.WriteLine("Output" + numarNeuroniOutput.ToString());
            Console.WriteLine("HiddenLayers" + numarHiddenLayers.ToString());
            Console.WriteLine("Layer1" + numarNeuroniHiddenLayers[0].ToString());
            Console.WriteLine("Layer2" + numarNeuroniHiddenLayers[1].ToString());
            Console.WriteLine("Layer3" + numarNeuroniHiddenLayers[2].ToString());

            if (numarHiddenLayers == 1)
            {
                this.buttonLayer1.Visible = true;
                this.buttonLayer2.Visible = false;
                this.buttonLayer3.Visible = false;
                this.buttonOutput.Visible = true;
            }
            if (numarHiddenLayers == 2)
            {
                this.buttonLayer1.Visible = true;
                this.buttonLayer2.Visible = true;
                this.buttonLayer3.Visible = false;
                this.buttonOutput.Visible = true;
            }
            if (numarHiddenLayers == 3)
            {
                this.buttonLayer1.Visible = true;
                this.buttonLayer2.Visible = true;
                this.buttonLayer3.Visible = true;
                this.buttonOutput.Visible = true;
            }

            Point pointNumeric = new Point(100, 10);
            Point pointNeuronInput = new Point(165, 15);
            for(int i=0; i<numarNeuroniInput; ++i)
            {
                Neuron neuron = new Neuron(this.neuroni);
                neuron.layer = -1;
                neuron.numar = i;
                neuron.functieOutputValue = 0.01;
                neuroni.Add(neuron);
                pointNumeric.Y = pointNumeric.Y + 100;
                pointNeuronInput.Y = pointNeuronInput.Y + 100;
                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.DecimalPlaces = 2;
                numericUpDown.Value = new Decimal(0.01);
                numericUpDown.Increment = new Decimal(0.01);
                numericUpDown.Size = new Size(45, 10);
                numericUpDown.Location = pointNumeric;
                numericUpDown.Tag = neuron;
                numericUpDown.Minimum = -100;
                numericUpDown.ValueChanged += NeuronInputValueChanged;
                this.panelReprezentareNeuroni.Controls.Add(numericUpDown);
                Label label = new Label();
                label.Font = new Font("Arial", 12, FontStyle.Bold);
                label.Text = "iN" + i.ToString();
                label.BackColor = Color.LightBlue;
                label.Location = pointNeuronInput;
                label.AutoSize = true;
                this.panelReprezentareNeuroni.Controls.Add(label);
                points[0, i] = pointNeuronInput;
            }

            Point pointW = new Point(pointNeuronInput.X + 150, 10);
            Point pointNeuronLayer = new Point(pointW.X + 20, 15);
            for (int i=0; i<numarHiddenLayers; ++i)
            {
                pointW.Y = 10;
                pointNeuronLayer.Y = 15;
                
                for (int j = 0; j < numarNeuroniHiddenLayers[i]; ++j)
                {
                    Neuron neuron = new Neuron(this.neuroni);
                    neuron.layer = i;
                    neuron.numar = j;
                    if (i == 0)
                    {
                        neuron.numarInputs = numarNeuroniInput;
                    }
                    else
                    {
                        neuron.numarInputs = numarNeuroniHiddenLayers[i - 1];
                    }
                    neuron.Calculeaza();
                    neuroni.Add(neuron);
                    pointW.Y = pointW.Y + 100;
                    pointNeuronLayer.Y = pointNeuronLayer.Y + 100;
                    Label labelW = new Label();
                    labelW.Font = new Font("Arial", 8, FontStyle.Bold);
                    labelW.Text = "W";
                    labelW.Tag = neuron;
                    labelW.BackColor = Color.LightGreen;
                    labelW.Location = pointW;
                    labelW.AutoSize = true;
                    labelW.Click += new EventHandler(this.ClickWeight);
                    this.panelReprezentareNeuroni.Controls.Add(labelW);
                    Label labelNeuron = new Label();
                    labelNeuron.Font = new Font("Arial", 12, FontStyle.Bold);
                    labelNeuron.Text = "L" + i.ToString() + "N" + j.ToString();
                    labelNeuron.Tag = neuron;
                    labelNeuron.Location = pointNeuronLayer;
                    labelNeuron.AutoSize = true;
                    labelNeuron.Click += new EventHandler(this.ClickNeuron);
                    this.panelReprezentareNeuroni.Controls.Add(labelNeuron);
                    points[i + 1, j] = pointNeuronLayer;
                }
                pointW.X = pointNeuronLayer.X + 150;
                pointNeuronLayer.X = pointW.X + 20;

            }

            Point pointWOutput = new Point(pointNeuronLayer.X, 10);
            Point pointNeuronOutput = new Point(pointWOutput.X + 20, 15);
            for (int i = 0; i < numarNeuroniOutput; ++i)
            {
                Neuron neuron = new Neuron(this.neuroni);
                neuron.layer = numarHiddenLayers;
                neuron.numar = i;
                neuron.numarInputs = numarNeuroniHiddenLayers[numarHiddenLayers - 1];
                neuron.Calculeaza();
                neuroni.Add(neuron);
                pointWOutput.Y = pointWOutput.Y + 100;
                pointNeuronOutput.Y = pointNeuronOutput.Y + 100;
                Label labelW = new Label();
                labelW.Font = new Font("Arial", 8, FontStyle.Bold);
                labelW.Text = "W";
                labelW.Tag = neuron;
                labelW.BackColor = Color.LightGreen;
                labelW.Location = pointWOutput;
                labelW.AutoSize = true;
                labelW.Click += new EventHandler(this.ClickWeight);
                this.panelReprezentareNeuroni.Controls.Add(labelW);
                Label labelNeuron = new Label();
                labelNeuron.Font = new Font("Arial", 12, FontStyle.Bold);
                labelNeuron.Text = "o" + "N" + i.ToString();
                labelNeuron.Tag = neuron;
                labelNeuron.BackColor = Color.LightBlue;
                labelNeuron.Location = pointNeuronOutput;
                labelNeuron.AutoSize = true;
                labelNeuron.Click += new EventHandler(this.ClickNeuron);
                this.panelReprezentareNeuroni.Controls.Add(labelNeuron);
                points[numarHiddenLayers + 1, i] = pointNeuronOutput;
            }

            this.panelReprezentareNeuroni.Paint += Deseneaza;
            this.panelReprezentareNeuroni.Invalidate();
        }

        private void buttonLayer1_Click(object sender, EventArgs e)
        {
            FormInformationLayers formInformationLayers1 = new FormInformationLayers(0, this.neuroni);
            formInformationLayers1.Show();
            Console.WriteLine("Button1");
        }

        private void buttonLayer2_Click(object sender, EventArgs e)
        {
            FormInformationLayers formInformationLayers1 = new FormInformationLayers(1, this.neuroni);
            formInformationLayers1.Show();
            Console.WriteLine("Button2");
        }

        private void buttonLayer3_Click(object sender, EventArgs e)
        {
            FormInformationLayers formInformationLayers1 = new FormInformationLayers(2, this.neuroni);
            formInformationLayers1.Show();
            Console.WriteLine("Button3");
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            FormInformationLayers formInformationLayers1 = new FormInformationLayers(numarHiddenLayers, this.neuroni);
            formInformationLayers1.Show();
            Console.WriteLine("ButtonO");
        }
    }
}
