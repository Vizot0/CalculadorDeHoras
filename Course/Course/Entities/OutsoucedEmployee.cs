namespace Course.Entities
{
    class OutsourcedEmployee : Employee
    {
        public OutsourcedEmployee(string name, int hora, double valoporhoras, double adicional) : base(name, hora, valoporhoras)
        {
            Adicional = adicional;
        }

        public double Adicional { get; set; }

        public override double Payment()
        {
            return base.Payment() + 1.1 * Adicional;
        }
    }
}
