using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            bool ok = true;
            // Must select a value for the breakfast combo 
            if (cmbBreakfast.SelectedIndex == -1)
            {
                lblCheckQBreakfast.Text = "Invalid Meal Selection.";
                return;
            }
            else
            {
                lblCheckQBreakfast.Text = string.Empty;
            }

            // Breakfast quantity must be an integer
            if (!int.TryParse(txtBreakfast.Text, out int parsedValueBreakfast))
            {
                lblCheckQBreakfast.Text = "Invalid Quantity.";
                return;
            }
            else
            {
                lblCheckQBreakfast.Text = string.Empty;
            }

            // Must select a value for lunch combo
            if (cmbLunch.SelectedIndex == -1)
            {
                lblCheckQLunch.Text = "Invalid Meal Selection.";
                return;
            }
            else
            {
                lblCheckQLunch.Text = string.Empty;
            }

            // Lunch quantity must be an integer
            if (!int.TryParse(txtLunch.Text, out int parsedValueLunch))
            {
                lblCheckQLunch.Text = "Invalid Quantity.";
                return;
            }
            else
            {
                lblCheckQLunch.Text = string.Empty;
            }

            // Must select a value for Dinner combo
            if (cmbDinner.SelectedIndex == -1)
            {
                lblCheckQDinner.Text = "Invalid Meal Selection.";
                return;
            }
            else
            {
                lblCheckQDinner.Text = string.Empty;
            }

            // Dinner quantity must be an integer
            if (!int.TryParse(txtDinner.Text, out int parsedValueDinner))
            {
                lblCheckQDinner.Text = "Invalid Quantity.";
                return;
            }
            else
            {
                lblCheckQDinner.Text = string.Empty;
            }

             /*
             * Bagel = $3.95
             * Vegetarian = $10.95
             * Protein Platter = $11.95
             */

            //create 2 arrays to store the user selections: a meal array and a quantity array
            string[] meal = new string[3] { cmbBreakfast.SelectedItem.ToString(), cmbLunch.SelectedItem.ToString(), cmbDinner.SelectedItem.ToString() };
            int[] quantity = new int[3] { parsedValueBreakfast, parsedValueLunch, parsedValueDinner };

            //Create variable subTotal to caculate Meal Order Form of user 
            var subTotal = 0d;

            // Using for loop to caculate variable of subTotal
            for (var i = 0; i <= 2; i++){
                if (meal[i].Equals("Bagel"))
                {
                    subTotal += (3.95d * quantity[i]);
                }
                else if (meal[i].Equals("Vegetarian Special"))
                {
                    subTotal += (10.95d * quantity[i]);
                }
                else if (meal[i].Equals("Protein Platter"))
                {
                    subTotal += (11.95d * quantity[i]);
                }                
            }

            //Caculate tax and round the result to 2 decimals place
            var tax = Math.Round((subTotal * 13) / 100,2);
            var total = subTotal + tax;

            //Display the results of the caculation
            lblDisplaySubTotal.Text = string.Format("{0:C}", subTotal);
            lblDisplayTax.Text = string.Format("{0:C}",tax);
            lblDisplayTotal.Text = string.Format("{0:C}",total);     
        }
    }
}
