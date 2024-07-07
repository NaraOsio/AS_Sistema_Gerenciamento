public class FuncionarioMeioPeriodo : Funcionario, IBonus //declaracao da classe herdando de funcionario e implementando a interface
{
    private double SalarioPorHora;
    private double NumeroHorasTrabalhadas;
    
    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, double numeroHorasTrabalhadas) : base(nome, matricula)//construtor base recebendo salario por hora e numero de horas trabalhada
    {
        SalarioPorHora = salarioPorHora;
        NumeroHorasTrabalhadas = numeroHorasTrabalhadas;
    }

    public override double CalcularSalario()//calculo do salario
    {
        return SalarioPorHora * NumeroHorasTrabalhadas;
    }

    public override void ExibirInformacoes()//mostra informações
    {
        Console.WriteLine($"nome: {Nome}");
        Console.WriteLine($"matribula: {Matricula}");
        Console.WriteLine($"salario por hora: {SalarioPorHora}");
        Console.WriteLine($"numero de horas trabalhadas: {NumeroHorasTrabalhadas}");
    }

    public double CalcularBonus()
    {
        return CalcularSalario() * 5 / 100;
    }
}