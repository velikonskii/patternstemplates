using RepoVariation.Entities;
using RepoVariation.Repositories;

namespace RepoVariation;

abstract class Program 
{         
    static void Main(string[] args)
    {
        
        var employeesRepository = new ListRepository<Employee>();
        
        AddEmployees(employeesRepository);
        ReadAndPrintRepository(employeesRepository);
        ReadAndPrintRepositoryPerson(employeesRepository);
        AddRemoteEmployees(employeesRepository);
        
        // IEnumerable<Person> people = new List<Employee>
        // {
        //     new Employee("Andrew"),
        //     new RemoteEmployee("Karen", "USA")
        // };

        static void AddEmployees(IRepository<Employee> repository)
        {
            new List<Employee>
            {
                new Employee("Andrew"),
                new RemoteEmployee("Karen", "USA")
            }.ForEach(repository.Insert);
        }
        
        static void ReadAndPrintRepository(IRepository<Employee> repository)
        {
            repository
                .GetAll()
                .ToList()
                .ForEach(Console.WriteLine);
        }
        
        static void ReadAndPrintRepositoryPerson(IReadOnlyRepository<Person> repository)
        {
            repository
                .GetAll()
                .ToList()
                .ForEach(Console.WriteLine);
        }

        static void AddRemoteEmployees(IWriteOnlyRepository<RemoteEmployee> repository)
        {
            repository.Insert(new RemoteEmployee("Andrew","Canada"));
            repository.Insert(new RemoteEmployee("Carol","UK")); 
        }

    }
}