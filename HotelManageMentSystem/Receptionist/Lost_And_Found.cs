using HotelManagementSystem;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelManageMentSystem
{
    public partial class Lost_And_Found : Form
    {
        private readonly Panel homePanelReference;
        private readonly LostAndFound lostAndFound = new LostAndFound();

        public Lost_And_Found(Panel homepanel)
        {
            InitializeComponent();
            homePanelReference = homepanel;
            LoadData();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            try
            {
                DataTable dataTable = lostAndFound.SearchLostAndFound(searchTerm);

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("No results matched the search criteria.");
                }

                tableManager.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                DataTable data = lostAndFound.GetDataFromLostAndFoundTable();
                tableManager.DataSource = data;

                foreach (DataGridViewColumn column in tableManager.Columns)
                {
                    if (column.Name != "Customer_ID")
                    {
                        column.ReadOnly = true;
                    }
                }

                if (tableManager.Columns.Contains("ItemDescription"))
                {
                    DataGridViewColumn column = tableManager.Columns["ItemDescription"];
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    tableManager.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tableManager_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = tableManager.Columns[e.ColumnIndex].Name;

                if (columnName != "ID" && tableManager.IsCurrentCellDirty)
                {
                    DataGridViewCell cell = tableManager.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string newValue = cell.Value.ToString();

                    if (!string.IsNullOrEmpty(newValue))
                    {
                        int id = Convert.ToInt32(tableManager.Rows[e.RowIndex].Cells["ID"].Value);
                        lostAndFound.UpdateLostAndFoundItem(id, columnName, newValue);
                    }
                }
            }
        }

        private void Add_BT_Click(object sender, EventArgs e)
        {
            Add_Lost_and_Found_Menu Add_Lost_and_Found_Menu = new Add_Lost_and_Found_Menu(homePanelReference);
            ConfigureFormAppearance(Add_Lost_and_Found_Menu);
        }

        private void DeleteBT_Click(object sender, EventArgs e)
        {
            if (tableManager.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = tableManager.SelectedRows[0].Index;

                    try
                    {
                        int selectedRowID = Convert.ToInt32(tableManager.Rows[selectedRowIndex].Cells["ID"].Value);
                        bool isDeleted = lostAndFound.DeleteLostAndFoundItem(selectedRowID);

                        if (isDeleted)
                        {
                            tableManager.Rows.RemoveAt(selectedRowIndex);
                            MessageBox.Show("Record deleted successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error deleting record");
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

        private void ConfigureFormAppearance(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(form);
            form.Show();
        }
    }
}
