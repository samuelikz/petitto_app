using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace petitto_app
{
    class ListPets
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string sexo { get; set; }
        public string cpf { get; set; }
        public string idade { get; set; }
        public string raca { get; set; }
        public string urlimage { get; set; }
        public string categoria { get; set; }
        public string descrincao { get; set; }

        public ListPets(string nome, string sexo, string cpf, string idade, string raca, string urlimage, string categoria, string descrincao)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.cpf = cpf;
            this.idade = idade;
            this.raca = raca;
            this.urlimage = urlimage;
            this.categoria = categoria;
            this.descrincao = descrincao;
        }

        public static FormCollection OpenForms { get; }
        public static List<ListPets> BuscarPets()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string json = webClient.DownloadString("https://json-serverikz.herokuapp.com/pets"); // Endereço da [API]

                var pets = JsonConvert.DeserializeObject<List<ListPets>>(json); // Transformar em Objeto

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
    }
}