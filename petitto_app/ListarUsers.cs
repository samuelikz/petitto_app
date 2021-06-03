using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace petitto_app
{
    class ListarUsers
    {
        public int id { get; set; }
        public string cpf { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public static List<ListarUsers> BuscarUsers()
        {
            try
            {
                string url = "https://json-serverikz.herokuapp.com/users";
                string json = (new System.Net.WebClient()).DownloadString(url);

                var users = JsonConvert.DeserializeObject<List<ListarUsers>>(json);
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
