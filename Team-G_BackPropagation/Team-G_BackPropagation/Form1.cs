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
            nn = new NeuralNet(5, 0, 1);
        }

        private void train_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(epochs.Text); i++)
            {
                //1
                nn.setInputs(0, 4);
                nn.setInputs(1, 3.5);
                nn.setInputs(2, 4120);
                nn.setInputs(3, 10380);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 1146800);
                nn.learn();
                //2
                nn.setInputs(0, 3);
                nn.setInputs(1, 1.75);
                nn.setInputs(2, 2150);
                nn.setInputs(3, 4200);
                nn.setInputs(4, 5);
                nn.setDesiredOutput(0, 950000);
                nn.learn();
                //3
                nn.setInputs(0, 4);
                nn.setInputs(1, 2);
                nn.setInputs(2, 3380);
                nn.setInputs(3, 90968);
                nn.setInputs(4, 4);
                nn.setDesiredOutput(0, 850000);
                nn.learn();
                //4
                nn.setInputs(0, 4);
                nn.setInputs(1, 2.5);
                nn.setInputs(2, 2790);
                nn.setInputs(3, 230868);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 599000);
                nn.learn();
                //5
                nn.setInputs(0, 2);
                nn.setInputs(1, 1);
                nn.setInputs(2, 960);
                nn.setInputs(3, 28717);
                nn.setInputs(4, 4);
                nn.setDesiredOutput(0, 255000);
                nn.learn();
                //6
                nn.setInputs(0, 4);
                nn.setInputs(1, 2.5);
                nn.setInputs(2, 1560);
                nn.setInputs(3, 4320);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 280000);
                nn.learn();
                //7
                nn.setInputs(0, 4);
                nn.setInputs(1, 2.25);
                nn.setInputs(2, 2460);
                nn.setInputs(3, 40635);
                nn.setInputs(4, 5);
                nn.setDesiredOutput(0, 715000);
                nn.learn();
                //8
                nn.setInputs(0, 3);
                nn.setInputs(1, 2.5);
                nn.setInputs(2, 1740);
                nn.setInputs(3, 3082);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 550000);
                nn.learn();
                //9
                nn.setInputs(0, 3);
                nn.setInputs(1, 2.75);
                nn.setInputs(2, 3890);
                nn.setInputs(3, 7216);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 1080000);
                nn.learn();
                //10
                nn.setInputs(0, 3);
                nn.setInputs(1, 1.75);
                nn.setInputs(2, 1750);
                nn.setInputs(3, 12345);
                nn.setInputs(4, 4);
                nn.setDesiredOutput(0, 499000);
                nn.learn();
                //11
                nn.setInputs(0, 3);
                nn.setInputs(1, 2);
                nn.setInputs(2, 1650);
                nn.setInputs(3, 7352);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 252350);
                nn.learn();
                //12
                nn.setInputs(0, 3);
                nn.setInputs(1, 1);
                nn.setInputs(2, 1270);
                nn.setInputs(3, 7566);
                nn.setInputs(4, 4);
                nn.setDesiredOutput(0, 276900);
                nn.learn();
                //13
                nn.setInputs(0, 5);
                nn.setInputs(1, 4);
                nn.setInputs(2, 2980);
                nn.setInputs(3, 4500);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 850000);
                nn.learn();
                //14
                nn.setInputs(0, 3);
                nn.setInputs(1, 2.5);
                nn.setInputs(2, 2200);
                nn.setInputs(3, 7201);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 302495);
                nn.learn();
                //15
                nn.setInputs(0, 3);
                nn.setInputs(1, 1.75);
                nn.setInputs(2, 1850);
                nn.setInputs(3, 15170);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 390000);
                nn.learn();
                //16
                nn.setInputs(0, 4);
                nn.setInputs(1, 2.5);
                nn.setInputs(2, 3280);
                nn.setInputs(3, 27441);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 699000);
                nn.learn();
                //17
                nn.setInputs(0, 4);
                nn.setInputs(1, 2.75);
                nn.setInputs(2, 2900);
                nn.setInputs(3, 6400);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 450000);
                nn.learn();
                //18
                nn.setInputs(0, 5);
                nn.setInputs(1, 4.5);
                nn.setInputs(2, 3100);
                nn.setInputs(3, 7260);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 460000);
                nn.learn();
                //19
                nn.setInputs(0, 1);
                nn.setInputs(1, 0);
                nn.setInputs(2, 600);
                nn.setInputs(3, 24501);
                nn.setInputs(4, 2);
                nn.setDesiredOutput(0, 280000);
                nn.learn();
                //20
                nn.setInputs(0, 4);
                nn.setInputs(1, 1);
                nn.setInputs(2, 1210);
                nn.setInputs(3, 6000);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 279000);
                nn.learn();
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            nn.setInputs(0, Convert.ToDouble(bedroom.Text));
            nn.setInputs(1, Convert.ToDouble(bathroom.Text));
            nn.setInputs(2, Convert.ToDouble(living.Text));
            nn.setInputs(3, Convert.ToDouble(lot.Text));
            nn.setInputs(4, Convert.ToDouble(condition.Text));
            nn.run();

            output.Text = "$ " + (nn.getOuputData(0));
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

        private void condition_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
