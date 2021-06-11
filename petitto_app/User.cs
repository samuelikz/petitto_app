using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petitto_app
{
    
        class User
        {
            public String nome { get; set; }
            public String telefone { get; set; }
            public String email { get; set; }


            public User(string nome, string telefone, string email)
            {
                this.nome = nome;
                this.telefone = telefone;
                this.email = email;
            }

        }
    }
