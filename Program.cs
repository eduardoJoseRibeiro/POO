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
            
            Materia m1 = new Materia("Calculo 1", "C1");
            Materia m2 = new Materia("Algebra", "AMGA");
            Materia m3 = new Materia("Introdução TC", "ITC");
            Materia m4 = new Materia("Programação Orientada a Objetos", "POO");

            a1.setListaMateria(m1);
            a1.setListaMateria(m2);
            a1.setListaMateria(m3);
            a1.setListaMateria(m4);

            a1.imprimirDados();

            Console.ReadLine();
        }
    }
}
