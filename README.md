# Design Patterns - Template Method

This repository showcases an implementation of the Template Method design pattern in C#. The code demonstrates how to define the skeleton of an algorithm in an abstract class while allowing subclasses to implement specific steps, creating a flexible and consistent process flow.

## Table of Contents
1. [Introduction](#introduction)
2. [Implementation Overview](#implementation-overview)
3. [Installation](#installation)
4. [Usage](#usage)
5. [Contributing](#contributing)
6. [License](#license)
7. [Contact](#contact)

## Introduction
The Template Method design pattern is a behavioral pattern that defines the skeleton of an algorithm in an abstract class, deferring some steps to subclasses. This pattern promotes code reusability by allowing subclasses to customize certain parts of the algorithm without altering its structure.

## Implementation Overview
This repository provides a C# implementation of the Template Method pattern. Key components of the code include:

- **AlgorithmTemplate Class**: An abstract class that defines the template method `ExecuteAlgorithm()` with abstract and concrete steps.
- **ConcreteAlgorithmA Class**: A subclass that provides specific implementations for `StepOne()` and `StepTwo()`.
- **ConcreteAlgorithmB Class**: A subclass that overrides `StepOne()` and `StepTwo()`, and customizes `StepThree()`.
- **Program Class**: Demonstrates how to execute the algorithm and shows the flexibility of the Template Method pattern.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-TemplateMethod.git
```

Navigate into the project directory:

```bash
cd DesignPattern-TemplateMethod
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Template Method pattern in action.
3. Modify or extend the `AlgorithmTemplate`, `ConcreteAlgorithmA`, or `ConcreteAlgorithmB` classes to experiment with different algorithm structures.

### Example Output:
```
Executing ConcreteAlgorithmA:
ConcreteAlgorithmA - Step One: Initializing resources.
ConcreteAlgorithmA - Step Two: Processing data.
Executing Step Three: Common step for all algorithms.

Executing ConcreteAlgorithmB:
ConcreteAlgorithmB - Step One: Loading configuration.
ConcreteAlgorithmB - Step Two: Executing logic.
ConcreteAlgorithmB - Step Three: Finalizing with custom logic.
```

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.txt) file for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.

