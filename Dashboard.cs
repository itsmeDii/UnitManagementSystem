using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace System
{
    public partial class Dashboard : Form
    {

        private  Guna2Panel[] rooms;

        public Dashboard()
        {
            InitializeComponent();
            activeTab();
            configureRooms();

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void activeTab()
        {
            lblAvailableUnit.ForeColor = Color.White;
            lblOccupiedUnit.ForeColor = Color.Black;
            lblAvailableUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.FromArgb(76, 205, 153);
            lblOccupiedUnit.BackColor = Color.Transparent;
            lblOccuIcon.BackColor = Color.Transparent;
            pnlAvailUnit.Visible = true;
            pnlOccUnit.Visible = false;
        }

        private void configureRooms()
        {
            rooms = new Guna2Panel[] {room1, room2, room3 , room4 ,
                room5, room6, room7, room8, room9, room10 };

            foreach (var room in rooms)
            {
                room.Click += Room_Click;
            }

        }

        private void Room_Click(object sender, EventArgs e)
        {
            Guna2Panel clickedPanel = (Guna2Panel)sender;
            Image backgroundImage = clickedPanel.BackgroundImage;
            int roomIndex = Array.IndexOf(rooms, clickedPanel) + 1;


            if (backgroundImage != null)
            {
                roomImage.SizeMode = PictureBoxSizeMode.Zoom;
                roomImage.Image = backgroundImage;
            }
            else { 
                roomImage.Image = null; 
                MessageBox.Show("The clicked panel does not have a background image.");
            }

            roomNumber.Text = "Room" + " " + roomIndex.ToString();

        }


        private void lblAvailableUnit_Click(object sender, EventArgs e)
        {
            lblAvailableUnit.ForeColor = Color.White;
            lblOccupiedUnit.ForeColor = Color.Black;
            lblAvailableUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.FromArgb(76, 205, 153);
            lblOccupiedUnit.BackColor = Color.Transparent;
            lblOccuIcon.BackColor = Color.Transparent;
            pnlAvailUnit.Visible = true;
            pnlOccUnit.Visible = false;
        }

   
        private void lblCheckIcon_Click(object sender, EventArgs e)
        {
            lblAvailableUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.FromArgb(76, 205, 153);
            lblOccupiedUnit.BackColor = Color.Transparent;
            lblOccuIcon.BackColor = Color.Transparent;
            pnlAvailUnit.Visible = true;
            pnlOccUnit.Visible = false;
        }

        private void lblOccupiedUnit_Click(object sender, EventArgs e)
        {
            lblOccupiedUnit.ForeColor = Color.White;
            lblAvailableUnit.ForeColor = Color.Black;
            lblOccuIcon.BackColor = Color.FromArgb(76, 205, 153);
            lblOccupiedUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.Transparent;
            lblAvailableUnit.BackColor = Color.Transparent;
            pnlAvailUnit.Visible = false;
            pnlOccUnit.Visible = true;
        }

        private void lblOccuIcon_Click(object sender, EventArgs e)
        {
            lblOccuIcon.BackColor = Color.FromArgb(76, 205, 153);
            lblOccupiedUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.Transparent;
            lblAvailableUnit.BackColor = Color.Transparent;
            pnlAvailUnit.Visible = false;
            pnlOccUnit.Visible = true;
        }

        private void pnlAvailUnit_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
