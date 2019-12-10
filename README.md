# Convert to camel case

## Converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case).

**Eg**

```
ToCamelCase("the-stealth-warrior") // returns "theStealthWarrior"

ToCamelCase("The_Stealth_Warrior") // returns "TheStealthWarrior"
```

---

## Acceptance Criteria

Input | Output
--- | ---
once-upon-a-time | onceUponATime
Once_upon_a_time | OnceUponATime

---
### How to run:

- Clone the repo
- Inside the root directory of the project, run it with a string:

    ```
    dotnet run Once-Upon-A-Time
    ```
- To see the test coverage, run:

    ```
    dotnet test
    ```