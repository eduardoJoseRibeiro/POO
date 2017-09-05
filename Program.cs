using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Ze", "123", 5);
            a1.imprimirDados();
            Console.ReadLine();
        }
    }
}
