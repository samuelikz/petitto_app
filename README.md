# petitto_app
C# Aplicação Petitto

#Bibliotecas 

- using Newtonsoft.Json;
- using System.Collections.Generic;
- using System.IO;
- using System.Net;
- using System.Text;

#Requisições 

- GET
- PUT
- DELETE
- UPDATE

https://user-images.githubusercontent.com/62406705/119066206-a72e9880-b9b5-11eb-9ce9-a1f42a9acdd0.mp4(url)

### Bugs

- Versão 1.0 Não foram encontrados bugs

### Conexão a Api-Json
```
class ListarPets
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthDate { get; set; }
        public string nin { get; set; }
        public static List<ListarPets> BuscarPets()
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string json = webClient.DownloadString("https://json-serverikz.herokuapp.com/users"); // Endereço da [API]

            var users = JsonConvert.DeserializeObject<List<ListarUsers>>(json); // Transformar em Objeto
            return users;
        }
    }
```
