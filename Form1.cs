using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbWaldoPage.BackColor = Color.Transparent;

            double score = 0;
            





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbWaldoHitbox.Location = new Point(pbWaldoHitbox.Location.X - pbWaldoPage.Location.X, pbWaldoHitbox.Location.Y - pbWaldoPage.Location.Y);
            pbWaldoHitbox.Parent = pbWaldoPage;

            pbEvilWaldoHitbox.Location = new Point(pbEvilWaldoHitbox.Location.X - pbWaldoPage.Location.X, pbEvilWaldoHitbox.Location.Y - pbWaldoPage.Location.Y);
            pbEvilWaldoHitbox.Parent = pbWaldoPage;

            pbWizardHitbox.Location = new Point(pbWizardHitbox.Location.X - pbWaldoPage.Location.X, pbWizardHitbox.Location.Y - pbWaldoPage.Location.Y);
            pbWizardHitbox.Parent = pbWaldoPage;

            pbWilmaHitbox.Location = new Point(pbWilmaHitbox.Location.X - pbWaldoPage.Location.X, pbWilmaHitbox.Location.Y - pbWaldoPage.Location.Y);
            pbWilmaHitbox.Parent = pbWaldoPage;

            








        }

        private void waldoHitbox_Click(object sender, EventArgs e)
        {
            //lblTitle.Text = "U win";
            

        }

        private void btnWaldo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("clicked");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Waldo Found!";
            





            pbWaldoHitbox.Image = Properties.Resources.BigRedCircle;

        }

        private void pbEvilWaldoHitbox_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Evil Waldo Found!";
            
            pbEvilWaldoHitbox.Image = Properties.Resources.BigRedCircle;
            
        }

        private void pbWizardHitbox_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "The Wizard Found!";
           

            pbWizardHitbox.Image = Properties.Resources.BigRedCircle;
        }

        private void pbWilmaHitbox_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Wilma Found!";
           

            pbWilmaHitbox.Image = Properties.Resources.BigRedCircle;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pbHint.Visible = false;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        
        }
    }
}
