public class Program
{
    static void Main(string[] args)
    {
        var empresa = new Empresa();

        var opcao = "";
        do
        {
            Console.WriteLine("Digite uma opção. Digite 'sair' para sair");
            Console.WriteLine("1 - Adicionar um funcionário tempo integral");
            Console.WriteLine("2 - Adicionar funcionário meio periodo");
            Console.WriteLine("3 - remover funcionario");
            Console.WriteLine("4 - exibir informacoes");
            Console.WriteLine("5 - adicionar projeto ao funcionario");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("digite o nome do funcionario");
                var nome = Console.ReadLine();
                
                Console.WriteLine("digite a matribula");
                var matricula = int.Parse(Console.ReadLine());
                
                Console.WriteLine("digite o salario");
                var salario = double.Parse(Console.ReadLine());

                var funcionario = new FuncionarioTempoIntegral(nome, matricula, salario);
                empresa.AdicionarFuncionario(funcionario);

                Console.WriteLine("funcionario adicionado");
            }
            else if (opcao == "2")
            {
                Console.WriteLine("digite o nome do funcionario");
                var nome = Console.ReadLine();
                
                Console.WriteLine("digite a matribula");
                var matricula = int.Parse(Console.ReadLine());
                
                Console.WriteLine("digite o salario por hora");
                var salarioPorHora = double.Parse(Console.ReadLine());
                
                Console.WriteLine("digite o número de horas trabalhadas");
                var numeroHorasTrabalhadas = double.Parse(Console.ReadLine());
                
                var funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, numeroHorasTrabalhadas);
                empresa.AdicionarFuncionario(funcionario);
                
                Console.WriteLine("funcionario adicionado");
            }
            else if (opcao == "3")
            {
                Console.WriteLine("digite a matribula");
                var matricula = int.Parse(Console.ReadLine());
                
                empresa.RemoverFuncionario(matricula);//nao vai funcionar
                
                Console.WriteLine("funcionario removido");
            }
            else if (opcao == "4")
            {
                empresa.ExibirInformacoes();
            }
            else if (opcao == "5")
            {
                Console.WriteLine("digite a matribula");
                var matricula = int.Parse(Console.ReadLine());
                
                Console.WriteLine("digite o nome do projeto");
                var projeto = Console.ReadLine();

                foreach (var funcionario in empresa.Funcionarios)
                {
                    if (funcionario.Matricula == matricula)
                    {
                        funcionario.AdicionarProjeto(projeto);
                        
                        Console.WriteLine("projeto adicionado no funcionario");
                    }
                }
            }
        
            Console.WriteLine("");
            Console.WriteLine("");
            
        } while (opcao != "sair");

        Console.WriteLine("obrigado por usar o programa");
    }
}