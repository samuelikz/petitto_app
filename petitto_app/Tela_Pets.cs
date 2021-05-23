using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petitto_app
{
    public partial class Tela_Pets : Form
    {
        public Tela_Pets()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Pets_Load(object sender, EventArgs e)
        {
            var pets = ListarPets.BuscarPets();

            foreach (ListarPets pet in pets)
            {
                ListViewItem item = new ListViewItem(new[] {
                    pet.id.ToString(), pet.name.ToString(), pet.birthDate.ToString(), pet.nin.ToString() 
                });
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
