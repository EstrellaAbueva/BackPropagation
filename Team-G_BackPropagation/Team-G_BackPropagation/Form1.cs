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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            nn = new NeuralNet(5, 3, 1);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            epochs.Text = "";
            bedroom.Text = "";
            bathroom.Text = "";
            living.Text = "";
            lot.Text = "";
            condition.Text = "";
            output.Text = "";
        }

        private void test_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(bedroom.Text));
            nn.setInputs(1, Convert.ToDouble(bathroom.Text));
            nn.setInputs(2, Convert.ToDouble(living.Text));
            nn.setInputs(3, Convert.ToDouble(lot.Text));
            nn.setInputs(4, Convert.ToDouble(condition.Text));
            nn.run();

            output.Text = "$ " + (nn.getOuputData(0)).ToString();
        }

        private void train_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(epochs.Text); i++)
            {
                nn.setInputs(0, 4);
                nn.setInputs(1, 1);
                nn.setInputs(2, 2100);
                nn.setInputs(3, 9200);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 211000);
                nn.learn();

                nn.setInputs(0, 3);
                nn.setInputs(1, 2.5);
                nn.setInputs(2, 1530);
                nn.setInputs(3, 6000);
                nn.setInputs(4, 4);
                nn.setDesiredOutput(0, 265000);
                nn.learn();

                nn.setInputs(0, 3);
                nn.setInputs(1, 3.5);
                nn.setInputs(2, 3870);
                nn.setInputs(3, 3819);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 1440000);
                nn.learn();

                nn.setInputs(0, 4);
                nn.setInputs(1, 3.5);
                nn.setInputs(2, 2370);
                nn.setInputs(3, 3302);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 800000);
                nn.learn();

                nn.setInputs(0, 5);
                nn.setInputs(1, 3.25);
                nn.setInputs(2, 3230);
                nn.setInputs(3, 3825);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 1059500);
                nn.learn();
            }
        }
    }
}
