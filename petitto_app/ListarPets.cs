using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petitto_app
{
    class ListarPets
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public string nin { get; set; }
        public static List<ListarPets> BuscarPets()
        {
            string url = "http://aurora-project.azurewebsites.net/api/users";
            string json = (new System.Net.WebClient()).DownloadString(url);

            var pets = JsonConvert.DeserializeObject<List<ListarPets>>(json);
            return pets;
        }
    }
}
