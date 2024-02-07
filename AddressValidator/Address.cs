using System.ComponentModel.DataAnnotations;

namespace AddressValidator;

public class Address
{
    public Address(string line1, string line2, string line3, string postCode, string country)
    {
        Line1 = line1;
        Line2 = line2;
        Line3 = line3;
        PostCode = postCode;
        Country = country;
    }
    
    [Required]
    public string Line1 { get; set; }

    public string? Line2 { get; set; }

    public string? Line3 { get; set; }

    [Required]
    public string PostCode { get; set; }

    [Required]
    public string Country { get; set; }
}
