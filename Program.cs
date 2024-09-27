
System.Console.WriteLine("SEJA BEM VINDO AO CLASSIFICADOR DE NÍVEL DE HERÓI...");

char op = '0';

do
{
  System.Console.WriteLine("por favor entre com os seus dados");
  System.Console.Write("Nome: ");
  string nome = Console.ReadLine();

  System.Console.Write("Idade: ");
  int idade = int.Parse(Console.ReadLine());

  System.Console.Write("Casas de Hogwarts (Grifinória/Lufa-Lufa/Corvinal/Sonserina): ");
  string casasHogwarts = Console.ReadLine();

  System.Console.Write("Digite a quantidade de experiência (XP): ");
  double quantidadeXp = double.Parse(Console.ReadLine());

  if (quantidadeXp < 1000) 
  {
    System.Console.WriteLine("Ferro");
  }
  else if (quantidadeXp >= 1001 && quantidadeXp <= 2000)
  {
    System.Console.WriteLine("Bronze");
  }
  else if (quantidadeXp >= 2001 && quantidadeXp <= 5000)
  {
    System.Console.WriteLine("Prata");
  }
  else if (quantidadeXp >= 5001 && quantidadeXp <= 7000)
  {
    System.Console.WriteLine("Ouro");
  }
  else if (quantidadeXp >= 7001 && quantidadeXp <= 8000)
  {
    System.Console.WriteLine("Platina");
  }
  else if (quantidadeXp >= 8001 && quantidadeXp <= 9000)
  {
    System.Console.WriteLine("Ascendente");
  }
  else if (quantidadeXp >= 9001 && quantidadeXp <= 10000)
  {
    System.Console.WriteLine("Imortal");
  }
  else if (quantidadeXp >= 10001)
  {
    System.Console.WriteLine("Radiante");
  }

  System.Console.Write("Deseja seguir com os dados de mais um aluno? (S/N) ");
  char opcao = char.Parse(Console.ReadLine());

  do
    {
        if (opcao == 'S' || opcao == 's')
        {
            op = '0';
        }
        else if (opcao == 'N' || opcao == 'n')
        {
            op = '1';
        }
        else
        {
            System.Console.WriteLine("Opção inválida, digite novamente...");
            opcao = char.Parse(Console.ReadLine());
        }
    } while(opcao != 'S' && opcao != 'N' && opcao != 's' && opcao != 'n');

} while(op == '0');
