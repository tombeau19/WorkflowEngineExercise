using System;

namespace WorkflowEngineExercise
{
    public class DoThisThing : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Specific implementation for this thing");
        }
    }
}