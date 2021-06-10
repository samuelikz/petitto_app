using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petitto_app
{
    class NewDoacao
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string nome_pet { get; set; }
        public string sexo { get; set; }
        public string idade { get; set; }
        public string raca { get; set; }
        public string urlimage { get; set; }
        public string categoria { get; set; }
        public string descrincao { get; set; }

        public NewDoacao(string nome, string email, string cpf, string telefone, string nome_pet, string sexo, string idade, string raca, string urlimage, string categoria, string descrincao)
        {
            this.nome = nome;
            this.email = email;
            this.cpf = cpf;
            this.telefone = telefone;
            this.nome_pet = nome_pet;
            this.sexo = sexo;
            this.idade = idade;
            this.raca = raca;
            this.urlimage = urlimage;
            this.categoria = categoria;
            this.descrincao = descrincao;
        }
    }
}
