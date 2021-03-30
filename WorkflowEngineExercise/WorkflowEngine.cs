using System;
using System.Collections.Generic;

namespace WorkflowEngineExercise
{
    public class WorkflowEngine
    {
        private readonly Workflow _workflow;

        public WorkflowEngine(Workflow workflow)
        {
            _workflow = workflow;
        }

        public void Run()
        {
            if(_workflow._activities.Count == 0)
                throw new InvalidOperationException("No Activites in the workflow");

            foreach (var workflowActivity in _workflow._activities)
            {
                workflowActivity.Execute();
            }
        }
    }
}