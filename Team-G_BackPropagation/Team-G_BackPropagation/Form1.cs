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

        private void create_Click(object sender, EventArgs e)
        {
            
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
                //1
                nn.setInputs(0, 23);
                nn.setInputs(1, 154.25);
                nn.setInputs(2, 36.2);
                nn.setInputs(3, 82.5);
                nn.setInputs(4, 59);
                nn.setInputs(5, 27.4);
                nn.setInputs(6, 17.1);
                nn.setDesiredOutput(0, 12.3);
                nn.run();
                //2
                nn.setInputs(0, 22);
                nn.setInputs(1, 173.25);
                nn.setInputs(2, 38.5);
                nn.setInputs(3, 83);
                nn.setInputs(4, 58.7);
                nn.setInputs(5, 28.9);
                nn.setInputs(6, 18.2);
                nn.setDesiredOutput(0, 6.1);
                nn.run();
                //3
                nn.setInputs(0, 22);
                nn.setInputs(1, 154);
                nn.setInputs(2, 34);
                nn.setInputs(3, 87.9);
                nn.setInputs(4, 59.6);
                nn.setInputs(5, 25.2);
                nn.setInputs(6, 16.6);
                nn.setDesiredOutput(0, 25.3);
                nn.run();
                //4
                nn.setInputs(0, 26);
                nn.setInputs(1, 184.75);
                nn.setInputs(2, 37.4);
                nn.setInputs(3, 86.4);
                nn.setInputs(4, 60.1);
                nn.setInputs(5, 29.4);
                nn.setInputs(6, 18.2);
                nn.setDesiredOutput(0, 10.4);
                nn.run();
                //5
                nn.setInputs(0, 24);
                nn.setInputs(1, 184.25);
                nn.setInputs(2, 34.4);
                nn.setInputs(3, 100);
                nn.setInputs(4, 63.2);
                nn.setInputs(5, 27.7);
                nn.setInputs(6, 17.7);
                nn.setDesiredOutput(0, 28.7);
                nn.run();
                //6
                nn.setInputs(0, 24);
                nn.setInputs(1, 210.25);
                nn.setInputs(2, 39);
                nn.setInputs(3, 94.4);
                nn.setInputs(4, 66);
                nn.setInputs(5, 30.6);
                nn.setInputs(6, 18.8);
                nn.setDesiredOutput(0, 20.9);
                nn.run();
                //7
                nn.setInputs(0, 26);
                nn.setInputs(1, 181);
                nn.setInputs(2, 36.4);
                nn.setInputs(3, 90.7);
                nn.setInputs(4, 58.4);
                nn.setInputs(5, 27.8);
                nn.setInputs(6, 17.7);
                nn.setDesiredOutput(0, 19.2);
                nn.run();
                //8
                nn.setInputs(0, 25);
                nn.setInputs(1, 176);
                nn.setInputs(2, 37.8);
                nn.setInputs(3, 88.5);
                nn.setInputs(4, 60);
                nn.setInputs(5, 29);
                nn.setInputs(6, 18.8);
                nn.setDesiredOutput(0, 12.4);
                nn.run();
                //9
                nn.setInputs(0, 25);
                nn.setInputs(1, 191);
                nn.setInputs(2, 38.1);
                nn.setInputs(3, 82.5);
                nn.setInputs(4, 62.9);
                nn.setInputs(5, 31.1);
                nn.setInputs(6, 18.2);
                nn.setDesiredOutput(0, 4.1);
                nn.run();
                //10
                nn.setInputs(0, 23);
                nn.setInputs(1, 198.25);
                nn.setInputs(2, 42.1);
                nn.setInputs(3, 88.6);
                nn.setInputs(4, 63.1);
                nn.setInputs(5, 30);
                nn.setInputs(6, 19.2);
                nn.setDesiredOutput(0, 11.7);
                nn.run();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bathroom_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fileName = openFileDialog1.FileName;
        }
    }
}
