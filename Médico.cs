
using System;

class Médico:Profissional
    {
        private string CRM;
        private string Especialidade;

        public Médico()
        {
            this.CRM = "";
            this.Especialidade = "";
        }

        public void Lê()
        {
            base.LêProfissional();

            Console.Write("Número do CRM...: ");
            this.CRM = Console.ReadLine();

            Console.Write("Especialidade...: ");
            this.Especialidade = Console.ReadLine();                
        }

        public void Mostra()
        {
            base.MostraProfissional();

            Console.WriteLine("CRM: {0}", this.CRM);
            Console.WriteLine($"Especialidade: {this.Especialidade}\n");
        }
    }