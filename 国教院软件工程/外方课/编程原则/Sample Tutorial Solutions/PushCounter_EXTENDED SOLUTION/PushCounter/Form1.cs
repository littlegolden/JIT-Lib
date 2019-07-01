using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PushCounter {
    public partial class Form1 : Form {

        int counter = 0;

        public Form1() {
            InitializeComponent();
        }

        private void buttonClickMe_Click(object sender, EventArgs e) {
            counter++;
            clickCounterLabel.Text = counter.ToString() + " time";
            if (counter > 1) {
                clickCounterLabel.Text += "s";
            }
            buttonReset.Enabled = true;
                

        }

        private void buttonReset_Click(object sender, EventArgs e) {
            counter = 0;
            clickCounterLabel.Text = counter.ToString() + " times";
            buttonReset.Enabled = false;
        }

        private void checkBoxCheck_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxCheck.Checked) {
                labelCheckMessage.Text = "The CheckBox is checked";
            } else {
                labelCheckMessage.Text = "The CheckBox is NOT checked";
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
