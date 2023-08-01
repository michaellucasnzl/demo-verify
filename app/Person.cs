namespace app;

public class Person
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; }
    public Address? Address { get;set; }
}
