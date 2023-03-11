using Backprop;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_G_BackPropagation
{
    public partial class Form1 : Form
    {
        String fileName;
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void train_Click(object sender, EventArgs e)
        {

            var data = File.ReadAllLines(fileName)
                    .Skip(1) // Skip header row
                    .Select(row => row.Split(',')) // Split rows by comma
                    .Select(row => new
                    {
                        Inputs = row.Take(row.Length - 1).Select(float.Parse).ToArray(),
                        Output = float.Parse(row.Last())
                    })
                    .ToArray();

            // Create neural network
            var numInputs = data.First().Inputs.Length;
            var numOutputs = 1;
            var numHidden = 10; // Adjust as needed
            nn = new NeuralNet(numInputs, numHidden, numOutputs);

            for (int i = 0; i < Convert.ToInt32(epochs.Text); i++)
            {
                // Train neural network
                foreach (var row in data)
                {
                    nn.setInputs(0, row.Inputs[0]);
                    nn.setInputs(1, row.Inputs[1]);
                    nn.setInputs(2, row.Inputs[2]);
                    nn.setInputs(3, row.Inputs[3]);
                    nn.setInputs(4, row.Inputs[4]);
                    nn.setInputs(5, row.Inputs[5]);
                    nn.setInputs(6, row.Inputs[6]);
                    nn.setDesiredOutput(0, row.Output);
                    nn.learn();
                }
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(age.Text));
            nn.setInputs(1, Convert.ToDouble(weight.Text));
            nn.setInputs(2, Convert.ToDouble(neck.Text));
            nn.setInputs(3, Convert.ToDouble(abdomen.Text));
            nn.setInputs(4, Convert.ToDouble(thigh.Text));
            nn.setInputs(5, Convert.ToDouble(forearm.Text));
            nn.setInputs(6, Convert.ToDouble(wrist.Text));
            nn.run();

            output.Text = (nn.getOuputData(0)).ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            epochs.Text = "";
            age.Text = "";
            weight.Text = "";
            neck.Text = "";
            abdomen.Text = "";
            thigh.Text = "";
            forearm.Text = "";
            wrist.Text = "";
            output.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileName = openFileDialog1.FileName;
        }
    }
}
