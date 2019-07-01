using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CurrencyApp {
    public partial class FormCurrencyApp : Form {

        // enum to store currencies
        public enum currencies { BRITISH, CHINESE, EURO, US, CANADIAN};

        public FormCurrencyApp() {

            InitializeComponent();
        }

        /// <summary>
        /// Pre: List box items are string representations of doubles
        ///      txtAmount is numeric value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConvert_Click(object sender, EventArgs e) {
            double amount, rate, answer;

            bool ok = double.TryParse(textBoxAUD.Text, out amount);
            if (!ok) {
                MessageBox.Show("You need to enter a numeric value for AUD", "ERROR", MessageBoxButtons.OK);
                textBoxAUD.Text = "";
                return;
            }


            // where a currency has not been entered yet
            // (TODO: add exception handling of user-entered currency)
            if (comboBoxCurrency.SelectedItem == null) {
                MessageBox.Show("Select a currency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {

                try { // may generate exception if collections of different length (Currency Chosen and Conversion Rate)
                    rate = double.Parse(listBoxConversionRate.SelectedItem.ToString());
                    answer = (amount * rate);
                    textBoxConvertedAmount.Text = String.Format("{0:C2}", answer).ToString();

                } catch (Exception) {

                    MessageBox.Show("The required collections are corrupt.  \n\n" +
                        "Developer, please ensure the collections:\n" +
                        "         Currencies and Conversion Rates\n" +
                        "are of identical length.",
                        "!! ERROR - DO NOT RELEASE TO CLIENT !!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                }
            }
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e) {
            // use the index of the selected item in the combobox to determine
            // the rate to be selected
            //listBoxConversionRate.SetSelected(comboBoxCurrency.SelectedIndex, true);

            if (comboBoxCurrency.SelectedItem.ToString() == "British Pounds") {
                listBoxConversionRate.SetSelected((int)currencies.BRITISH, true);
            } else if (comboBoxCurrency.SelectedItem.ToString() == "Chinese CNY") {
                listBoxConversionRate.SetSelected((int)currencies.CHINESE, true);
            } else if (comboBoxCurrency.SelectedItem.ToString() == "Euro") {
                listBoxConversionRate.SetSelected((int)currencies.EURO, true);
            } else if (comboBoxCurrency.SelectedItem.ToString() == "US Dollar") {
                listBoxConversionRate.SetSelected((int)currencies.US, true);
            } else if (comboBoxCurrency.SelectedItem.ToString() == "Canadian Dollar") {
                listBoxConversionRate.SetSelected((int)currencies.CANADIAN, true);
            } else {            // shouldn't have any other values
            }

            // display the exchange rate
            listBoxConversionRate.Visible = true;

            // clear the output until the button clicked
            textBoxConvertedAmount.Text = "";
        }


        /* EXTRA FUNCTIONALITY NOT USED IN JIT121 - AS FILE IO NOT COVERED*/
        private void openToolStripMenuItem_Click(object sender, EventArgs e) {

            // choose the file to open
            string chosenFileName = "";
            openFileDialog1.ShowDialog();
            chosenFileName = openFileDialog1.FileName;

            try {

                // Open the stream for reading
                StreamReader reader = new StreamReader(chosenFileName);

                listBoxConversionRate.Items.Clear();

                // process the rates.txt file
                string inputData = reader.ReadLine();

                while (inputData != "") {
                    listBoxConversionRate.Items.Add(inputData);
                    inputData = reader.ReadLine();
                } //end while

                reader.Close();

            }
            catch (FileNotFoundException) {
                MessageBox.Show("File was not selected!", "ERROR!");
            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {

            // Open the stream for reading
            string defaultPath = Environment.CurrentDirectory;
            string fileName = defaultPath + "\\Text Files\\Rates_old.txt";

            try {
                StreamReader reader = new StreamReader(fileName);
                listBoxConversionRate.Items.Clear();

                // process the rates.txt file
                string inputData = reader.ReadLine();

                while (inputData != "") {
                    listBoxConversionRate.Items.Add(inputData);
                    inputData = reader.ReadLine();
                } //end while

                reader.Close();

            }
            catch (FileNotFoundException) {
                MessageBox.Show(String.Format("File was not found: \n\n{0}", fileName), "ERROR!");
            }



        }


    }
}
