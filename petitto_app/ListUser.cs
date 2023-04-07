using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;


namespace petitto_app
{
    class ListUser
    {
        public int id { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public ListUser(string nome, string email, string cpf, string telefone)
        {
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.telefone = telefone;
        }
        public static List<ListUser> BuscarUsers()
        {
            try
            {
                var url = "https://json-server.samuelikz.repl.co/pets";

                var request = WebRequest.Create(url);
                request.Method = "GET";

                var webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();

                var reader = new StreamReader(webStream);
                var data = reader.ReadToEnd();

                var users = JsonConvert.DeserializeObject<List<ListUser>>(data);

                reader.Close();

                return users;
            }
            catch (Exception ex)
            {
                string message = "Não foi Possivel Carregar os Dados \n" + "Erro: " + ex.Message;
                string title = "Algo Deu Errado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                return null;
            }
        }
    }
}
