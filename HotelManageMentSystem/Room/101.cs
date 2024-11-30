﻿using System;
using System.Windows.Forms;

namespace HotelManageMentSystem
{
    public partial class _101 : Form
    {
        private readonly Panel homePanelReference;
        readonly int roomnumber = 101;
        private readonly int userID;

        public _101(string data, Panel homePanel, int userID)
        {
            InitializeComponent();

            homePanelReference = homePanel;
            this.userID = userID;
        }

        private void BackBT_Click(object sender, EventArgs e)
        {
            Customer_Manage_Room Customer_Manage_Room = new Customer_Manage_Room(homePanelReference, userID);
            Customer_Manage_Room.TopLevel = false;
            Customer_Manage_Room.FormBorderStyle = FormBorderStyle.None;
            Customer_Manage_Room.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(Customer_Manage_Room);

            Customer_Manage_Room.Show();
            this.Close();
        }

        private void BookBT_Click(object sender, EventArgs e)
        {
            Add_CustomerDetails CustomerDetails = new Add_CustomerDetails(homePanelReference, roomnumber.ToString(), userID);
            CustomerDetails.TopLevel = false;
            CustomerDetails.FormBorderStyle = FormBorderStyle.None;
            CustomerDetails.Dock = DockStyle.Fill;

            homePanelReference.Controls.Clear();
            homePanelReference.Controls.Add(CustomerDetails);

            CustomerDetails.Show();
        }

    }
}

