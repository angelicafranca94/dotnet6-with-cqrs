using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace CQRS_read_Infrastructure.Persistence.People;

[Flags]
public enum PersonType
{
    User,
    Admin
}
public class Person
{
    public int Id { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public PersonType Type { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public Person(int id, PersonType type, string name, int age)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException("name");

        Id = id;
        Type = type;
        Name = name;
        Age = age;
    }

    public Person(PersonType type, string name, int age)
    {

        Id = -1;
        Type = type;
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{this}:[Class]{this}, [Name]{Name}, [Age]{Age}";
    }

}
