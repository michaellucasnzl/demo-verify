using System.Drawing;
using FluentAssertions;

namespace app.Test;

[UsesVerify]
public class Tests
{
    [Fact]
    public void Person_AssertTest()
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

        person.Name.Should().Be("Joe Bloggs");
        person.Address.AddressLine1.Should().Be("1 Test Ave");
        person.Address.City.Should().Be("Test City");
        person.Address.Country.Should().Be("New Zealand");
        person.Address.PostCode.Should().Be("1234");
        person.Address.Suburb.Should().BeNull();
        person.Address.AddressLine2.Should().BeNull();        
    }

    [Fact]
    public async Task Person_VerifyTest()
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