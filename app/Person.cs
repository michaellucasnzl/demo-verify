namespace app;

public class Person
{
    public Guid Id { get; } = Guid.NewGuid();
    public DateOnly DateOfBirth { get; set; }
    public string Name { get; set; }
    public Address? Address { get;set; }
}
