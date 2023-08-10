using Course.Entities;
using System.Globalization;
using System;



namespace Course
{
    class Program
    {
        static void Main(string[] args) { 
            List<Employee> list = new List<Employee>();

            Console.Write("Entre com o numero de funcionarios:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Funcionário #{i}:");
                Console.Write("É terceirizado (s/n ?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome:");
                string name = Console.ReadLine();
                Console.Write("Horas:");
                int hora = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora trabalhada:");
                double valoporhoras = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 's')
                {
                    Console.Write("Adicional:");
                    double adicional = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hora, valoporhoras, adicional));
                }
                else
                {
                    list.Add(new Employee(name, hora, valoporhoras));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamento:");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + "- $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}