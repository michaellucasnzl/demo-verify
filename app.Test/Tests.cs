namespace app.Test;

[UsesVerify]
public class Tests
{
    [Fact]
    public async Task PersonTest()
    {
        var person = new Person()
        {
            Name = "Joe Bloggs",
            Address = new Address()
            {
                AddressLine1 = "1 Test Ave",
                City = "Test City",
                Country = "New Zealand",
                PostCode = "1234"
            }
        };

        await Verify(person);
    }
}