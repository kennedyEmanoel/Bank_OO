public abstract class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }
    public double Comissao { get; set; }

    private protected double _bonificacao;

    public virtual double Bonificacao
    {
         get
         {
            return _bonificacao;
         }
         set
         {
            _bonificacao += Salario * 0.01;
         }
    }
}