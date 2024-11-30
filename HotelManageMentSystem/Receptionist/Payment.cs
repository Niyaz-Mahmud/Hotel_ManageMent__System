using System;
using System.Windows.Forms;

namespace HotelManageMentSystem
{
    public partial class Payment : Form
    {
        private readonly int customerId;
        private readonly Panel homePanelReference;
        private readonly int billAmount;
        private readonly int roomNumber;
        private readonly PaymentEntity paymentEntity = new PaymentEntity();

        public Payment(int billAmount, Panel panelReference, int customerId, int roomNumber)
        {
            InitializeComponent();
            homePanelReference = panelReference;
            this.customerId = customerId;
            this.billAmount = billAmount;
            this.roomNumber = roomNumber;

            txtTotalBill.Text = billAmount + " BDT";
        }

        private void PayBT_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            if (int.TryParse(txtReceivedAmount.Text, out int receivedAmount))
            {
                string paymentMethod = txtPaymentMethod.Text;
                string cardType = txtCardType.Text;

                int returnedAmount = receivedAmount - this.billAmount;
                txtReturnedAmount.Text = returnedAmount.ToString();

                PaymentEntity payment = new PaymentEntity
                {
                    TotalBill = this.billAmount,
                    PaymentMethod = paymentMethod,
                    ReceivedAmount = receivedAmount,
                    ReturnedAmount = returnedAmount,
                    CardType = cardType,
                    CustomerID = this.customerId
                };

                bool paymentInserted = paymentEntity.InsertPaymentDetails(payment);

                if (paymentInserted)
                {
                    MessageBox.Show("Payment details added successfully");
                    CustomerEntity customerEntity = new CustomerEntity();

                    DateTime newCheckoutDate = DateTime.Now;
                    customerEntity.UpdateCustomerCheckoutDate(customerId, newCheckoutDate, billAmount);

                    RoomManagerEntity roomManagerEntity = new RoomManagerEntity
                    {
                        Room_No = this.roomNumber,
                        Room_Availability = "Available",
                        Status = ""
                    };
                    roomManagerEntity.UpdateRoomAvailability(roomManagerEntity);

                    GoToNextForm();
                }
                else
                {
                    MessageBox.Show("Error inserting payment details");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numeric values for amount fields");
            }
        }

        private void txtReceivedAmount_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtReceivedAmount.Text, out int receivedAmount))
            {
                int returnedAmount = receivedAmount - this.billAmount;
                txtReturnedAmount.Text = returnedAmount.ToString();
            }
            else
            {
                txtReturnedAmount.Text = ""; // Clear the returned amount if invalid input is detected
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtReceivedAmount.Text) || string.IsNullOrEmpty(txtPaymentMethod.Text))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return false;
            }
            return true;
        }

        private void GoToNextForm()
        {
            Invoice Invoice = new Invoice(homePanelReference, customerId)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(Invoice);

            Invoice.Show();
            this.Hide();
        }

        private void GoBackToPreviousForm()
        {
            Customer customerForm = new Customer(homePanelReference)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(customerForm);

            customerForm.Show();
            this.Hide();
        }

        private void BackBT_Click(object sender, EventArgs e)
        {
            GoBackToPreviousForm();
        }

        private void txtReturnedAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PayBT.PerformClick();
            }
        }
    }
}
