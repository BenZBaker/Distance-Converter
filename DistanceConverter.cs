using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenBakerAssessment1
{
    public partial class DistanceConverter : Form
    {
        public DistanceConverter()
        {
            InitializeComponent();
        }

        private void btn_InchToCM_Click(object sender, EventArgs e)
        {
            // Declare variables
            double value;
            double InchToCMConversion = 2.54;
            
            // Validate input is a double
            if (!double.TryParse(txt_Enter.Text, out value))
            {
                MessageBox.Show("There was an error. Try entering a number value.", "Error with input", MessageBoxButtons.OK);
                txt_Enter.Focus();
            }

            // Validate input is positive
            else if (value < 0)
            {
                MessageBox.Show("You can't enter a negative number. Try entering another number.", "Error with input", MessageBoxButtons.OK);
                txt_Enter.Focus();
            }
            
            else
            {
                // Convert string to double
                value = double.Parse(txt_Enter.Text);

                // Calculations
                double result = value * InchToCMConversion;

                // Display results
                txt_ConvertedValue.Text = result.ToString();
                txt_ConvertedValue.Visible = true;

                lbl_EnterUnits.Text = "inches";
                lbl_EnterUnits.Visible = true;

                lbl_ConvertedValueUnits.Text = "centimetres";
                lbl_ConvertedValueUnits.Visible = true;
            }

        }


        private void btn_FeetToMetres_Click(object sender, EventArgs e)
        {
            // Declare variables
            double value;
            double FeetToMetreConversion = 0.3048;

            // Validate input is a double
            if (!double.TryParse(txt_Enter.Text, out value))
            {
                MessageBox.Show("There was an error. Try entering a number value.", "Error with input", MessageBoxButtons.OK);
                txt_Enter.Focus();
            }

            // Validate input is positive
            else if (value < 0)
            {
                MessageBox.Show("You can't enter a negative number. Try entering another number.", "Error with input", MessageBoxButtons.OK);
                txt_Enter.Focus();
            }

            else
            {
                // Convert string to double
                value = double.Parse(txt_Enter.Text);

                // Calculations
                double result = value * FeetToMetreConversion;

                // Display results
                txt_ConvertedValue.Text = result.ToString();
                txt_ConvertedValue.Visible = true;

                lbl_EnterUnits.Text = "feet";
                lbl_EnterUnits.Visible = true;

                lbl_ConvertedValueUnits.Text = "metres";
                lbl_ConvertedValueUnits.Visible = true;
            }
        }


        private void btn_YardToMetres_Click(object sender, EventArgs e)
        {
            // Declare variables
            double value;
            double YardsToMetreConversion = 0.9144;

            // Validate input is a double
            if (!double.TryParse(txt_Enter.Text, out value))
            {
                MessageBox.Show("There was an error. Try entering a number value.", "Error with input", MessageBoxButtons.OK);
                txt_Enter.Focus();
            }

            // Validate input is positive
            else if (value < 0)
            {
                MessageBox.Show("You can't enter a negative number. Try entering another number.", "Error with input", MessageBoxButtons.OK);
                txt_Enter.Focus();
            }

            else
            {
                // Convert string to double
                value = double.Parse(txt_Enter.Text);

                // Calculations
                double result = value * YardsToMetreConversion;

                // Display results
                txt_ConvertedValue.Text = result.ToString();
                txt_ConvertedValue.Visible = true;

                lbl_EnterUnits.Text = "yards";
                lbl_EnterUnits.Visible = true;

                lbl_ConvertedValueUnits.Text = "metres";
                lbl_ConvertedValueUnits.Visible = true;
            }
        }


        private void btn_MilesToKMs_Click(object sender, EventArgs e)
        {
            // Declare variables
            double value;
            double MilesToKMs = 1.609;

            // Validate input is a double
            if (!double.TryParse(txt_Enter.Text, out value))
            {
                MessageBox.Show("There was an error. Try entering a number value.", "Error with input", MessageBoxButtons.OK);
                txt_Enter.Focus();
            }

            // Validate input is positive
            else if (value < 0)
            {
                MessageBox.Show("You can't enter a negative number. Try entering another number.", "Error with input", MessageBoxButtons.OK);
                txt_Enter.Focus();
            }

            else
            {
                // Convert string to double
                value = double.Parse(txt_Enter.Text);

                // Calculations
                double result = value * MilesToKMs;

                // Display results
                txt_ConvertedValue.Text = result.ToString();
                txt_ConvertedValue.Visible = true;

                lbl_EnterUnits.Text = "miles";
                lbl_EnterUnits.Visible = true;

                lbl_ConvertedValueUnits.Text = "kilometres";
                lbl_ConvertedValueUnits.Visible = true;
            }
        }


        private void txt_Enter_Enter(object sender, EventArgs e)
        {
            // Revert to initial look
            txt_ConvertedValue.Visible = false;
            lbl_EnterUnits.Visible = false;
            lbl_ConvertedValueUnits.Visible = false;
        }


        // Exit events
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DistanceConverter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }
    }
}
