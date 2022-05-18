using EnumeracoesComposicao.Entities.Enums;
using System.Collections.Generic;

namespace EnumeracoesComposicao.Entities 
{ 
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //já instancia a lista para garantir que ela não seja nula.

        //construtores
        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department) //Porque não colocar os contracts nos argumentos? Via de regra quando tiver uma associação para muitos, você não vai incluir ela no construtor. Pela lógica, não é muito apropriado colocar uma lista já dentro de um contrutor. Ela vai sendo preenchida depois...
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //método para adicionar contratos:
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        //método para remover contratos:
        public void RemoveContract( HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary; //já inicia com o salário base (o mínimo que ele pode ganhar no mês)
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
        
        
        
        

    }
}
