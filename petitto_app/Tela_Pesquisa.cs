using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace petitto_app
{
    public partial class Tela_Pesquisa : Form
    {
        public Tela_Pesquisa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PesquidarId(string id)
        {
            try
            {
                // Endereço da [API]
                var rota = "https://json-serverikz.herokuapp.com/doacao/" + id; 

                var requisicaoWeb = WebRequest.CreateHttp(rota);
                requisicaoWeb.Method = "GET";
                var response = (HttpWebResponse)requisicaoWeb.GetResponse();
                var streamDados = response.GetResponseStream();

                // Classe StreamReader: Lê caracteres de um fluxo de bytes 
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                // converter objeto
                var data = JsonConvert.DeserializeObject<NewDoacao>(objResponse.ToString()); 
                
                textNome.Text = data.nome;
                textEmail.Text = data.email;
                textCpf.Text = data.cpf;
                textTelefone.Text = data.telefone;
                textNome_pet.Text = data.nome_pet;
                textsexo.Text = data.sexo;
                textidade.Text = data.idade;
                textcategoria.Text = data.categoria;
                textRaca.Text = data.raca;
                textUrl.Text = data.urlimage;
                textDescrincao.Text = data.descrincao;

                streamDados.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                string message = "Não foi possivel consultar os dados \n" + "Erro: " + ex.Message;
                string title = "Algo deu errado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
        }

        public void erro()
        {
            string message = "Informe o Id de quem sera pesquisado! \n";
            string title = "Algo Deu Errado";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                erro();
                textBox1.Focus();
                return;
            }
            else
            {
                PesquidarId(textBox1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
