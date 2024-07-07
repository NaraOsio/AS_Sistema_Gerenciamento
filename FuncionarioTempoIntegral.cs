
public class FuncionarioTempoIntegral : Funcionario //Herdando da classe funcionario
{
    private double SalarioMensal;
    public FuncionarioTempoIntegral(string nome, int matricula , double salarioMensal) : base(nome, matricula)//Declarando construtor base
    {
        SalarioMensal = salarioMensal;
    }

    public override double CalcularSalario()//Implementando metodo calcular sálario
    {
        return SalarioMensal;
    }

    public override void ExibirInformacoes()//Implementando Exibir informações
    {
        Console.WriteLine($"nome {Nome} ");
        Console.WriteLine($"matricula {Matricula} " );
    }

}
