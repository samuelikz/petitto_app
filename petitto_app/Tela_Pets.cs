using System;
using System.Collections.Generic;
using System.Linq;
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
            foreach (var item in from ListarPets pet in pets ?? new ListarPets<string>()
                                 let item = new ListViewItem(new[] { pet.id.ToString(), pet.cpf.ToString(), pet.nome.ToString(), pet.sexo.ToString(), pet.idade.ToString(), pet.raca.ToString(), pet.urlimage.ToString(), pet.categoria.ToString(), pet.descrincao.ToString() })
                                 select item)
            {
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    internal class ListarPets<T> : List<ListarPets>
    {
    }
}
