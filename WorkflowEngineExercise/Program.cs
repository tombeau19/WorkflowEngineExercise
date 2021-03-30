using System;

namespace WorkflowEngineExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();

            workflow.AddActivity(new DoThisThing());
            workflow.AddActivity(new DoThisOtherThing());

            var workflowEngine = new WorkflowEngine(workflow);
            workflowEngine.Run();

        }
    }
}
