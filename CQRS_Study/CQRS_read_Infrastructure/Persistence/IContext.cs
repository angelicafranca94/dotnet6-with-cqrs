using CQRS_read_Infrastructure.Persistence.People;

namespace CQRS_read_Infrastructure.Persistence;

public interface IContext
{
    IPersonRepository People { get; set; }
}
