namespace ProvaPO2_3Bim
{
    internal class Funcionario
    {
        public string nome { get; set; }
        public string cpf { get; set; }
        public int matricula { get; set; }
        public DateTime dataNasc { get; set; }
        public string sexo { get; set; }
        public double salario { get; set; }

        public Funcionario(string nome, string cpf, int matricula, DateTime dataNasc, string sexo, double salario)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.matricula = matricula;
            this.dataNasc = dataNasc;
            this.sexo = sexo;
            this.salario = salario;
        }
    }
}
