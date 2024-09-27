
System.Console.WriteLine("SEJA BEM VINDO AO CLASSIFICADOR DE NÍVEL DE HERÓI...");

char op = '0';

do
{
  System.Console.WriteLine("por favor entre com os seus dados");
  System.Console.Write("Nome: ");
  string nome = Console.ReadLine();
  string nivel = "";

  System.Console.Write("Idade: ");
  int idade = int.Parse(Console.ReadLine());

  System.Console.Write("Casas de Hogwarts (Grifinória/Lufa-Lufa/Corvinal/Sonserina): ");
  string casasHogwarts = Console.ReadLine();

  System.Console.Write("Digite a quantidade de experiência (XP): ");
  double quantidadeXp = double.Parse(Console.ReadLine());

  if (quantidadeXp < 1000) 
  {
    nivel = "Ferro";
  }
  else if (quantidadeXp >= 1001 && quantidadeXp <= 2000)
  {
    nivel = "Bronze";
  }
  else if (quantidadeXp >= 2001 && quantidadeXp <= 5000)
  {
    nivel = "Prata";
  }
  else if (quantidadeXp >= 5001 && quantidadeXp <= 7000)
  {
    nivel = "Ouro";
  }
  else if (quantidadeXp >= 7001 && quantidadeXp <= 8000)
  {
    nivel = "Platina";
  }
  else if (quantidadeXp >= 8001 && quantidadeXp <= 9000)
  {
    nivel = "Ascendente";
  }
  else if (quantidadeXp >= 9001 && quantidadeXp <= 10000)
  {
    nivel = "Imortal";
  }
  else if (quantidadeXp >= 10001)
  {
    nivel = "Radiante";
  }

  System.Console.WriteLine($"O Herói de nome {nome}, da casa de {casasHogwarts} está no nível de {nivel}");

  System.Console.WriteLine("===============================================");
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
