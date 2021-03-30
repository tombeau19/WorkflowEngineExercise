using System;

namespace WorkflowEngineExercise
{
    public class DoThisOtherThing : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Specific implementation for this other thing");
        }
    }
}