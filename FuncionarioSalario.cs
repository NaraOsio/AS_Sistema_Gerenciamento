public class funcionario : funcionario, IBonus
{
    private double SalarioPorHora;
    private int HorasTrabalhadas;

    public funcionario(string nome, int matricula, double salarioPorHora, int horasTrabalhadas)
        : base(nome, matricula)
    {
        SalarioPorHora = salarioPorHora;
        HorasTrabalhadas = horasTrabalhadas;
    }

    public override double CalcularSalario()
    {
        return SalarioPorHora * HorasTrabalhadas;
    }

    public double CalcularBonus()
    {
        Salario() * 0.8;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário: {CalcularSalario()}, Bônus: {CalcularBonus()}");
    }

}
