public class Empresa
{
    public List<Funcionario> Funcionarios;

    public Empresa()
    {
        Funcionarios = new List<Funcionario>();
    }
    
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public void RemoverFuncionario(int matricula)
    {
        //como faz pra remover pela matricula?
    }

    public void ExibirInformacoes()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    }
}
