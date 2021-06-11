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

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Informe o ID para alterar");
                    textBox1.Focus();
                    return;
                }
                //string rota = "http://localhost:3000/usuarioRoute/" + txtId.Text;
                string rota = "https://json-serverikz.herokuapp.com/doacao" + textBox1.Text;


                User usuario = new User(textBox6.Text, textBox4.Text, textBox2.Text);

                String json = JsonConvert.SerializeObject(usuario);

                var requisicaoWeb = WebRequest.CreateHttp(rota);
                requisicaoWeb.Method = "PUT";

                requisicaoWeb.ContentType = "application/json; charset=utf-8";

                var byteArray = Encoding.UTF8.GetBytes(json);

                requisicaoWeb.ContentLength = byteArray.Length;

                Stream stream = requisicaoWeb.GetRequestStream();

                stream.Write(byteArray, 0, byteArray.Length);
                stream.Close();

                MessageBox.Show("Alteração realizada");
            }
            catch (System.Net.WebException error)
            {
                MessageBox.Show("Erro: " + error.Message);
            }


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
    }
}

