namespace Lab_2.Task_1
{
    public class Manager : Person, IAssign
    {
        public void AssignTask()
        {
            Task t = new Task() { Title = "Merge and Deploy", Description = "Task to merge and deploy sharing feature to develop" };
            t?.AssignTo(new TeamLead());
        }
        public void CreateSubTask() { }
    }
}
