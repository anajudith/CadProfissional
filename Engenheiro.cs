
using System;

class Engenheiro:Profissional
    {
        private string CREA;
        private string ÁreaFormação;

        public Engenheiro()
        {
            this.CREA = "";
            this.ÁreaFormação = "";
        }

        public void Lê()
        {
            base.LêProfissional();

            Console.Write("Número do CREA..: ");
            this.CREA = Console.ReadLine();

            Console.Write("Formação........: ");
            this.ÁreaFormação = Console.ReadLine();
        }

        public void Mostra()
        {
            base.MostraProfissional();

            Console.WriteLine("CREA: {0}",this.CREA);
            Console.WriteLine("Área de Formação: {0}\n", this.ÁreaFormação);
        }
    }