
using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {
    ArrayList CadMédicos = new ArrayList();
            ArrayList CadEngenheiros = new ArrayList();

            for (int i = 1; i <= 2; i++)
            {
                Médico M = new Médico();
                M.Lê();

                CadMédicos.Add(M);
            }

            for (int i = 1; i <= 2; i++)
            {
                Engenheiro E = new Engenheiro();
                E.Lê();

                CadEngenheiros.Add(E);
            }

            Console.Clear();

            foreach(Médico x in CadMédicos)
            {
                x.Mostra();
            }

            Console.ReadKey();

            Console.Clear();

            foreach (Engenheiro x in CadEngenheiros)
            {
                x.Mostra();
            }

            Console.ReadKey();
  }
}