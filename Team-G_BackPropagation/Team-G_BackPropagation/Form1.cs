using Backprop;
using System;
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
        NeuralNet nn;
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(7, 1, 1);
        }

        private void train_Click(object sender, EventArgs e)
        {
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
                nn.setInputs(0, 27);
                nn.setInputs(1, 184.25);
                nn.setInputs(2, 34.4);
                nn.setInputs(3, 100);
                nn.setInputs(4, 63.2);
                nn.setInputs(5, 27.7);
                nn.setInputs(6, 17.7);
                nn.setDesiredOutput(0, 28.7);
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
    }
}
