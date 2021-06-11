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
            if (String.IsNullOrEmpty(textNome.Text))
            {
                string message = "Campos devem ser preenchidos \n" + "Erro: Campos Obrigatorios";
                string title = "Algo Deu Errado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                textNome.Focus();
                return;
            }
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

        public void erro()
        {
            string message = "Campo Obrigatorio \n";
            string title = "Algo Deu Errado";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
        }

        private void NewDoacao()
        {
            try
            {
                if (String.IsNullOrEmpty(textNome.Text))
                {
                    erro();
                    textNome.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textEmail.Text))
                {
                    erro();
                    textEmail.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textCpf.Text))
                {
                    erro();
                    textCpf.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textTelefone.Text))
                {
                    erro();
                    textTelefone.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textNome_pet.Text))
                {
                    erro();
                    textNome_pet.Focus();
                    return;
                }
                if (comboSexo.SelectedIndex.Equals(-1))
                {
                    erro();
                    comboSexo.Focus();
                    return;
                }
                if (comboIdade.SelectedIndex.Equals(-1))
                {
                    erro();
                    comboIdade.Focus();
                    return;
                }
                if (comboCategoria.SelectedIndex.Equals(-1))
                {
                    erro();
                    comboCategoria.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textRaca.Text))
                {
                    erro();
                    textRaca.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textUrl.Text))
                {
                    erro();
                    textUrl.Focus();
                    return;
                }
                if (String.IsNullOrEmpty(textDescrincao.Text))
                {
                    erro();
                    textDescrincao.Focus();
                    return;
                }

                NewDoacao newcad = new NewDoacao(textNome.Text, textEmail.Text, textCpf.Text, textTelefone.Text, textNome_pet.Text, comboSexo.Text, comboIdade.Text, comboCategoria.Text, textRaca.Text, textUrl.Text, textDescrincao.Text);

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

            catch (WebException error)
            {
                string message = "Não foi Possivel Salvar os Dados \n" + "Erro: " + error.Message;
                string title = "Algo Deu Errado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            NewDoacao();
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
