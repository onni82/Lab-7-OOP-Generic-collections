using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_OOP_Generic_collections
{
	public class Employee
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public Employee(int id, string name, string gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Gender} - {Salary}";
        }

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			Employee other = (Employee)obj;
			return Id == other.Id &&
				   Name == other.Name &&
				   Gender == other.Gender &&
				   Salary == other.Salary;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Name, Gender, Salary);
		}
	}
}
