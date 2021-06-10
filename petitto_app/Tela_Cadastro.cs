using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace petitto_app
{
    public partial class Tela_Cadastro : Form
    {

        public Tela_Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NewDoacao()
        {

            NewDoacao newcad = new NewDoacao(textNome.Text, textEmail.Text, textCpf.Text, textTelefone.Text, textNome_pet.Text, comboSexo.Text, comboIdade.Text, comboIdade.Text, textUrl.Text, comboCategoria.Text, textDescrincao.Text);

            String newjson = JsonConvert.SerializeObject(newcad);
            string Petrota = "https://json-serverikz.herokuapp.com/doacao"; //string rota

            var request = WebRequest.CreateHttp(Petrota);
            request.Method = "POST";

            request.ContentType = "application/json; charset=utf-8";

            var byteArray = Encoding.UTF8.GetBytes(newjson);

            request.ContentLength = byteArray.Length;

            Stream stream = request.GetRequestStream();

            stream.Write(byteArray, 0, byteArray.Length);


            string messagesus = "Dados Foram Cadastrados \n" + "Sucesso";
            string titles = "Dados Cadastrados";
            MessageBoxButtons buttons2 = MessageBoxButtons.OK;
            DialogResult results = MessageBox.Show(messagesus, titles, buttons2, MessageBoxIcon.Information);

            stream.Close();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                NewDoacao();
            }

            catch (WebException error)
            {
                string message = "Não foi Possivel Salvar os Dados \n" + "Erro: " + error.Message;
                string title = "Algo Deu Errado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNomepet_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboIdade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textRaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDescrincao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
