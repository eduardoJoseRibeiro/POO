using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caAluno
{
    class Materia
    {
        private String nome;
        private String codigo;

        public Materia()
        {
            // Construtor Default
        }
        public Materia(String nome, String codigo)
        {
            this.nome = nome;
            this.codigo = codigo;
        }
        // Getters
        public String getNome()
        {
            return this.nome;
        }
        public String getCodigo()
        {
            return this.codigo;
        }
        // Setters
        public String setNome(String nome)
        {
            this.nome = nome;
            return this.nome;
        }
        public String setCodigo(String codigo)
        {
            this.codigo = codigo;
            return this.codigo;
        }
    }
}
