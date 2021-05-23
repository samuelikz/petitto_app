using System;
using System.Drawing;
using System.Windows.Forms;

namespace petitto_app
{
    public partial class Tela_Inicial : Form
    {
        bool Mov = false; // .. Função Mover
        Point Pos; // .. Função Mover
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.Location = Screen.AllScreens[0].WorkingArea.Location;
        }

        private void buttonExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMax_Click(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new Tela_Pets());
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Mov = true;
            Pos = new Point(e.X, e.Y);
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            Mov = false;
        }
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Mov)
            {
                Point Novo = PointToScreen(e.Location);
                Location = new Point(Novo.X - Pos.X, Novo.Y - Pos.Y);
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new Tela_Usuarios());
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Tela_Cadastro());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
