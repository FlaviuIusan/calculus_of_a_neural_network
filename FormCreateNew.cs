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
    public partial class FormCreateNew : Form
    {
        private FormMainWindow formMainWindow;
        public FormCreateNew(FormMainWindow formMainWindow)
        {
            this.formMainWindow = formMainWindow;
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            formMainWindow.numarNeuroniInput = int.Parse(this.numericUpDownNeuroniInput.Value.ToString());
            formMainWindow.numarNeuroniOutput = int.Parse(this.numericUpDownNeuroniOutput.Value.ToString());
            formMainWindow.numarHiddenLayers = int.Parse(this.numericUpDownHiddenLayers.Value.ToString());
            formMainWindow.numarNeuroniHiddenLayers[0] = int.Parse(this.numericUpDownNeuroniHiddenLayer0.Value.ToString());
            formMainWindow.numarNeuroniHiddenLayers[1] = int.Parse(this.numericUpDownNeuroniHiddenLayer1.Value.ToString());
            formMainWindow.numarNeuroniHiddenLayers[2] = int.Parse(this.numericUpDownNeuroniHiddenLayer2.Value.ToString());
            formMainWindow.MetodaApelataDeCreate();
            this.Close();
        }

        private void numericUpDownNrHiddenLayers_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownHiddenLayers.Value == 1)
            {
                labelNrNeuroniHiddenLayer1.Visible = false;
                numericUpDownNeuroniHiddenLayer1.Visible = false;
                labelNrNeuroniHiddenLayer2.Visible = false;
                numericUpDownNeuroniHiddenLayer2.Visible = false;
            }

            if (numericUpDownHiddenLayers.Value == 2)
            {
                labelNrNeuroniHiddenLayer1.Visible = true;
                numericUpDownNeuroniHiddenLayer1.Visible = true;
                labelNrNeuroniHiddenLayer2.Visible = false;
                numericUpDownNeuroniHiddenLayer2.Visible = false;
            }

            if (numericUpDownHiddenLayers.Value == 3)
            {
                labelNrNeuroniHiddenLayer1.Visible = true;
                numericUpDownNeuroniHiddenLayer1.Visible = true;
                labelNrNeuroniHiddenLayer2.Visible = true;
                numericUpDownNeuroniHiddenLayer2.Visible = true;
            }
        }
    }
}
