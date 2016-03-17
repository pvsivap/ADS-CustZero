using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustZero_Tours
{
    public partial class Form1 : Form
    {
        bool isIntTravel = false;
        bool isDomTravel = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void LblDomasticTour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //lblTourName.BackColor = Color.Red;
            //lblTourName1.ForeColor = Color.Blue;
            lblTourName1.Text = "Delhi Tour";
            lblTourName1.Font = new Font("Georgia", 12);

            //lblTourName2.BackColor = Color.Red;
            //lblTourName2.ForeColor = Color.Blue;
            lblTourName2.Text = "Agra Madhura Tour";
            lblTourName2.Font = new Font("Georgia", 12);

            //lblTourName3.BackColor = Color.Red;
            //lblTourName3.ForeColor = Color.Blue;
            lblTourName3.Text = "Manali Tour";
            lblTourName3.Font = new Font("Georgia", 12);

            //lblTourName4.BackColor = Color.Red;
            //lblTourName4.ForeColor = Color.Blue;
            lblTourName4.Text = "Kashmir Tour";
            lblTourName4.Font = new Font("Georgia", 12);

            //lblTourName5.BackColor = Color.Red;
            //lblTourName5.ForeColor = Color.Blue;
            lblTourName5.Text = "Amarnath Tour";
            lblTourName5.Font = new Font("Georgia", 12);

            //lblTourName6.BackColor = Color.Red;
            //lblTourName6.ForeColor = Color.Blue;
            lblTourName6.Text = "Rishikesh Tour";
            lblTourName6.Font = new Font("Georgia", 12);

            pnlTour.Visible = true;
            isIntTravel = false;
            isDomTravel = true;
        }

        private void lblIntNatTour_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //lblTourName1.BackColor = Color.Red;
            //lblTourName1.ForeColor = Color.Blue;
            lblTourName1.Text = "Amarica Tour";
            lblTourName1.Font = new Font("Georgia", 12);

            //lblTourName2.BackColor = Color.Red;
            //lblTourName2.ForeColor = Color.Blue;
            lblTourName2.Text = "Africa Madhura Tour";
            lblTourName2.Font = new Font("Georgia", 12);

            //lblTourName3.BackColor = Color.Red;
            //lblTourName3.ForeColor = Color.Blue;
            lblTourName3.Text = "Australia Tour";
            lblTourName3.Font = new Font("Georgia", 12);

            //lblTourName4.BackColor = Color.Red;
            //lblTourName4.ForeColor = Color.Blue;
            lblTourName4.Text = "China Tour";
            lblTourName4.Font = new Font("Georgia", 12);

            //lblTourName5.BackColor = Color.Red;
            //lblTourName5.ForeColor = Color.Blue;
            lblTourName5.Text = "Greece Tour";
            lblTourName5.Font = new Font("Georgia", 12);

            // lblTourName6.BackColor = Color.Red;
            // lblTourName6.ForeColor = Color.Blue;
            lblTourName6.Text = "Swiss Tour";
            lblTourName6.Font = new Font("Georgia", 12);

            pnlTour.Visible = true;
            isIntTravel = true;
            isDomTravel = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlTour.Visible = false;
            pctTour.Visible = false;
            btBooking.Visible = false;
            pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\ToursAndTraves.png");
            //LblDomasticTour.BackColor = Color.Red;
            //lblIntNatTour.BackColor = Color.Red;

            LblDomasticTour.Font = new Font("Georgia", 14);
            lblIntNatTour.Font = new Font("Georgia", 14);
        }

        private void lblTourName1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((lblTourName1.Text == "Delhi Tour") && (isDomTravel))
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\DelhiTour.png");
            //pctTour.Image = Image.FromFile("\\Tours\\DelhiTour.png");
            else
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\America.png");
            //pctTour.Image = Image.FromFile("\\Tours\\America.png");

            pctTour.SizeMode = PictureBoxSizeMode.CenterImage;
            pctTour.SizeMode = PictureBoxSizeMode.AutoSize;
            pctTour.Visible = true;
            btBooking.Visible = true;

        }

        private void lblTourName2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((lblTourName2.Text == "Agra Madhura Tour") && (isDomTravel))
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\Agra-Mathura.png");
            else
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\Africa.png");

            pctTour.SizeMode = PictureBoxSizeMode.CenterImage;
            pctTour.SizeMode = PictureBoxSizeMode.AutoSize;
            pctTour.Visible = true;
            btBooking.Visible = true;
        }

        private void lblTourName3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((lblTourName3.Text == "Manali Tour") && (isDomTravel))
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\Simla.png");
            else
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\Australia.png");

            pctTour.SizeMode = PictureBoxSizeMode.CenterImage;
            pctTour.SizeMode = PictureBoxSizeMode.AutoSize;
            pctTour.Visible = true;
            btBooking.Visible = true;
        }

        private void lblTourName4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((lblTourName4.Text == "Kashmir Tour") && (isDomTravel))
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\Kashmir.png");
            else
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\China.png");

            pctTour.SizeMode = PictureBoxSizeMode.CenterImage;
            pctTour.SizeMode = PictureBoxSizeMode.AutoSize;
            pctTour.Visible = true;
            btBooking.Visible = true;
        }

        private void lblTourName5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((lblTourName5.Text == "Amarnath Tour") && (isDomTravel))
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\Amarnath.png");
            else
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\Greese.png");

            pctTour.SizeMode = PictureBoxSizeMode.CenterImage;
            pctTour.SizeMode = PictureBoxSizeMode.AutoSize;
            pctTour.Visible = true;
            btBooking.Visible = true;
        }

        private void lblTourName6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((lblTourName5.Text == "Rishikesh Tour") && (isDomTravel))
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\Rshikesh.png");
            else
                pctTour.Image = Image.FromFile("D:\\Siva\\Tours\\Swiss.png");

            pctTour.SizeMode = PictureBoxSizeMode.CenterImage;
            pctTour.SizeMode = PictureBoxSizeMode.AutoSize;
            pctTour.Visible = true;
            btBooking.Visible = true;
        }

        private void pctTour_Click(object sender, EventArgs e)
        {

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
