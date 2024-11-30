using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManageMentSystem
{
    public partial class Receptionist_Service : Form
    {
        private readonly Panel homePanelReference;
        private readonly RoomServiceEntity roomServiceEntity = new RoomServiceEntity();

        public Receptionist_Service(Panel homepanel)
        {
            InitializeComponent();
            homePanelReference = homepanel;
            LoadData();
        }

        public void LoadData()
        {
            DataTable data = roomServiceEntity.GetRoomServiceData();
            tableManager.DataSource = data;

            if (tableManager.Columns.Contains("Note"))
            {
                DataGridViewColumn column = tableManager.Columns["Note"];
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                tableManager.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
        }

        private void AddBt(object sender, EventArgs e)
        {
            Receptionist_Add_HouseKeeping receptionistAddHouseKeeping = new Receptionist_Add_HouseKeeping(homePanelReference);
            receptionistAddHouseKeeping.TopLevel = false;
            receptionistAddHouseKeeping.FormBorderStyle = FormBorderStyle.None;
            receptionistAddHouseKeeping.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(receptionistAddHouseKeeping);

            receptionistAddHouseKeeping.Show();
        }

        private void deleteButton2_Click(object sender, EventArgs e)
        {
            if (tableManager.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = tableManager.SelectedRows[0].Index;

                    try
                    {
                        int selectedRowID = Convert.ToInt32(tableManager.Rows[selectedRowIndex].Cells["ID"].Value);
                        bool deleted = roomServiceEntity.DeleteRoomService(selectedRowID);

                        if (deleted)
                        {
                            tableManager.Rows.RemoveAt(selectedRowIndex);
                            MessageBox.Show("Row deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error deleting row");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }
    }
}
