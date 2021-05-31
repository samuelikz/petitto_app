using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace petitto_app
{
    class ListarPets
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

        public static System.Windows.Forms.FormCollection OpenForms { get; }
        public static List<ListarPets> BuscarPets()
        {
            try
            {
                string url = "https://json-serverikz.herokuapp.com/pets";
                string json = (new System.Net.WebClient()).DownloadString(url);
                var pets = JsonConvert.DeserializeObject<List<ListarPets>>(json);
                return pets;
            }
            catch (Exception ex)
            {
                string message = "Não foi Possivel Carregar os Dados \n" + "Erro: "+ ex.Message;
                string title = "Algo Deu Errado";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                return null;
            }
        }
    }
}
