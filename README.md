# Codility Developer Training

## Summary

Codility is widely used by companies for technical interviews, making it crucial to practice and familiarize yourself with real-world coding interview settings. This repository helps you prepare by working through Codility's lessons and creating a testing environment similar to what you’ll experience during interviews.

For tips on how to excel in Codility interviews, check out the [Codility FAQ and Strategies for Success](https://app.codility.com/candidate-faq/).

---

## How to Get Started

Follow these steps to effectively practice Codility lessons:

1. **Practice Each Lesson**: Begin by practicing the available lessons.
   - [Codility Lessons](https://app.codility.com/programmers/lessons)
   
2. **Build Classes and Unit Tests**: For each task, create a corresponding class and unit test to simulate a real interview coding environment.

---

## Build Instructions

Here’s how to set up and run your Codility practice environment in Visual Studio:

### Step 1: Clone the Repository

Clone the repository into your local machine using Visual Studio or any other development environment of your choice.

### Step 2: Run Unit Tests

Use the following keyboard shortcuts to run tests:

- **Run All Tests**: `Ctrl + R`, then `A`
- **Run a Single Test**: Navigate to the test method and press `Ctrl + R`, then `T`

### Step 3: Add Additional Tests

You can easily add more test cases to ensure your solution is thoroughly tested. Create additional test methods within the `Tests` class as shown below:

```csharp
public class Tests
{
    [Test]
    public void Test1()
    {
        Assert.That(SolutionClass.HelloWorld("Hi!"), Is.EqualTo("Hi!"));
    }

    [Test]
    public void Test2()
    {
        Assert.That(SolutionClass.HelloWorld("Hello!"), Is.EqualTo("Hello!"));
    }
}
```

In this example:
- Add your own test logic within new test methods.
- Use `Assert.That` to check the expected output against the actual result from your solution.

You can create as many test cases as needed to ensure your code handles all edge cases and scenarios.

---

## Contribution and Feedback

Feel free to contribute by adding new lessons, improving the tests, or suggesting changes to make this training more robust. Submit a pull request or open an issue to share your improvements.

