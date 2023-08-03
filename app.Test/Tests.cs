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
            DateOfBirth = new DateOnly(1950,1,1),
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
            DateOfBirth = new DateOnly(1950, 1, 1),
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

    [Fact]
    public async Task IntegrationTest()
    {
        var apiUrl = "https://archive-api.open-meteo.com/v1/archive?latitude=52.52&longitude=13.41&start_date=2023-07-15&end_date=2023-07-29&hourly=temperature_2m";

        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(apiUrl);
        var result = await response.Content.ReadAsStringAsync();

        var settings = new VerifySettings();
        settings.IgnoreMember("generationtime_ms");
        await VerifyJson(result, settings);
    }

}

