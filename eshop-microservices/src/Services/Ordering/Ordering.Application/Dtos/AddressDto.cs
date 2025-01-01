namespace Ordering.Application.Dtos;

public record AddressDto(
    string FirstName,
    string Lastname,
    string EmailAddress,
    string AddressLine,
    string Country,
    string State,
    string ZipCode);
