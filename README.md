# petitto_app
C# Aplicação Petitto
[



https://user-images.githubusercontent.com/62406705/119066206-a72e9880-b9b5-11eb-9ce9-a1f42a9acdd0.mp4


](url)

# Conexão a Api-Json
```
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
```
