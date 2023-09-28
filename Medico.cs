namespace ProvaPO2_3Bim
{
    internal class Medico : Funcionario
    {
        public string CRM { get; set; }
        public double valorHoraExtra { get; set; }
        public string especialidade { get; set; }

        public Medico(string nome, string cpf, int matricula, DateTime dataNasc, string sexo, double salario, string cRM, double valorHoraExtra, string especialidade):base
            (nome, cpf, matricula, dataNasc, sexo, salario)
        {
            CRM = cRM;
            this.valorHoraExtra = valorHoraExtra;
            this.especialidade = especialidade;
        }
    }
}
