using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno
{
    class Aluno
    {
        private String nome;
        private String numero_matricula;
        private int periodo;

        //Construtor
        public Aluno()
        {
            // Construtor Default
        }
        public Aluno(String nome, String numero_matricula,int periodo)
        {
            this.nome = nome;
            this.periodo = periodo;
            this.numero_matricula = numero_matricula;
        }
        // Setters
        public String setNome(String nome)
        {
            this.nome = nome;
            return this.nome;
        }
        public String setNumeroMatricula(String numero_matricula)
        {
            this.numero_matricula = numero_matricula;
            return this.numero_matricula;
        }
        public int setPeriodo(int periodo)
        {
            this.periodo = periodo;
            return this.periodo;
        }
        // Getters
        public String getNome()
        {
            return this.nome;
        }
        public String getNumeroMatricula()
        {
            return this.numero_matricula;
        }
        public int getPeriodo()
        {
            return this.periodo;
        }
        // Metodos
        public void imprimirDados()
        {
            Console.WriteLine("Nome: " + this.getNome());
            Console.WriteLine("Numero de Matricula: " + this.getNumeroMatricula());
            Console.WriteLine("Periodo: " + this.getPeriodo());
        }

    }
}
