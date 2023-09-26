# C# .NET Core Scores Application
This repository contains a simple C# .NET Core application named "Scores" that was created as part of a C# .NET course from The [Tech Academy](https://www.learncodinganywhere.com/). In this README, an overview will be provided regarding what was learned while working on this project.

## About the Application
The "Scores" application is a console-based program that interacts with text files containing student scores. The following tasks are performed:

1. The user is greeted, and the current date is displayed.
1. Student scores are read from a text file.
1. The total number of scores and the average score are calculated and displayed.
1. User input is awaited before exiting.

## What Was Learned
### 1. **Console Input and Output**
- The `Console.WriteLine` and `Console.ReadLine` methods were employed to display messages to the user and collect input from them.
### 2. String Interpolation
- String interpolation was used to create dynamic messages, with user input and the current date being incorporated into the output.
### 3. File I/O
- The ability to read data from text files was demonstrated, employing the `File.ReadAllLines` method.
### 4. Data Conversion
- String data from the file was transformed into numerical values (double) through the use of `Convert.ToDouble` in order to execute calculations.
### 5. Data Processing
- The total score and average score of the students were computed.
### 6. Basic Control Flow
- Loops and conditional statements were utilized to govern the execution flow of the program.

## Conclusion
The "Scores" application serves as a simple demonstration of core C# and .NET Core concepts, including input/output, file handling, data conversion, and basic control flow. It showcases the capacity to create interactive console applications in C#, utilizing foundational skills in C# and .NET Core, and offers the potential for further improvements and enhancements to handle real-world scenarios and larger datasets.
