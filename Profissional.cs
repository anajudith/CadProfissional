
using System;

class Profissional
    {
        private string Nome;
        private string CPF;
        private string DataAdmissão;
        private double Salário;

        public Profissional()
        {
            Nome = "";
            CPF = "";
            DataAdmissão = "";
            Salário = 0.0;
        }

        public void LêProfissional()
        {
            Console.Write("Nome............: ");
            this.Nome = Console.ReadLine();

            Console.Write("CPF.............: ");
            this.CPF = Console.ReadLine();

            Console.Write("Data de Admissão: ");
            this.DataAdmissão = Console.ReadLine();

            Console.Write("Salário (R$)....: ");
            this.Salário = double.Parse(Console.ReadLine());
        }

        public void MostraProfissional()
        {
            Console.WriteLine("{0} - CPF: {1}", this.Nome, this.CPF);
            Console.WriteLine("Admissão: {0}", this.DataAdmissão);
            Console.WriteLine("Salário: R$ {0:F2}", this.Salário);
        }
    }