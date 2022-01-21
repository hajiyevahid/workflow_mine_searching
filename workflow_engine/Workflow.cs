using System.Collections;
using System.Collections.Generic;

namespace workflow_engine

{
    public class Workflow
    {
        private readonly IList<ISeries_of_actions> series_of_action;
        public Workflow()
        {
            series_of_action = new List<ISeries_of_actions>();
        }
        public void Run()
        {
            foreach (var actions in series_of_action)
            {
                actions.Execute();
            }

        }
        public void adding_actions_to_series(ISeries_of_actions actions)
        {
            series_of_action.Add(actions);
        }

    }
}
