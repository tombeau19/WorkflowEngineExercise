using System.Collections.Generic;

namespace WorkflowEngineExercise
{
    public interface IWorkflow
    {
        void AddActivity(IActivity activity);
        void RemoveActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}