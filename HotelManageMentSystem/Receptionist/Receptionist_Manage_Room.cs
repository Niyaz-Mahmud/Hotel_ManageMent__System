using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManageMentSystem
{
    public partial class Receptionist_Manage_Room : Form
    {
        private readonly RoomManagerEntity roomManager = new RoomManagerEntity();
        private readonly Panel homePanelReference;

        public Receptionist_Manage_Room(Panel homePanel)
        {
            InitializeComponent();
            homePanelReference = homePanel;
            LoadDataIntoDataGridView();
            AddComboBoxColumn();
            MakeAllColumnsReadOnlyExceptStatus();
        }

        private void MakeAllColumnsReadOnlyExceptStatus()
        {
            foreach (DataGridViewColumn column in tableManager.Columns)
            {
                if (column.Name != "Status")
                {
                    column.ReadOnly = true;
                }
            }
        }

        private void tableManager_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tableManager.Columns["Status"].Index && e.RowIndex >= 0)
            {
                int roomNumber = Convert.ToInt32(tableManager.Rows[e.RowIndex].Cells["Room_No"].Value);
                string selectedStatus = tableManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                roomManager.Room_No = roomNumber;
                roomManager.Status = selectedStatus;

                roomManager.UpdateRoomStatus(roomManager);
                LoadDataIntoDataGridView();
            }
        }

        private void AttachCellValueChangedEvent()
        {
            tableManager.CellValueChanged += new DataGridViewCellEventHandler(tableManager_CellValueChanged);
        }

        private void AddComboBoxColumn()
        {
            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.HeaderText = "Status";
            statusColumn.Name = "Status";
            statusColumn.Items.AddRange("Approved", "Pending", " ");
            tableManager.Columns.Add(statusColumn);
        }

        private void LoadDataIntoDataGridView()
        {
            DataTable data = roomManager.GetRoomManagerData();
            if (data != null)
            {
                tableManager.DataSource = data;
            }
            else
            {
                MessageBox.Show("Failed to load data.");
            }
        }

        private void Receptionist_Manage_Room_Load(object sender, EventArgs e)
        {
            AttachCellValueChangedEvent();
        }
    }
}
