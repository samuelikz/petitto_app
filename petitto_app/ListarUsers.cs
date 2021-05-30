using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

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
                string url = "https://json-serverikz.herokuapp.com/users";
                string json = (new System.Net.WebClient()).DownloadString(url);

                var users = JsonConvert.DeserializeObject<List<ListarUsers>>(json);
                return users;
        }
    }
}
