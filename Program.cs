//Adicionando as bibliotecas
using System;
using System.Collections.Generic;

//Fazendo a class main para poder testar o codigo 
class Program
{
    static void Main()
    {
        //Criando o petshop, o cachorro e o gato
        Petshop petshop = new Petshop();
        Cachorro c = new Cachorro(35, "Ronaldo", "Husk");
        Gato g = new Gato(5, "Batata", "preto");

        //Usando a função AdicionarAnimal para adicionar o gato e o cachorro a lista
        petshop.AdicionarAnimal(c);
        petshop.AdicionarAnimal(g);

        //Usando a função ListarAnimais para exibir todos os animais que estão na lista no console
        petshop.ListarAnimais();

    }
}

// Criando a class Animal 
class Animal
{

    // Definindo que todo animal tem uma idade e um nome
    public int Idade;
    public string Nome;

    public Animal(int i, string n)
    {

        Idade = i;
        Nome = n;

    }

    //Função para emitir o som o animal
    public virtual void EmitirSom()
    {
        ;
    }

    // Função para exibir as informações dos animais 
    public virtual void ExibirInfo()
    {

        Console.WriteLine($" O seu nome é {Nome} e a sua idade é {Idade}");

    }


}

//Criando a class Cachorro (Ela herda as informações da class Animal)
class Cachorro : Animal
{

    //Definindo que todo cachorro possui uma raça
    public string Raca;

    public Cachorro(int i, string n, string r) : base(i, n)
    {
        Raca = r;
    }

    //Reescrevendo a função EmitirSom para que o novo som seja Au Au
    public override void EmitirSom()
    {
        Console.WriteLine("Au au");
    }

    //Reescrevendo a função ExibirInfo Para que agora ela também possa dizer qual a raça do cachorro
    public override void ExibirInfo()
    {

        Console.WriteLine($" O seu nome é {Nome}, a sua idade é {Idade} e a sua raça é {Raca}");

    }

}

//Criando a class Gato (Ela herda as informações da class Animal)
class Gato : Animal
{

    //Definindo que todo gato possui uma cor
    public string Cor;

    public Gato(int i, string n, string c) : base(i, n)
    {
        Cor = c;
    }

    //Reescrevendo a função EmitirSom para que o novo som seja Miau Miau
    public override void EmitirSom()
    {
        Console.WriteLine("Miau Miau");
    }

    //Reescrevendo a função ExibirInfo Para que agora ela também possa dizer qual a cor do gato
    public override void ExibirInfo()
    {
        Console.WriteLine($" O seu nome é {Nome}, a sua idade é {Idade} e a sua cor é {Cor}");
    }
}

//Criando a class Petshop 
class Petshop
{
    //Criando uma lista para poder guardar as informações dos animais
    public List<Animal> Lista_de_Animais = new List<Animal>();

    //Função para adicionar um animal a lista
    public void AdicionarAnimal(Animal a)
    {
        Lista_de_Animais.Add(a);
    }

    //Função para exibir os animais que estão na lista
    public void ListarAnimais()
    {
        //Usando um Foreach para percorrer toda a minha lista e exibir as informações
        foreach (Animal p in Lista_de_Animais)
        {
            p.EmitirSom();
            p.ExibirInfo();

        }
    }

}