using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;  // Fornece classes para diversos protocolos de rede
using System.IO;   // Fornece classes para ler e gravar arquivos e fluxo de dados 
using Newtonsoft.Json;

namespace petitto_app
{
    public partial class Tela_Alterar : Form
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string nome_pet { get; set; } // Verificar como virar da api, nome pet
        public string raca { get; set; }
        public string sexo { get; set; }
        public string idade { get; set; }
        public string urlimage { get; set; }
        public string categoria { get; set; }
        public string descrincao { get; set; }
        public Tela_Alterar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Pesquisar()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Informe o ID para alterar.");
                textBox1.Focus();
                return;
            }
            try
            {
                var rota = "https://doa-bem-api.onrender.com/pets/" + textBox1.Text; // Endereço da [API]
                var requisicaoWeb = WebRequest.CreateHttp(rota);
                requisicaoWeb.Method = "GET";
                var response = (HttpWebResponse)requisicaoWeb.GetResponse();
                var streamDados = response.GetResponseStream();
                // Classe StreamReader: Lê caracteres de um fluxo de bytes 
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();
                var users = JsonConvert.DeserializeObject<NewDoacao>(objResponse.ToString());
                textBox6.Text = users.nome;
                textBox2.Text = users.email;
                textBox3.Text = users.cpf;
                textBox4.Text = users.telefone;
                textBox8.Text = users.nome_pet;
                comboBox2.Text = users.sexo;
                comboBox3.Text = users.idade;
                comboBox1.Text = users.categoria;
                textBox5.Text = users.raca;
                textBox9.Text = users.urlimage;
                textBox10.Text = users.descrincao;

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
        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void success()
        {
            string message = "Alteração Realizada \n";
            string title = "Sucesso";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Information);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                string rota = "https://doa-bem-api.onrender.com/pets/" + textBox1.Text;


                User users = new User();

                users.nome = textBox6.Text;
                users.email = textBox2.Text;
                users.cpf = textBox3.Text;
                users.telefone=textBox4.Text;
                users.nome_pet=textBox8.Text;
                users.sexo=comboBox2.Text;
                users.idade=comboBox3.Text;
                users.categoria=comboBox1.Text;
                users.raca=textBox5.Text;
                users.urlimage=textBox9.Text; 
                users.descrincao=textBox10.Text;

                String json = JsonConvert.SerializeObject(users);

                var requisicaoWeb = WebRequest.CreateHttp(rota);
                requisicaoWeb.Method = "PUT";

                requisicaoWeb.ContentType = "application/json; charset=utf-8";

                var byteArray = Encoding.UTF8.GetBytes(json);

                requisicaoWeb.ContentLength = byteArray.Length;

                Stream stream = requisicaoWeb.GetRequestStream();

                success();
                stream.Write(byteArray, 0, byteArray.Length);
                stream.Close();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

