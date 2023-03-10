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
            nn = new NeuralNet(5, 1, 1);
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
