namespace Lab_2.Task_1
{
    public class TeamLead : Person, ILead
    {
        public void AssignTask()
        {
            Task t = new Task() { Title = "Merge and Deploy", Description = "Task to merge and deploy sharing feature to develop" };
            t?.AssignTo(new Developer());
        }
        public void CreateSubTask() { }
        public void WorkOnTask() { }
    }
}
