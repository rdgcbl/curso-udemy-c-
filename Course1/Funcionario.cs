using System.Globalization;
namespace Course1 {
    class Funcionario {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage) {
            Salary = Salary + (Salary * percentage / 100);
        }

        public override string ToString() {
            return Id 
                + ", " 
                + Name 
                + ", " 
                + Salary.ToString("f2", CultureInfo.InvariantCulture);
        }

    }
}
