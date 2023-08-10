using System.Security.Cryptography.X509Certificates;

namespace Course.Entities
{
    class Employee
    {
        public string Name {get; set; }
        public int Hora { get; set; }

        public double ValorPorHoas { get; set; }

        public Employee(string name, int hora, double valorporhoras)
        {
            Name = name;
            Hora = hora;
            ValorPorHoas = valorporhoras;

        }

        public virtual double Payment()
        {
            return Hora * ValorPorHoas;
        }

    }
}
