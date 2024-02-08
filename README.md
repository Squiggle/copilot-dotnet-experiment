# copilot-dotnet-experiment
Minimal project to validate the effectiveness of Copilot-supported unit testing

# Setup

Collect code coverage

```
dotnet watch --project AddressValidator.Tests/ test /p:CollectCoverage=true
```

# Stages

## 1. Demonstrate the POWER of Copilot for creating code

Ask Copilot Chat:

```
How do I create a class validation attribute that ensures that a postcode begins with two characters if the Country property is "UK"?
```

## 2. Demonstrate a simple inline test for Address

```
    [Fact]
    public void Address_WithCompleteAddress_ValidatesSuccessfully()
```

and maybe extend with `Assert.Empty(...)`


Now this will FAIL due to PostCode validation; it will attempt to place what _looks_ like correct information in there, but fail because Postcode must be exactly 5 characters long. FIRST RED FLAG; naive assumptions.

## 3. Attempt inline theories

Prompt:
```
Write a test for Address validation using XUnit theories for all passing and failing permutations
```

Analyse result
- Benefits (structures the test cases quite well)
- Downsides (mix of terminology, incorrect test cases (assuming optional fields must be required)

## 4. Rewrite tests for better output

Prompt

```
Refactor Address_Validation_Test method to provide clearer human-readable failure messages
```

Or for extreme readability

```
Refactor the InlineData tests of method Address_Validation_Test into individual [Fact] tests. Ensure the common Validator.TryValidateObject code is abstracted into a separate private method to ensure good readability.
```

and if it tries to get you to do the work...

```
Expand on all the tests above.
```


# Learnings

Vigilance and visibility.

- Copilot will not create accurate code, but it might be pretty close
- It is effective at suggesting and refactoring; it excels at human-readable content, so use this to your advantage
- It will mostly do what you ask; it will only be as good as you ask it to be

Tooling
- Insert-at-point, create-new-file are all useful tools to improve efficiency
- Constant feedback from `dotnet watch` is your friend; this supports incremental development and experimentation
