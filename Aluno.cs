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
        Materia[] lista_materias = new Materia[8];
        private int posicao = 0;

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
        public void setListaMateria(Materia mat)
        {
            this.lista_materias[this.posicao] = mat;
            posicao++;
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
        public Materia getListaMaterias(int pos)
        {
            return this.lista_materias[pos];
        }
        // Metodos
        public void imprimirDados()
        {
            Console.WriteLine("Nome: " + this.getNome());
            Console.WriteLine("Numero de Matricula: " + this.getNumeroMatricula());
            Console.WriteLine("Periodo: " + this.getPeriodo()+"\n");

            for(int i = 0; i < posicao; i++)
            {
                Console.WriteLine("Materia: " + this.getListaMaterias(i).getNome());
                Console.WriteLine("Codigo: " + this.getListaMaterias(i).getCodigo() + "\n");
            }
        }

    }
}
