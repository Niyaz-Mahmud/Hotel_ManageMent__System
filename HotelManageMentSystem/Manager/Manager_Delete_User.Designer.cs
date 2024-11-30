﻿
namespace HotelManageMentSystem
{
    partial class DeleteUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackBT = new System.Windows.Forms.Button();
            this.DeleteBT = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deletekeeper = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletekeeper)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.BackBT);
            this.panel1.Controls.Add(this.DeleteBT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 55);
            this.panel1.TabIndex = 5;
            // 
            // BackBT
            // 
            this.BackBT.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackBT.FlatAppearance.BorderSize = 0;
            this.BackBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBT.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBT.Location = new System.Drawing.Point(0, 0);
            this.BackBT.Name = "BackBT";
            this.BackBT.Size = new System.Drawing.Size(43, 55);
            this.BackBT.TabIndex = 23;
            this.BackBT.Text = "<";
            this.BackBT.UseVisualStyleBackColor = true;
            this.BackBT.Click += new System.EventHandler(this.BackBT_Click);
            // 
            // DeleteBT
            // 
            this.DeleteBT.BorderRadius = 20;
            this.DeleteBT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteBT.ForeColor = System.Drawing.Color.White;
            this.DeleteBT.Location = new System.Drawing.Point(897, 3);
            this.DeleteBT.Name = "DeleteBT";
            this.DeleteBT.Size = new System.Drawing.Size(174, 46);
            this.DeleteBT.TabIndex = 4;
            this.DeleteBT.Text = "Delete";
            this.DeleteBT.Click += new System.EventHandler(this.DeleteBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete User:";
            // 
            // deletekeeper
            // 
            this.deletekeeper.AllowUserToAddRows = false;
            this.deletekeeper.AllowUserToDeleteRows = false;
            this.deletekeeper.AllowUserToResizeColumns = false;
            this.deletekeeper.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.deletekeeper.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.deletekeeper.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deletekeeper.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.deletekeeper.ColumnHeadersHeight = 60;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.deletekeeper.DefaultCellStyle = dataGridViewCellStyle3;
            this.deletekeeper.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.deletekeeper.Location = new System.Drawing.Point(-2, 60);
            this.deletekeeper.Name = "deletekeeper";
            this.deletekeeper.ReadOnly = true;
            this.deletekeeper.RowHeadersVisible = false;
            this.deletekeeper.Size = new System.Drawing.Size(1084, 668);
            this.deletekeeper.TabIndex = 4;
            this.deletekeeper.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.deletekeeper.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.deletekeeper.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.deletekeeper.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.deletekeeper.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.deletekeeper.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deletekeeper.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.deletekeeper.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.deletekeeper.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.deletekeeper.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletekeeper.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.deletekeeper.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.deletekeeper.ThemeStyle.HeaderStyle.Height = 60;
            this.deletekeeper.ThemeStyle.ReadOnly = true;
            this.deletekeeper.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.deletekeeper.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.deletekeeper.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletekeeper.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.deletekeeper.ThemeStyle.RowsStyle.Height = 22;
            this.deletekeeper.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.deletekeeper.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deletekeeper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.Load += new System.EventHandler(this.Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deletekeeper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BackBT;
        private Guna.UI2.WinForms.Guna2Button DeleteBT;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView deletekeeper;
    }
}