# copilot-dotnet-experiment
Minimal project to validate the effectiveness of Copilot-supported unit testing

# Setup

Collect code coverage

```
dotnet watch --project AddressValidator.Tests/ test /p:CollectCoverage=true
```

# Stages

1. Demonstrate the POWER of Copilot for creating code

Ask Copilot Chat:

```
How do I create a class validation attribute that ensures that a postcode begins with two characters if the Country property is "UK"?
```

2. Demonstrate a simple inline test for Address

```
    [Fact]
    public void Address_WithCompleteAddress_ValidatesSuccessfully()
```

and maybe extend with `Assert.Empty(...)`


Now this will FAIL due to PostCode validation; it will attempt to place what _looks_ like correct information in there, but fail because Postcode must be exactly 5 characters long. FIRST RED FLAG; naive assumptions.

