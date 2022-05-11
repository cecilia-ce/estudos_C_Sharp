using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioListas
{
    class Empregado
    {
        public string Nome { get; private set; }
        public int Id { get; private set; }
        public double Salario { get; private set; }

        public Empregado (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double valor)
        {
            Salario = Salario + (Salario * (valor / 100));  
        } 

        public override string ToString()
        {
            return Id + ", " + Nome + ", " + Salario;
        }

    }
}
