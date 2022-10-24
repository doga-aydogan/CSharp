using System;
using System.Collections.Generic;

namespace Engine
{
    public class WorkflowEngine
    {
        private IList<IActivity> _workflows;

        public WorkflowEngine()
        {
            _workflows = new List<IActivity>(); //list of activities
        }
        public void Run()

        {
            if (_workflows.Count == 0) //empty workflow cannot run
            {
                throw new InvalidOperationException("Empty workflow cannot run."); 
            }
            foreach (var activity in _workflows)
            {
               activity.Execute(); //polymorphic behaviour happens here
            }
        }

        public void AddActivity(IActivity activity)
        {
            _workflows.Add(activity); //adds activity to the workflow
        }
    }
}
