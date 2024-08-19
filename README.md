# Codility Developer Training

## Summary

Most Companies utilize Codality to interview developers, therefore it is important to grasp a realistic setting of a coding interview.

[Codality FAQ and Strategies for Success](https://app.codility.com/candidate-faq/)

## How To Get Started

Start by practicing each Lesson Available
[Link to Codality Lessons](https://app.codility.com/programmers/lessons)

When you start the tasks, make sure to build a class and unit test respectively.

## Build

Clone the GitHub Repository into Visual Studio

Run Tests (Keyboard Shortcut)

- Run All Tests (Ctrl + R, then A)

- Run A single test (Navigate to the test method, Ctrl + R, T)

Adding additional tests

- Create an additional public void function within the public class (Tests) and add your own tests

```
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.That(SolutionClass.HelloWorld("Hi!"), Is.EqualTo("Hi!"));
        }
    }
```
  
