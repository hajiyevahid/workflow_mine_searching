using System;

namespace workflow_engine // 17:47
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var work = new Workflow();
            work.adding_actions_to_series(new Search_mine());
            work.adding_actions_to_series(new Find_mine());
            work.adding_actions_to_series(new isolate_mine());
            work.adding_actions_to_series(new Boom_mine());
            work.Run();
        }
    }
}
