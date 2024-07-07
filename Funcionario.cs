public abstract class Funcionario
{
    public string Nome;
    public int Matricula;
    public List<string> Projetos;

    public Funcionario(string nome, int matricula) //Contrutor da classe
    {
        Nome = nome;
        Matricula = matricula;
        Projetos = new List<string>();
    }
    public abstract double  CalcularSalario (); //Declação de um metodo abstrato
    public abstract void ExibirInformacoes();

    public void AdicionarProjeto(string projeto)
    {
        Projetos.Add(projeto);//adiciona a string na lista de projetos
    }

    public void AdicionarProjeto(List<string> projetos)
    {
        Projetos.AddRange(projetos);//adiciona a lista de projetos nos projetos do funcionario
    }
}