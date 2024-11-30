using System;
using System.Windows.Forms;

namespace HotelManageMentSystem
{
    public partial class Receptionist_Add_HouseKeeping : Form
    {
        private readonly Panel homePanelReference;
        private readonly RoomServiceEntity roomServiceEntity = new RoomServiceEntity();
        private readonly RoomManagerEntity roomManagerEntity = new RoomManagerEntity();

        public Receptionist_Add_HouseKeeping(Panel homepanel)
        {
            InitializeComponent();
            homePanelReference = homepanel;
        }

        private void backBT_Click(object sender, EventArgs e)
        {
            Receptionist_Service receptionistService = new Receptionist_Service(homePanelReference)
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(receptionistService);

            receptionistService.Show();
            this.Close();
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRoomNo.Text) || string.IsNullOrEmpty(txtItem.Text))
            {
                MessageBox.Show("All fields are mandatory");
                return;
            }

            string item = txtItem.Text;
            string roomNoString = txtRoomNo.Text;
            string note = txtDescription.Text;

            if (!int.TryParse(roomNoString, out int roomNo))
            {
                MessageBox.Show("Room number must be an integer");
                return;
            }

            if (!roomManagerEntity.RoomExists(roomNo))
            {
                MessageBox.Show("Room number does not exist");
                return;
            }

            try
            {
                roomServiceEntity.Room_No = roomNo;
                roomServiceEntity.ITEM = item;
                roomServiceEntity.Note = note;
                roomServiceEntity.Status = "Pending";

                bool roomServiceAdded = roomServiceEntity.InsertRoomService(roomServiceEntity);

                if (roomServiceAdded)
                {
                    MessageBox.Show("Room Service details added successfully");
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Error inserting Room Service details");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearInputFields()
        {
            txtDescription.Clear();
            txtItem.Clear();
            txtRoomNo.Clear();
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddBT_Click(sender, e);
            }
        }
    }
}
