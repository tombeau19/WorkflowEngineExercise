using System;
using System.Collections.Generic;

namespace WorkflowEngineExercise
{
    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
        {
            if(activity == null)
                throw new InvalidOperationException("activity is null");

            _activities.Add(activity);
        }

        public void RemoveActivity(IActivity activity)
        {
            if (activity == null)
                throw new InvalidOperationException("activity is null");

            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}