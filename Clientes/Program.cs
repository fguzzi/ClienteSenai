using System;
namespace Clientes;

    class Program
    {
        static void Main(string[] args)
        {
            // DECLARAÇÃO DAS VARIÁVEIS
            float valor_pago;
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j)");
            string var_tipo = Console.ReadLine();

            // PESSOA FÍSICA
            if (var_tipo == "f"){

                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar o CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informa o RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar o Valor de Compra:");
                valor_pago = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(valor_pago);
                Console.WriteLine("--------------PESSOA FÍSICA-------------");
                Console.WriteLine("NOME...........:" + pf.nome);
                Console.WriteLine("ENDEREÇO.......:" + pf.endereco);
                Console.WriteLine("CPF............:" + pf.cpf);
                Console.WriteLine("RG.............:" + pf.rg);
                Console.WriteLine("VALOR DA COMPRA:" + pf.valor.ToString("C"));
                Console.WriteLine("IMPOSTO........:" + pf.valor_imposto.ToString("C"));
                Console.WriteLine("VALOR A PAGAR..:" + pf.total.ToString("C"));
            }

            // PESSOA JURÍDICA
            if (var_tipo == "j"){

                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informe o CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informe a IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o Valor da Compra:");
                valor_pago = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(valor_pago);
                Console.WriteLine("--------------PESSOA JURIDICA-------------");
                Console.WriteLine("NOME...........:" + pj.nome);
                Console.WriteLine("ENDEREÇO.......:" + pj.endereco);
                Console.WriteLine("CNPJ...........:" + pj.cnpj);
                Console.WriteLine("IE.............:" + pj.ie);
                Console.WriteLine("VALOR DA COMPRA:" + pj.valor.ToString("C"));
                Console.WriteLine("IMPOSTO........:" + pj.valor_imposto.ToString("C"));
                Console.WriteLine("VALOR A PAGAR..:" + pj.total.ToString("C"));
            }
        }
    }