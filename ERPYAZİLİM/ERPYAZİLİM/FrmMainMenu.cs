using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPYAZİLİM
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        Formlar.FrmAnasayfaa fr11;
        private void button1_Click(object sender, EventArgs e)
        {
            if (fr11 == null)
            {
                fr11 = new Formlar.FrmAnasayfaa();
                fr11.FormClosed += Fr11_FormClosed;
                fr11.MdiParent = this;
                fr11.Show();
            }
            else
            {
                fr11.Activate();
            }
           


        }

        private void Fr11_FormClosed(object sender, FormClosedEventArgs e)
        {
            fr11 = null;
        }

        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if(menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 248)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if(menuContainer.Height<= 65)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 20;
                if (sidebar.Width <= 49)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 20;
                if (sidebar.Width >= 266)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    panel1.Width = sidebar.Width;
                    panel2.Width = sidebar.Width;
                    panel3.Width = sidebar.Width;
                    panel4.Width = sidebar.Width;
                }
            }
        }
        

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
           
        }
    }
}
