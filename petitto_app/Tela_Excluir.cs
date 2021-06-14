using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace petitto_app
{
    public partial class Tela_Excluir : Form
    {
        public Tela_Excluir()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                app_controller.excluirUsuarioPorId(textBox1.Text);
                textBox6.Text = "" ;
                textBox2.Text = "" ;
                textBox3.Text = "" ;
                textBox4.Text = "" ;
                textBox8.Text = "";
                textBox5.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Informe o ID para alterar.");
                textBox1.Focus();
                return;
            }
                try
            {
                var rota = "https://json-serverikz.herokuapp.com/pets/" + textBox1.Text; // Endereço da [API]
                var requisicaoWeb = WebRequest.CreateHttp(rota);
                requisicaoWeb.Method = "GET";
                var response = (HttpWebResponse)requisicaoWeb.GetResponse();
                var streamDados = response.GetResponseStream();
                // Classe StreamReader: Lê caracteres de um fluxo de bytes 
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                var user = JsonConvert.DeserializeObject<User>(objResponse.ToString());
                textBox6.Text = user.nome;
                textBox2.Text = user.email;
                textBox3.Text = user.cpf;
                textBox4.Text = user.telefone;
                textBox8.Text = user.nome_pet;
                textBox5.Text = user.raca;
                textBox9.Text = user.urlimage;
                textBox10.Text = user.descrincao;

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
    }
}
