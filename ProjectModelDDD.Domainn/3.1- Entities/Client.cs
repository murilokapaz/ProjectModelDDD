using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectModelDDD.Domainn._3._1__Entities
{
    class Client
    {
        public int ClientId { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public bool ClienteEspecial(Client cliente) {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        } 
    }
}
