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

        public static void excluirUsuarioPorId(string id)
        {
            try
            {
                var rota = "https://json-serverikz.herokuapp.com/doacao/" + id; // Endereço da [API]
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
    }
}