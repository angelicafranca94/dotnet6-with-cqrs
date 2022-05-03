using CQRS_read_Infrastructure.Persistence.People;

namespace CQRS_read_Application.People;

public interface IPersonService : IApplicationService<Person>
{
    Person Find(int id);
    IQueryable<Person> GetAll();
    IQueryable<Person> GetByName(string name);
    void Insert(Person person);
    void Update(Person person);
    void Delete(int id);
}
