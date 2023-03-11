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
            nn = new NeuralNet(5, 6, 1);
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

                //21
                nn.setInputs(0, 3);
                nn.setInputs(1, 1);
                nn.setInputs(2, 1752);
                nn.setInputs(3, 14626);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 249000);
                nn.learn();

                //22
                nn.setInputs(0, 3);
                nn.setInputs(1, 1.5);
                nn.setInputs(2, 1450);
                nn.setInputs(3, 9477);
                nn.setInputs(4, 4);
                nn.setDesiredOutput(0, 240000);
                nn.learn();

                //23
                nn.setInputs(0, 3);
                nn.setInputs(1, 1.75);
                nn.setInputs(2, 1930);
                nn.setInputs(3, 6360);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 536751);
                nn.learn();

                //24
                nn.setInputs(0, 3);
                nn.setInputs(1, 3);
                nn.setInputs(2, 3740);
                nn.setInputs(3, 39640);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 789000);
                nn.learn();

                //25
                nn.setInputs(0, 3);
                nn.setInputs(1, 1);
                nn.setInputs(2, 980);
                nn.setInputs(3, 7606);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 221000);
                nn.learn();

                //26
                nn.setInputs(0, 2);
                nn.setInputs(1, 2.5);
                nn.setInputs(2, 2560);
                nn.setInputs(3, 2500);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 780000);
                nn.learn();

                //27
                nn.setInputs(0, 4);
                nn.setInputs(1, 2.5);
                nn.setInputs(2, 2460);
                nn.setInputs(3, 8029);
                nn.setInputs(4, 5);
                nn.setDesiredOutput(0, 638250);
                nn.learn();

                //28
                nn.setInputs(0, 3);
                nn.setInputs(1, 2.5);
                nn.setInputs(2, 1700);
                nn.setInputs(3, 6200);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 262000);
                nn.learn();

                //29
                nn.setInputs(0, 2);
                nn.setInputs(1, 1);
                nn.setInputs(2, 1640);
                nn.setInputs(3, 14100);
                nn.setInputs(4, 4);
                nn.setDesiredOutput(0, 500000);
                nn.learn();

                //30
                nn.setInputs(0, 2);
                nn.setInputs(1, 1);
                nn.setInputs(2, 960);
                nn.setInputs(3, 5150);
                nn.setInputs(4, 5);
                nn.setDesiredOutput(0, 267500);
                nn.learn();

                //31 trash
                nn.setInputs(0, 4);
                nn.setInputs(1, 1);
                nn.setInputs(2, 1111);
                nn.setInputs(3, 123);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 12345);
                nn.learn();
                //32 trash
                nn.setInputs(0, 1);
                nn.setInputs(1, 1);
                nn.setInputs(2, 9872);
                nn.setInputs(3, 123421);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 9999999);
                nn.learn();

                //33 trash
                nn.setInputs(0, 7);
                nn.setInputs(1, 1.2);
                nn.setInputs(2, 1111);
                nn.setInputs(3, 1231);
                nn.setInputs(4, 1);
                nn.setDesiredOutput(0, 45123);
                nn.learn();

                //34 trash
                nn.setInputs(0, 3);
                nn.setInputs(1, 4.2);
                nn.setInputs(2, 1211);
                nn.setInputs(3, 9876);
                nn.setInputs(4, 4);
                nn.setDesiredOutput(0, 27123);
                nn.learn();

                //35 trash
                nn.setInputs(0, 7);
                nn.setInputs(1, 1.2);
                nn.setInputs(2, 12376);
                nn.setInputs(3, 1231);
                nn.setInputs(4, 1);
                nn.setDesiredOutput(0, 2507863);
                nn.learn();

                //36 trash
                nn.setInputs(0, 3);
                nn.setInputs(1, 4.2);
                nn.setInputs(2, 1154);
                nn.setInputs(3, 4327);
                nn.setInputs(4, 1);
                nn.setDesiredOutput(0, 789456);
                nn.learn();

                //37 trash
                nn.setInputs(0, 1);
                nn.setInputs(1, 1.2);
                nn.setInputs(2, 1000);
                nn.setInputs(3, 9806);
                nn.setInputs(4, 1);
                nn.setDesiredOutput(0, 274123);
                nn.learn();

                //38 trash
                nn.setInputs(0, 1);
                nn.setInputs(1, 1.2);
                nn.setInputs(2, 12376);
                nn.setInputs(3, 1231);
                nn.setInputs(4, 3);
                nn.setDesiredOutput(0, 457891);
                nn.learn();

                //39 trash
                nn.setInputs(0, 3);
                nn.setInputs(1, 1.27);
                nn.setInputs(2, 1154);
                nn.setInputs(3, 4327);
                nn.setInputs(4, 4);
                nn.setDesiredOutput(0, 2500);
                nn.learn();

                //40 trash
                nn.setInputs(0, 3);
                nn.setInputs(1, 1.27);
                nn.setInputs(2, 10004);
                nn.setInputs(3, 6000);
                nn.setInputs(4, 4);
                nn.setDesiredOutput(0, 35000);
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
    }
}
