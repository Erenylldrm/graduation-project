using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPYAZİLİM
{
    public partial class FrmMainMenü : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FrmMainMenü()
        {
            InitializeComponent();
            random = new Random();
            btnClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            Button clickedButton = btnSender as Button;
            if (clickedButton != null)
            {
                if (currentButton != clickedButton)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    PanelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnClose.Visible = true;
                }
            }
       
        
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            // Alt formun boyutunu panelin boyutuna göre ayarla
            childForm.Size = panelDestktopPanel.Size;

            // Alt formun konumunu panelin ortasına ayarla
            childForm.Location = new Point((panelDestktopPanel.Width - childForm.Width) / 2, (panelDestktopPanel.Height - childForm.Height) / 2);

            panelDestktopPanel.Controls.Add(childForm);
            panelDestktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        /*{
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDestktopPanel.Controls.Add(childForm);
            this.panelDestktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }*/

        private void FrmMainMenü_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FrmFaturaSatışİşlemi(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FrmMüşteriListesi(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FrmÜrünListesi(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FrmPersonelListesi(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FrmArizalıÜrünListesi(), sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Formlar.FrmBarcode(), sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            label1.Text = "HOME";
            PanelTitleBar.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.BackColor = Color.FromArgb(39,39,58);
            currentButton = null;
            btnClose.Visible = false;
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
