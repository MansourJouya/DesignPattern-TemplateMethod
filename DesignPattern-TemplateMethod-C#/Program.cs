using System;
using System.Collections.Generic;

/// <summary>
/// Abstract class defining the template method pattern for executing an algorithm.
/// </summary>
public abstract class AlgorithmTemplate
{
    /// <summary>
    /// Template method defining the skeleton of an algorithm.
    /// </summary>
    public void ExecuteAlgorithm()
    {
        StepOne();
        StepTwo();
        StepThree();
    }

    /// <summary>
    /// Abstract step to be implemented by subclasses.
    /// </summary>
    protected abstract void StepOne();

    /// <summary>
    /// Abstract step to be implemented by subclasses.
    /// </summary>
    protected abstract void StepTwo();

    /// <summary>
    /// Concrete step that can be overridden by subclasses.
    /// </summary>
    protected virtual void StepThree()
    {
        Console.WriteLine("Executing Step Three: Common step for all algorithms.");
    }
}

/// <summary>
/// Concrete implementation of the algorithm for a specific case.
/// </summary>
public class ConcreteAlgorithmA : AlgorithmTemplate
{
    /// <summary>
    /// Implementation of Step One for ConcreteAlgorithmA.
    /// </summary>
    protected override void StepOne()
    {
        Console.WriteLine("ConcreteAlgorithmA - Step One: Initializing resources.");
    }

    /// <summary>
    /// Implementation of Step Two for ConcreteAlgorithmA.
    /// </summary>
    protected override void StepTwo()
    {
        Console.WriteLine("ConcreteAlgorithmA - Step Two: Processing data.");
    }
}

/// <summary>
/// Another concrete implementation of the algorithm for a different case.
/// </summary>
public class ConcreteAlgorithmB : AlgorithmTemplate
{
    /// <summary>
    /// Implementation of Step One for ConcreteAlgorithmB.
    /// </summary>
    protected override void StepOne()
    {
        Console.WriteLine("ConcreteAlgorithmB - Step One: Loading configuration.");
    }

    /// <summary>
    /// Implementation of Step Two for ConcreteAlgorithmB.
    /// </summary>
    protected override void StepTwo()
    {
        Console.WriteLine("ConcreteAlgorithmB - Step Two: Executing logic.");
    }

    /// <summary>
    /// Overriding Step Three for ConcreteAlgorithmB.
    /// </summary>
    protected override void StepThree()
    {
        Console.WriteLine("ConcreteAlgorithmB - Step Three: Finalizing with custom logic.");
    }
}

/// <summary>
/// Demonstration class for the Template Method pattern.
/// </summary>
public class Program
{
    /// <summary>
    /// Main entry point of the program.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine("Executing ConcreteAlgorithmA:");
        AlgorithmTemplate algorithmA = new ConcreteAlgorithmA();
        algorithmA.ExecuteAlgorithm();

        Console.WriteLine("\nExecuting ConcreteAlgorithmB:");
        AlgorithmTemplate algorithmB = new ConcreteAlgorithmB();
        algorithmB.ExecuteAlgorithm();
    }
}
