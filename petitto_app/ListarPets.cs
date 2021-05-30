using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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

        public static List<ListarPets> BuscarPets()
        {
            string url = "https://json-serverikz.herokuapp.com/pets";
            string json = (new System.Net.WebClient()).DownloadString(url);

            var pets = JsonConvert.DeserializeObject<List<ListarPets>>(json);
            return pets;
        }
    }
}
