using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManageMentSystem
{
    public partial class Receptionist_Home : Form
    {
        private readonly string loggedInUsername;
        private readonly ReceptionistEntity receptionistEntity = new ReceptionistEntity();
        private readonly int userID;

        public Receptionist_Home(int userID)
        {
            InitializeComponent();

            this.userID = userID;
            LoadData();
            loggedInUsername = ReceptionistEntity.GetReceptionistNameByID(userID);
            label1.Text = "Welcome " + loggedInUsername;
        }

        private void LoadData()
        {
            DataTable data = receptionistEntity.GetReceptionistDataFromDatabase(userID);
            tableManager.DataSource = data;
        }

        private void closeButtonLogin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MinimizeBT_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ServiceRequest_Click(object sender, EventArgs e)
        {
            OpenForm(new Receptionist_Service(homepanel));
        }

        private void LANDF_Click(object sender, EventArgs e)
        {
            OpenForm(new Lost_And_Found(homepanel));
        }

        private void ManageRoomBT_Click(object sender, EventArgs e)
        {
            OpenForm(new Receptionist_Manage_Room(homepanel));
        }

        private void CustomerDetails_Click(object sender, EventArgs e)
        {
            OpenForm(new Customer(homepanel));
        }

        private void LogOUtBt_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void HomeBT_Click(object sender, EventArgs e)
        {
            Receptionist_Home receptionistHome = new Receptionist_Home(userID);
            receptionistHome.Show();
            this.Hide();
        }

        private void OpenForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            homepanel.Controls.Clear();
            homepanel.Controls.Add(form);

            form.Show();
        }

        private void PaymentBT_Click(object sender, EventArgs e)
        {
            OpenForm(new Manager_Payment(homepanel));
        }

        private void UpdateDataBT(object sender, EventArgs e)
        {
            addReceptionist addReceptionist = new addReceptionist(homepanel, userID)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            homepanel.Controls.Clear();
            homepanel.Controls.Add(addReceptionist);

            addReceptionist.Show();
        }
    }
}
