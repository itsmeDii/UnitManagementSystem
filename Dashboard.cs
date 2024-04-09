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
            hideRoomInformation();

            grpBoxFirst.Hide();
            grpBoxSecond.Hide();
            grpBoxThird.Hide();
            grpBoxFourth.Hide();
            grpBoxFifth.Hide();
            grpBoxSixth.Hide();
            grpBoxSeventh.Hide();
            grpBoxEigth.Hide();
            grpBoxNinth.Hide();

            btnGround.ForeColor = Color.White;
            btnGround.FillColor = Color.FromArgb(76, 205, 153);
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
            lblAvailableUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.FromArgb(76, 205, 153);
            pnlAvailUnit.Visible = true;
        }

        private void configureRooms()
        {
            rooms = new Guna2Panel[] {
                room1, room2, room3 , room4 ,room5, room6, room7, room8, room9, room10, room11, 
                room12, room13 , room14 ,room15, room16, room17, room18, room19, room20, room21, 
                room22, room23 , room24 ,room25, room26, room27, room28, room29, room30, room31, 
                room32, room33 , room34 ,room35, room36, room37, room38, room39, room40, room41, 
                room42, room43 , room44 , room45, room46, room47, room48, room49, room50,
                room51, room52, room53 , room54 ,room55, room56, room57, room58, room59, room60,  room61,
                room62, room63 , room64 ,room65, room66, room67, room68, room69, room70, room71,
                room72, room73 , room74 ,room75, room76, room77, room78, room79, room80, room81,
                room82, room83 , room84 ,room85, room86, room87, room88, room89, room90, room91,
                room92, room93 , room94 , room95, room96, room97, room98, room99, room100,};
            
            foreach (var room in rooms)
            {
                room.Click += Room_Click;
                room.MouseLeave += Room_MouseLeave;
            }

        }

        private void hideRoomInformation()
        {
            roomInformation.Hide();
            roomNumber.Hide();
            roomNumberPanel.Hide();
            roomImage.Hide();
        }

        private void showRoomInformation()
        {
            roomInformation.Show();
            roomNumber.Show();
            roomNumberPanel.Show();
            roomImage.Show();
        }


        private void Room_Click(object sender, EventArgs e)
        {
            Guna2Panel clickedPanel = (Guna2Panel)sender;
            Image backgroundImage = clickedPanel.BackgroundImage;
            int roomIndex = Array.IndexOf(rooms, clickedPanel) + 1;

            //update image dipende sa iamge nung room 

       /*     if (backgroundImage != null)
            {
                roomImage.SizeMode = PictureBoxSizeMode.StretchImage;
                roomImage.Image = backgroundImage;
            }
            else { 
                roomImage.Image = null; 
                MessageBox.Show("The clicked panel does not have a background image.");
            }
*/
            roomNumber.Text = "Room" + " " + roomIndex.ToString();

            showRoomInformation();

        }

        private void Room_MouseLeave(object sender, EventArgs e)
        {
            hideRoomInformation();
        }


        private void lblAvailableUnit_Click(object sender, EventArgs e)
        {
            lblAvailableUnit.ForeColor = Color.White;
            lblAvailableUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.FromArgb(76, 205, 153);
            pnlAvailUnit.Visible = true;

        }

   
        private void lblCheckIcon_Click(object sender, EventArgs e)
        {
            lblAvailableUnit.BackColor = Color.FromArgb(76, 205, 153);
            lblCheckIcon.BackColor = Color.FromArgb(76, 205, 153);
            pnlAvailUnit.Visible = true;
        }

        private void btnGround_Click_1(object sender, EventArgs e)
        {
            label10.ForeColor = Color.White;
            btnGround.FillColor = Color.FromArgb(76, 205, 153);
            btnFirstFloor.FillColor = Color.DimGray;
            btnSecondFloor.FillColor = Color.DimGray;
            btnThirdFloor.FillColor = Color.DimGray;
            btnFourthFloor.FillColor = Color.DimGray;
            btnFifthFloor.FillColor = Color.DimGray;
            btnSixthFloor.FillColor = Color.DimGray;
            btnSeventFloor.FillColor = Color.DimGray;
            btnEightFloor.FillColor = Color.DimGray;
            btnNinthFloor.FillColor = Color.DimGray;

            lblCurrentFloor.Text = "GROUND FLOOR";

            grpBoxGround.Show();
            grpBoxFirst.Hide();
            grpBoxSecond.Hide();
            grpBoxThird.Hide();
            grpBoxFourth.Hide();
            grpBoxFifth.Hide();
            grpBoxSixth.Hide();
            grpBoxSeventh.Hide();
            grpBoxEigth.Hide();
            grpBoxNinth.Hide();
        }

        private void btnFirstFloor_Click(object sender, EventArgs e)
        {
            label12.ForeColor = Color.White;
            btnFirstFloor.FillColor = Color.FromArgb(76, 205, 153);

            btnGround.FillColor = Color.DimGray;
            btnSecondFloor.FillColor = Color.DimGray;
            btnThirdFloor.FillColor = Color.DimGray;
            btnFourthFloor.FillColor = Color.DimGray;
            btnFifthFloor.FillColor = Color.DimGray;
            btnSixthFloor.FillColor = Color.DimGray;
            btnSeventFloor.FillColor = Color.DimGray;
            btnEightFloor.FillColor = Color.DimGray;
            btnNinthFloor.FillColor = Color.DimGray;

            lblCurrentFloor.Text = "FIRST FLOOR";

            grpBoxGround.Hide();
            grpBoxFirst.Show();
            grpBoxSecond.Hide();
            grpBoxThird.Hide();
            grpBoxFourth.Hide();
            grpBoxFifth.Hide();
            grpBoxSixth.Hide();
            grpBoxSeventh.Hide();
            grpBoxEigth.Hide();
            grpBoxNinth.Hide();
        }

        private void btnSecondFloor_Click(object sender, EventArgs e)
        {
            label14.ForeColor = Color.White;
            btnSecondFloor.FillColor = Color.FromArgb(76, 205, 153);

            btnGround.FillColor = Color.DimGray;
            btnFirstFloor.FillColor = Color.DimGray;
            btnThirdFloor.FillColor = Color.DimGray;
            btnFourthFloor.FillColor = Color.DimGray;
            btnFifthFloor.FillColor = Color.DimGray;
            btnSixthFloor.FillColor = Color.DimGray;
            btnSeventFloor.FillColor = Color.DimGray;
            btnEightFloor.FillColor = Color.DimGray;
            btnNinthFloor.FillColor = Color.DimGray;

            lblCurrentFloor.Text = "SECOND FLOOR";

            grpBoxGround.Hide();
            grpBoxFirst.Hide();
            grpBoxSecond.Show();
            grpBoxThird.Hide();
            grpBoxFourth.Hide();
            grpBoxFifth.Hide();
            grpBoxSixth.Hide();
            grpBoxSeventh.Hide();
            grpBoxEigth.Hide();
            grpBoxNinth.Hide();
        }

        private void btnThirdFloor_Click(object sender, EventArgs e)
        {
            label16.ForeColor = Color.White;
            btnThirdFloor.FillColor = Color.FromArgb(76, 205, 153);

            btnGround.FillColor = Color.DimGray;
            btnFirstFloor.FillColor = Color.DimGray;
            btnSecondFloor.FillColor = Color.DimGray;
            btnFourthFloor.FillColor = Color.DimGray;
            btnFifthFloor.FillColor = Color.DimGray;
            btnSixthFloor.FillColor = Color.DimGray;
            btnSeventFloor.FillColor = Color.DimGray;
            btnEightFloor.FillColor = Color.DimGray;
            btnNinthFloor.FillColor = Color.DimGray;

            lblCurrentFloor.Text = "THIRD FLOOR";

            grpBoxGround.Hide();
            grpBoxFirst.Hide();
            grpBoxSecond.Hide();
            grpBoxThird.Show();
            grpBoxFourth.Hide();
            grpBoxFifth.Hide();
            grpBoxSixth.Hide();
            grpBoxSeventh.Hide();
            grpBoxEigth.Hide();
            grpBoxNinth.Hide();
        }

        private void btnFourthFloor_Click(object sender, EventArgs e)
        {
            label18.ForeColor = Color.White;
            btnFourthFloor.FillColor = Color.FromArgb(76, 205, 153);

            btnGround.FillColor = Color.DimGray;
            btnFirstFloor.FillColor = Color.DimGray;
            btnSecondFloor.FillColor = Color.DimGray;
            btnThirdFloor.FillColor = Color.DimGray;
            btnFifthFloor.FillColor = Color.DimGray;
            btnSixthFloor.FillColor = Color.DimGray;
            btnSeventFloor.FillColor = Color.DimGray;
            btnEightFloor.FillColor = Color.DimGray;
            btnNinthFloor.FillColor = Color.DimGray;

            lblCurrentFloor.Text = "FOURTH FLOOR";

            grpBoxGround.Hide();
            grpBoxFirst.Hide();
            grpBoxSecond.Hide();
            grpBoxThird.Hide();
            grpBoxFourth.Show();
            grpBoxFifth.Hide();
            grpBoxSixth.Hide();
            grpBoxSeventh.Hide();
            grpBoxEigth.Hide();
            grpBoxNinth.Hide();
        }

        private void btnFifthFloor_Click(object sender, EventArgs e)
        {
            label20.ForeColor = Color.White;
            btnFifthFloor.FillColor = Color.FromArgb(76, 205, 153);

            btnGround.FillColor = Color.DimGray;
            btnFirstFloor.FillColor = Color.DimGray;
            btnSecondFloor.FillColor = Color.DimGray;
            btnThirdFloor.FillColor = Color.DimGray;
            btnFourthFloor.FillColor = Color.DimGray;
            btnSixthFloor.FillColor = Color.DimGray;
            btnSeventFloor.FillColor = Color.DimGray;
            btnEightFloor.FillColor = Color.DimGray;
            btnNinthFloor.FillColor = Color.DimGray;

            lblCurrentFloor.Text = "FIFTH FLOOR";

            grpBoxGround.Hide();
            grpBoxFirst.Hide();
            grpBoxSecond.Hide();
            grpBoxThird.Hide();
            grpBoxFourth.Hide();
            grpBoxFifth.Show();
            grpBoxSixth.Hide();
            grpBoxSeventh.Hide();
            grpBoxEigth.Hide();
            grpBoxNinth.Hide();
        }

        private void btnSixthFloor_Click(object sender, EventArgs e)
        {
            label22.ForeColor = Color.White;
            btnSixthFloor.FillColor = Color.FromArgb(76, 205, 153);

            btnGround.FillColor = Color.DimGray;
            btnFirstFloor.FillColor = Color.DimGray;
            btnSecondFloor.FillColor = Color.DimGray;
            btnThirdFloor.FillColor = Color.DimGray;
            btnFourthFloor.FillColor = Color.DimGray;
            btnFifthFloor.FillColor = Color.DimGray;
            btnSeventFloor.FillColor = Color.DimGray;
            btnEightFloor.FillColor = Color.DimGray;
            btnNinthFloor.FillColor = Color.DimGray;

            lblCurrentFloor.Text = "SIXTH FLOOR";

            grpBoxGround.Hide();
            grpBoxFirst.Hide();
            grpBoxSecond.Hide();
            grpBoxThird.Hide();
            grpBoxFourth.Hide();
            grpBoxFifth.Hide();
            grpBoxSixth.Show();
            grpBoxSeventh.Hide();
            grpBoxEigth.Hide();
            grpBoxNinth.Hide();
        }

        private void btnSeventFloor_Click(object sender, EventArgs e)
        {
            label24.ForeColor = Color.White;
            btnSeventFloor.FillColor = Color.FromArgb(76, 205, 153);

            btnGround.FillColor = Color.DimGray;
            btnFirstFloor.FillColor = Color.DimGray;
            btnSecondFloor.FillColor = Color.DimGray;
            btnThirdFloor.FillColor = Color.DimGray;
            btnFourthFloor.FillColor = Color.DimGray;
            btnFifthFloor.FillColor = Color.DimGray;
            btnSixthFloor.FillColor = Color.DimGray;
            btnEightFloor.FillColor = Color.DimGray;
            btnNinthFloor.FillColor = Color.DimGray;

            lblCurrentFloor.Text = "SEVENTH FLOOR";

            grpBoxGround.Hide();
            grpBoxFirst.Hide();
            grpBoxSecond.Hide();
            grpBoxThird.Hide();
            grpBoxFourth.Hide();
            grpBoxFifth.Hide();
            grpBoxSixth.Hide();
            grpBoxSeventh.Show();
            grpBoxEigth.Hide();
            grpBoxNinth.Hide();
        }

        private void btnEightFloor_Click(object sender, EventArgs e)
        {
            label26.ForeColor = Color.White;
            btnEightFloor.FillColor = Color.FromArgb(76, 205, 153);

            btnGround.FillColor = Color.DimGray;
            btnFirstFloor.FillColor = Color.DimGray;
            btnSecondFloor.FillColor = Color.DimGray;
            btnThirdFloor.FillColor = Color.DimGray;
            btnFourthFloor.FillColor = Color.DimGray;
            btnFifthFloor.FillColor = Color.DimGray;
            btnSixthFloor.FillColor = Color.DimGray;
            btnSeventFloor.FillColor = Color.DimGray;
            btnNinthFloor.FillColor = Color.DimGray;

            lblCurrentFloor.Text = "EIGHTH FLOOR";

            grpBoxGround.Hide();
            grpBoxFirst.Hide();
            grpBoxSecond.Hide();
            grpBoxThird.Hide();
            grpBoxFourth.Hide();
            grpBoxFifth.Hide();
            grpBoxSixth.Hide();
            grpBoxSeventh.Hide();
            grpBoxEigth.Show();
            grpBoxNinth.Hide();
        }

        private void btnNinthFloor_Click(object sender, EventArgs e)
        {
            label28.ForeColor = Color.White;
            btnNinthFloor.FillColor = Color.FromArgb(76, 205, 153);

            btnGround.FillColor = Color.DimGray;
            btnFirstFloor.FillColor = Color.DimGray;
            btnSecondFloor.FillColor = Color.DimGray;
            btnThirdFloor.FillColor = Color.DimGray;
            btnFourthFloor.FillColor = Color.DimGray;
            btnFifthFloor.FillColor = Color.DimGray;
            btnSixthFloor.FillColor = Color.DimGray;
            btnSeventFloor.FillColor = Color.DimGray;
            btnEightFloor.FillColor = Color.DimGray;

            lblCurrentFloor.Text = "NINTH FLOOR";

            grpBoxGround.Hide();
            grpBoxFirst.Hide();
            grpBoxSecond.Hide();
            grpBoxThird.Hide();
            grpBoxFourth.Hide();
            grpBoxFifth.Hide();
            grpBoxSixth.Hide();
            grpBoxSeventh.Hide();
            grpBoxEigth.Hide();
            grpBoxNinth.Show();
        }
    }
}
