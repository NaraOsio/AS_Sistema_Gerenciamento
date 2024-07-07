public abstract class Funcionario
{
    public string Nome;
    public int Matricula;
    public List<string> Projetos;

    public Funcionario(string nome, int matricula) //Contrutor da classe
    {
        Nome = nome;
        Matricula = matricula;
       
    }
    public abstract double  CalcularSalario (); //Declação de um metodo abstrato
    public abstract void ExibirInformacoes();
    


}
