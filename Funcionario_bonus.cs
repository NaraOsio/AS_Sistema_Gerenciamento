public class funcionario : Funcionario, IBonus
{
    private double SalarioMensal;

    public funcionario(string nome, int matricula, double salarioMensal)
        : base(nome, matricula)
    {
        SalarioMensal = salarioMensal;
    }

    public override double CalcularSalario()
    {
        return SalarioMensal;
    }

    public double CalcularBonus()
    {
        SalarioMensal * 30;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário Mensal: {SalarioMensal}, Bônus: {CalcularBonus()}");
    }
}
