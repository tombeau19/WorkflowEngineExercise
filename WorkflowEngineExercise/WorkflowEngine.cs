using System;
using System.Collections.Generic;

namespace WorkflowEngineExercise
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workFlow)
        {
            foreach (var workflowActivity in workFlow.GetActivities())
            {
                workflowActivity.Execute();
            }
        }
    }
}