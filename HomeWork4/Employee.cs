using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Employee(double sallary)
    {
        private double _sallary = sallary;

        public double Sallary { get => _sallary; set => _sallary = value; }

        public static Employee operator +(double count, Employee employee) => new(employee.Sallary + count);

        //public static Employee operator +(Employee employee_1, Employee employee_2) => new(employee_1.Sallary + employee_2.Sallary);

        public static Employee operator -(double count, Employee employee) => new(employee.Sallary - count);

        //public static Employee operator -(Employee employee_1, Employee employee_2) => new(employee_1.Sallary - employee_2.Sallary);

        public static bool operator ==(Employee employee_1, Employee employee_2) => (employee_1.Sallary == employee_2.Sallary);
        public static bool operator !=(Employee employee_1, Employee employee_2) => !(employee_1.Sallary != employee_2.Sallary);
        public static bool operator >(Employee employee_1, Employee employee_2) => (employee_1.Sallary > employee_2.Sallary);
        public static bool operator <(Employee employee_1, Employee employee_2) => (employee_1.Sallary < employee_2.Sallary);

        public static bool operator ==(Employee employee_1, int count) => (employee_1.Sallary == count);
        public static bool operator !=(Employee employee_1, int count) => !(employee_1.Sallary != count);
        public static bool operator >(Employee employee_1, int count) => (employee_1.Sallary > count);
        public static bool operator <(Employee employee_1, int count) => (employee_1.Sallary < count);



    }
}
