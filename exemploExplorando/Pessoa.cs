using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace exemploExplorando
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome; 
        }


        private string _nome;
        private int _idade;
        public string Nome
        {
            //Apresentará o nome inserido na váriavel "Nome" porém com as letras maiusculas _nome.ToUpper();
            get => _nome.ToUpper();

            set
            {
                //condicional para que caso o nome inserido na váriavel seja Nulo, seja apresnetado a exceção para sr tratado, apresentado o alerta mencionado abaixo
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                 }
                //Porém caso não seja nulo, o que determinará qual valor será apresentado é o "_nome" após essa tratativa, onde retornará o "Value" que é exatamente o que foi inserido na váriavel!
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade 
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
