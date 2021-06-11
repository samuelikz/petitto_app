using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace petitto_app
{
    class app_controller
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

        public static List<app_controller> BuscarPets()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;

                string json = webClient.DownloadString("https://json-serverikz.herokuapp.com/pets"); // Endereço da [API]

                var pets = JsonConvert.DeserializeObject<List<app_controller>>(json); // Transformar em Objeto

                return pets;
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

        public static List<app_controller> BuscarUsers()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string json = webClient.DownloadString("https://json-serverikz.herokuapp.com/users"); // Endereço da [API]

                var users = JsonConvert.DeserializeObject<List<app_controller>>(json); // Transformar em Objeto
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

        public static void excluirUsuarioPorId(string id)
        {
            try
            {
                var rota = "https://json-serverikz.herokuapp.com/users/" + id; // Endereço da [API]
                var requisicaoWeb = WebRequest.CreateHttp(rota);
                requisicaoWeb.Method = "DELETE";
                var response = (HttpWebResponse)requisicaoWeb.GetResponse();
                response.Close();

                MessageBox.Show("Exclusão Efetuada " + id);

            }
            catch (Exception ex)
            {
                string message = "Não foi possivel excluir os dados \n" + "Erro: " + ex.Message;
                string title = "Algo deu errado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
        }

        public static void excluirPetsPorId(string id)
        {
            try
            {
                var rota = "https://json-serverikz.herokuapp.com/pets/" + id; // Endereço da [API]
                var requisicaoWeb = WebRequest.CreateHttp(rota);
                requisicaoWeb.Method = "DELETE";
                var response = (HttpWebResponse)requisicaoWeb.GetResponse();
                response.Close();

                MessageBox.Show("Exclusão Efetuada " + id);

            }
            catch (Exception ex)
            {
                string message = "Não foi possivel excluir os dados \n" + "Erro: " + ex.Message;
                string title = "Algo deu errado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
        }


        //-------------------------------------------/Função post ???/---------------------------------------------------//

        //public static List<app_controller> Cadastro()
        //{
        //    WebRequest newUser = WebRequest.Create("https://json-serverikz.herokuapp.com/users");
        //    WebRequest newPet = WebRequest.Create("https://json-serverikz.herokuapp.com/pets");
        //    newUser.Method = "post";
        //    newPet.Method = "post";
        //    newUser.ContentType = "application/json, charset=UTF-8";
        //    newPet.ContentType = "application/json, charset=UTF-8";

        //    string NewUser = {  };

        //    return null;
        //}
    }
}