using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace systemSklad
{
    public partial class Payment : Form
    {
        private RadioButton radioButtonCreditCard;
        private RadioButton radioButtonPayPal;
        private TextBox textBoxCardNumber;
        private TextBox textBoxExpiryDate;
        private TextBox textBoxCVV;
        private TextBox textBoxPayPalEmail;
        private Button buttonPay;
        private Label labelError;
        private Panel panelCreditCardDetails;
        private Panel panelPayPalDetails;
       // Console.OutputEncoding = System.Text.Encoding.UTF8;


        public Payment()
        {
            InitializeComponent();
            Console.OutputEncoding = System.Text.Encoding.UTF8;

        }
        private void InitializeComponents()
        {
            this.Text = "Payment";
            this.Size = new System.Drawing.Size(400, 350);

            // Payment Method Selection
            radioButtonCreditCard = new RadioButton { Text = "Credit Card", Location = new System.Drawing.Point(20, 20 };
            radioButtonCreditCard.CheckedChanged += RadioButton_CheckedChanged;
            this.Controls.Add(radioButtonCreditCard);

            radioButtonPayPal = new RadioButton { Text = "PayPal", Location = new System.Drawing.Point(20, 50) };
            radioButtonPayPal.CheckedChanged += RadioButton_CheckedChanged;
            this.Controls.Add(radioButtonPayPal);


            // Credit Card Details Panel
            panelCreditCardDetails = new Panel { Location = new System.Drawing.Point(20, 80), Size = new System.Drawing.Size(350, 100), Visible = false };
            textBoxCardNumber = new TextBox { PlaceholderText = "Card Number", Location = new System.Drawing.Point(10, 10), Size = new System.Drawing.Size(330, 20) };
            textBoxExpiryDate = new TextBox { PlaceholderText = "Expiry Date (MM/YY)", Location = new System.Drawing.Point(10, 40), Size = new System.Drawing.Size(150, 20) };
            textBoxCVV = new TextBox { PlaceholderText = "CVV", Location = new System.Drawing.Point(170, 40), Size = new System.Drawing.Size(170, 20), PasswordChar = '*' };
            panelCreditCardDetails.Controls.Add(textBoxCardNumber);
            panelCreditCardDetails.Controls.Add(textBoxExpiryDate);
            panelCreditCardDetails.Controls.Add(textBoxCVV);
            this.Controls.Add(panelCreditCardDetails);
            // PayPal Details Panel
            panelPayPalDetails = new Panel { Location = new System.Drawing.Point(20, 80), Size = new System.Drawing.Size(350, 50), Visible = false };
            textBoxPayPalEmail = new TextBox { PlaceholderText = "PayPal Email", Location = new System.Drawing.Point(10, 10), Size = new System.Drawing.Size(330, 20) };
            panelPayPalDetails.Controls.Add(textBoxPayPalEmail);
            this.Controls.Add(panelPayPalDetails);


            // Pay Button and Error Label
            buttonPay = new Button { Text = "Pay", Location = new System.Drawing.Point(20, 200), Width = 100 };
            buttonPay.Click += ButtonPay_Click;
            this.Controls.Add(buttonPay);

            labelError = new Label { Location = new System.Drawing.Point(20, 240), ForeColor = System.Drawing.Color.Red, Visible = false };
            this.Controls.Add(labelError);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            panelCreditCardDetails.Visible = radioButtonCreditCard.Checked;
            panelPayPalDetails.Visible = radioButtonPayPal.Checked;
        }

        private void ButtonPay_Click(object sender, EventArgs e)
        {
            // **REPLACE THIS WITH ACTUAL PAYMENT PROCESSING CODE (using a payment gateway)**
            // This is a crucial step, and you MUST use a secure payment gateway API.
            if (radioButtonCreditCard.Checked)
            {
                // Validate Credit Card Information
                if (string.IsNullOrWhiteSpace(textBoxCardNumber.Text) || string.IsNullOrWhiteSpace(textBoxExpiryDate.Text) || string.IsNullOrWhiteSpace(textBoxCVV.Text))
                {
                    labelError.Text = "Please fill in all credit card details.";
                    labelError.Visible = true;
                    return;
                }
                //Simulate payment
                ProcessCreditCardPayment();
            }
            else if (radioButtonPayPal.Checked)
            {
                //Validate PayPal email
                if (string.IsNullOrWhiteSpace(textBoxPayPalEmail.Text))
                {
                    labelError.Text = "Please enter your PayPal email.";
                    labelError.Visible = true;
                    return;
                }
                ProcessPayPalPayment();
            }
            else
            {
                labelError.Text = "Please select a payment method.";
                labelError.Visible = true;
            }
        }


        private void ProcessCreditCardPayment()
        {
            //Replace with actual payment gateway integration.
            labelError.Text = "Credit card payment simulated.";
            labelError.Visible = true;

        }

        private void ProcessPayPalPayment()
        {
            //Replace with actual payment gateway integration.
            labelError.Text = "PayPal payment simulated.";
            labelError.Visible = true;
        }
        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
