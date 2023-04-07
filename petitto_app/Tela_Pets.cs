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
            var buscarpets = ListPets.BuscarPets();
            foreach (var item in from ListPets busca in buscarpets ?? new ListarPets<string>()
                                 let item = new ListViewItem(new[] { busca.id.ToString(),  busca.nome.ToString(), busca.sexo.ToString(), busca.idade.ToString(), busca.raca.ToString(), busca.categoria.ToString(), busca.urlimage.ToString(), busca.descrincao.ToString() })
                                 select item)
            {
                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
    internal class ListarPets<T> : List<ListPets>
    {
    }
}
