using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Veiculos
    {
        public int Id { get; set; } // Eram Atributos, mas viraram Propriedades, que resgatam os dados pelo encapsulamento.
        public string Nome { get; set; } 

        public override string ToString() // Override, como o nome diz, (sobrepor),ele substitui o estilo do método, o alterando, no caso é Veiculos.
        {
            return this.Nome;
        }
        public static List<Veiculos> Lista()
        {
            // var é um tipo de varivel que não muito bem especificada, é uma implementação
            var lista = new List<Veiculos>();   // objeto lista que sera guardada.
            var dados = new Veiculos(); // objeto informações;

            dados.Id = 1;
            dados.Nome = "Unão sarado";

            lista.Add(dados);

            dados = new Veiculos(); // Cria um novo objeto, no caso, um novo veiculo

            dados.Id = 2;
            dados.Nome = "Corvette";

            lista.Add(dados); // Adiciona na Lista

            dados = new Veiculos(); // Cria um novo objeto, no caso, um novo veiculo

            dados.Id = 3;
            dados.Nome = "Mareia";

            lista.Add(dados); // Adiciona na Lista

            dados = new Veiculos();

            dados.Id = 4;
            dados.Nome = "XJ6";

            lista.Add(dados);

            dados = new Veiculos();

            dados.Id = 5;
            dados.Nome = "XRE";

            lista.Add(dados);


            return lista; // Retorna a Lista
        }

    }
}
