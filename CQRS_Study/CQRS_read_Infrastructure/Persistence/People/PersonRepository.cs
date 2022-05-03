using System.Linq.Expressions;

namespace CQRS_read_Infrastructure.Persistence.People;

public class PersonRepository : IPersonRepository
{
    private static List<Person> listPesonInMemomy = new List<Person>();

    public void Delete(Person entity)
    {
        listPesonInMemomy.Remove(entity);
    }

    public void Delete(object id)
    {
        listPesonInMemomy.Remove(Find(id));
    }

    public Person Find(object id)
    {
        return listPesonInMemomy.AsQueryable().FirstOrDefault(p => p.Id.Equals(id));
    }

    public IQueryable<Person> Get(Expression<Func<Person, bool>> predicate = null)
    {
        return predicate!=null?
            listPesonInMemomy.AsQueryable().Where(predicate)
            : listPesonInMemomy.AsQueryable();

    }

    public void Insert(Person entity)
    {
        if(entity.Id == -1)
        {
            entity = new Person(listPesonInMemomy.Count + 1,
                entity.Type, entity.Name, entity.Age);

            listPesonInMemomy.Add(entity);
        }
    }

    public void Update(Person entity)
    {
        var person = Find(entity.Id);
        person.Type = entity.Type;
        person.Name = entity.Name;
        person.Age = entity.Age;
    }
}
