using System;
using System.Collections.Generic;

namespace WorkflowEngineExercise
{
    public class Workflow
    {
        public IList<IActivity> _activities { get; set; } = new List<IActivity>();

        public void AddActivity(IActivity activity)
        {
            if(activity == null)
                throw new InvalidOperationException("activity is null");

            _activities.Add(activity);
        }
    }
}