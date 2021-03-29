using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect2
{
    public class Neuron
    {
        public int numarInputs;
        public double[] weights = new double[20];
        public double[] inputs = new double[20];
        public double[] inputsCalculat = new double[20];
        public int layer;
        public int numar;
        public string functieInput = "Suma";
        public string functieActivare = "Liniara";
        public string functieOutput = "Real";
        public double functieInputValue = 0;
        public double functieActivareValue = 0;
        public double functieOutputValue = 0;
        public double valoareTeta = 0;
        public double valoareAlfa = 1;
        public List<Neuron> neuroni;

        public Neuron(List<Neuron> neuroni)
        {
            this.neuroni = neuroni;
            for(int i=0; i<weights.Length; ++i)
            {
                this.weights[i] = 0.00;
            }
        }

        public void Calculeaza()
        {
            if (this.layer == -1)
                return;
            Console.WriteLine("Neuron" + this.layer + this.numar + "calculat");
            for(int i=0; i<this.neuroni.Count; ++i)
            {
                if (neuroni[i].layer == this.layer - 1)
                {
                    this.inputs[neuroni[i].numar] = neuroni[i].functieOutputValue;
                    Console.WriteLine("Gasit input" + neuroni[i].layer + neuroni[i].numar + "Cu output:" +neuroni[i].functieOutputValue + " Schimbat actual:" + this.inputs[i]);
                }
            }

            for (int i = 0; i < this.numarInputs; ++i)
            {
                Console.WriteLine(this.inputs[i]);
            }

            for(int i=0; i<this.numarInputs; ++i)
            {
                inputsCalculat[i] = this.inputs[i] * this.weights[i];
            }

            switch (functieInput)
            {
                case "Suma":
                    this.functieInputValue = 0;
                    for (int i = 0; i < this.numarInputs; ++i)
                    {
                        functieInputValue += this.inputsCalculat[i];
                    }
                    break;
                case "Produs":
                    this.functieInputValue = 1;
                    for (int i = 0; i < this.numarInputs; ++i)
                    {
                        functieInputValue *= this.inputsCalculat[i];
                    }
                    break;
                case "Max":
                    this.functieInputValue = -100000;
                    for (int i = 0; i < this.numarInputs; ++i)
                    {
                        if (this.inputsCalculat[i] > this.functieInputValue)
                            this.functieInputValue = this.inputsCalculat[i];
                    }
                    break;
                case "Min":
                    this.functieInputValue = 100000;
                    for (int i = 0; i < this.numarInputs; ++i)
                    {
                        if (this.inputsCalculat[i] < this.functieInputValue)
                            this.functieInputValue = this.inputsCalculat[i];
                    }
                    break;
                default:
                    break;

            }

            double e = 2.71;
            switch (functieActivare)
            {
                case "Liniara":
                    if (this.functieInputValue - this.valoareTeta < (-1) / this.valoareAlfa)
                        this.functieActivareValue = -1;
                    else
                        this.functieActivareValue = 1;
                    break;
                case "Semn":
                    if(this.functieInputValue - this.valoareTeta >= this.valoareTeta)
                        this.functieActivareValue = 1;
                    else
                        this.functieActivareValue = -1;
                    break;
                case "Sigmoidala":
                    this.functieActivareValue = 1 / (1 + Math.Pow(e, this.valoareAlfa * (-1) * (this.functieInputValue - this.valoareTeta - this.valoareTeta)));
                    break;
                case "Treapta":
                    if (this.functieInputValue - this.valoareTeta >= this.valoareTeta)
                        this.functieActivareValue = 1;
                    else
                        this.functieActivareValue = 0;
                    break;
                case "Tangenta":
                    this.functieActivareValue = (Math.Pow(e, this.valoareAlfa * (this.functieInputValue - this.valoareTeta - this.valoareTeta)) - Math.Pow(e, -this.valoareAlfa * (this.functieInputValue - this.valoareTeta - this.valoareTeta))) / (Math.Pow(e, this.valoareAlfa * (this.functieInputValue - this.valoareTeta - this.valoareTeta)) + Math.Pow(e, -this.valoareAlfa * (this.functieInputValue - this.valoareTeta - this.valoareTeta)));
                    break;
                default:
                    break;
            }

            if (this.functieOutput == "Binar")
            {
                if (this.functieActivare == "Sigmoidala" && this.functieActivare == "Treapta")
                {
                    if (this.functieActivareValue >= 0.5)
                        this.functieOutputValue = 1;
                    else
                        this.functieOutputValue = 0;
                }
                if (this.functieActivare == "Tangenta" && this.functieActivare == "Liniara" && this.functieActivare == "Semn")
                {
                    if (this.functieActivareValue > 0)
                        this.functieOutputValue = 1;
                    else
                        this.functieOutputValue = -1;
                }
            }
            else
                this.functieOutputValue = this.functieActivareValue;

        }

        public void Update()
        {

        }
    }
}
