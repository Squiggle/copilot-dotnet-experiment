using System.ComponentModel.DataAnnotations;

namespace AddressValidator;

public class PostCodeValidationAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (value == null)
        {
            return new ValidationResult("Postcode is required");
        }

        string postcode = value as string;

        if (string.IsNullOrWhiteSpace(postcode))
        {
            return new ValidationResult("Postcode cannot be empty or whitespace");
        }

        if (postcode.Length != 5)
        {
            return new ValidationResult("Postcode must be 5 characters long");
        }
        
        return ValidationResult.Success;
    }
}