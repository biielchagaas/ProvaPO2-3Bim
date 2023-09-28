using System;
using ProvaPO2_3Bim;
public class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();
        List<Medico> medicos = new List<Medico>();
        List<Administrativo> administrativos = new List<Administrativo>();

        int opcao = 0;

        try
        {
            while (true)
            {
                string nome;
                string cpf;
                int matricula;
                DateTime dataNasc;
                string sexo;
                double salario;
                double calc;

                Console.WriteLine("Olá, deseja adicionar que tipo de funcionario?");
                Console.WriteLine("1 - Normal");
                Console.WriteLine("2 - Medico");
                Console.WriteLine("3 - Administrativo");
                Console.WriteLine("4 - Sair");
                Console.Write("Digite o valor conforme o tipo de funcionário desejado: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do funcionário: ");
                        nome = Console.ReadLine();
                        Console.Write("Digite o CPF do funcionário: ");
                        cpf = Console.ReadLine();
                        Console.Write("Digite a matricula do funcionário: ");
                        matricula = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite data de nascimento do funcionário: ");
                        dataNasc = DateTime.Parse(Console.ReadLine());
                        Console.Write("Digite o sexo do funcionário: ");
                        sexo = Console.ReadLine();
                        Console.Write("Digite o salário do funcionário: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        Funcionario funcionario = new Funcionario(nome, cpf, matricula, dataNasc, sexo, salario);
                        
                        funcionarios.Add(funcionario);

                        opcfun:

                        Console.WriteLine("Deseja adicionar mais um funcionário?\n1 - Sim\n2 - Não");
                        Console.Write("Escolha a opção desejada: ");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao == 1)
                        {
                            Console.Clear();   
                        }
                        else if (opcao == 2)
                        {
                            Console.Clear();
                            goto exit;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Opcao Inválida!!!\n");
                            goto opcfun;
                        }
                        Console.Clear();
                        break;

                    case 2:
                        Console.Write("Digite o nome do médico: ");
                        nome = Console.ReadLine();
                        Console.Write("Digite o CPF do médico: ");
                        cpf = Console.ReadLine();
                        Console.Write("Digite a matricula do médico: ");
                        matricula = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a data de nascimento do médico: ");
                        dataNasc = DateTime.Parse(Console.ReadLine());
                        Console.Write("Digite o sexo do médico: ");
                        sexo = Console.ReadLine();
                        Console.Write("Digite o salário do médico: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite o CRM do médico: ");
                        string CRM = Console.ReadLine();
                        Console.Write("Digite o valor da hora extra do médico: ");
                        double valorHoraExtra = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a especialidade do médico: ");
                        string especialidade = Console.ReadLine();
                        Console.WriteLine();

                        calc = (salario * 0.22) + salario;

                        Medico medico = new Medico(nome, cpf, matricula, dataNasc, sexo, calc, CRM, valorHoraExtra, especialidade);

                        medicos.Add(medico);

                        opcmed:
                        Console.WriteLine("Deseja adicionar mais um funcionário?\n1 - Sim\n2 - Não");
                        Console.Write("Escolha a opção desejada: ");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao == 1)
                        {
                            Console.Clear();
                        }
                        else if (opcao == 2)
                        {
                            Console.Clear();
                            goto exit;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Opcao Inválida!!!\n");
                            goto opcmed;
                        }
                        Console.Clear();
                        break;

                    case 3:
                        Console.Write("Digite o nome do administrador: ");
                        nome = Console.ReadLine();
                        Console.Write("Digite o CPF do administrador: ");
                        cpf = Console.ReadLine();
                        Console.Write("Digite a matricula do administrador: ");
                        matricula = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite data de nascimento do administrador: ");
                        dataNasc = DateTime.Parse(Console.ReadLine());
                        Console.Write("Digite o sexo do administrador: ");
                        sexo = Console.ReadLine();
                        Console.Write("Digite o salário do administrador: ");
                        salario = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        calc = (salario * 0.17) + salario + 250;

                        Administrativo administrativo = new Administrativo(nome, cpf, matricula, dataNasc, sexo, salario);

                        administrativos.Add(administrativo);

                        opcadmin: 
                        Console.WriteLine("Deseja adicionar mais um funcionário?\n1 - Sim\n2 - Não");
                        Console.Write("Escolha a opção desejada: ");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao == 1)
                        {
                            Console.Clear();
                        }
                        else if (opcao == 2)
                        {
                            Console.Clear();
                            goto exit;
                        }
                        else 
                        {
                            Console.Clear();
                            Console.WriteLine("Opcao Inválida!!!\n");
                            Console.WriteLine();
                            goto opcadmin;
                        }
                        break;

                    case 4:
                        goto exit;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida!!");
                        Console.Clear();
                        break;
                }
            }
            exit: Console.WriteLine("Thank You!!\n");

            funcionarios = funcionarios.Where(x => x.salario >= 2000).ToList();
            medicos = medicos.Where(x => x.salario >= 2000).ToList();
            administrativos = administrativos.Where(x => x.salario >= 2000).ToList();

            foreach (Funcionario item in funcionarios)
            {
                Console.WriteLine($"O {item.nome}, do cpf {item.cpf}, da matrícula, que nasceu no dia {item.dataNasc}, do sexo {item.sexo}, recebe {item.salario.ToString("c2")}");
            }
            foreach (Medico item in medicos)
            {
                Console.WriteLine($"O {item.nome}, do cpf {item.cpf}, da matrícula, que nasceu no dia {item.dataNasc}, do sexo {item.sexo}, do CRM {item.CRM}, que recebe " +
                    $"{item.valorHoraExtra.ToString("c2")} por hora extra, de especialidade em {item.especialidade} recebe {item.salario.ToString("c2")}");
            }
            foreach (Administrativo item in administrativos)
            {
                Console.WriteLine($"O {item.nome}, do cpf {item.cpf}, da matrícula, que nasceu no dia {item.dataNasc}, do sexo {item.sexo}, recebe {item.salario.ToString("c2")}");
            }

            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}