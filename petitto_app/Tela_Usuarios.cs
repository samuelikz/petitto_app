using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace petitto_app
{
    public partial class Tela_Usuarios : Form
    {
        public Tela_Usuarios()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tela_Usuarios_Load(object sender, EventArgs e)
        {
            var users = ListarUsers.BuscarUsers();

                foreach (var item in from ListarUsers user in users ?? new ListarUsers<string>()
                                     let item = new ListViewItem(new[] { user.id.ToString(), user.cpf.ToString(), user.nome.ToString(), user.email.ToString(), user.telefone.ToString() })
                                     select item)
                {
                    listView_Users.Items.Add(item);
                }
        }

        private void listView_Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    internal class ListarUsers<T> : List<ListarUsers>
    {
    }
}
