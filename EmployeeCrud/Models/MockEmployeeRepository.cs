using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeCrud.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _emoloyeeList;

        public MockEmployeeRepository()
        {
            _emoloyeeList = new List<Employee>()
            {
                new Employee{ Id=1,Name="Zeeshan",Email="Zeeshan17733@gmail.com",Department="Software"},
                new Employee{ Id=2,Name="Awais",Email="Awais@gmail.com",Department="Kitchen"},
                new Employee{ Id=3,Name="Nouman",Email="nouman@gmail.com",Department="education"}
            };
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _emoloyeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _emoloyeeList.FirstOrDefault(emp => emp.Id == Id);
        }
    }
}
