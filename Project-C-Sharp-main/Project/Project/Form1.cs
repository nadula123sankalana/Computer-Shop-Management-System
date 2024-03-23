using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;


        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            homeControl1.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            homeControl1.BringToFront();
        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {
           
        }


        private void btnProduct_Click_1(object sender, EventArgs e)
        {
            SidePanel.Height = btnProduct.Height;
            SidePanel.Top = btnProduct.Top;
            productControl1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
           private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnCart.Height;
            SidePanel.Top = btnCart.Top;
            cartControl11.BringToFront();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHelp.Height;
            SidePanel.Top = btnHelp.Top;
            helpControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnLogin.Height;
            SidePanel.Top = btnLogin.Top;
            loginControl1.BringToFront();
        }

     

        private void cartControl11_Load(object sender, EventArgs e)
        {
         
        }

        private void loginControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
