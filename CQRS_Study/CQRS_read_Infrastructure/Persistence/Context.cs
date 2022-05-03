using CQRS_read_Infrastructure.Persistence.People;

namespace CQRS_read_Infrastructure.Persistence;

public class Context : IContext
{
 
    public IPersonRepository People { get; set; }

    public Context(IPersonRepository personRepository)
    {
        People = personRepository;
    }
}
