using CQRS_read_Infrastructure.Persistence.People;

namespace CQRS_read_Application.People;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _personRepository;

    public PersonService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public void Delete(int id)
    {
        _personRepository.Delete(id);
    }

    public Person Find(int id)
    {
        return _personRepository.Find(id);
    }

    public IQueryable<Person> GetAll()
    {
        return _personRepository.Get();
    }

    public IQueryable<Person> GetByName(string name)
    {
       return _personRepository.Get(p => p.Name.ToUpper().Contains(name.ToUpper()));
    }

    public void Insert(Person person)
    {
        _personRepository.Insert(person);
    }

    public void Update(Person person)
    {
        _personRepository.Update(person);
    }
}
