namespace DoItTaskScheduler
{
    /// <summary>
    /// class for Task type
    /// </summary>
    public class Task
    {
        // enum tasks
        public enum TaskTypes { STUDY, CASUAL, HOUSE, WORK };

        /* Different properties to access data fields from outside */

        public string TaskName { get; set; }
        public TaskTypes TaskCategory { get; set; }
        public string TaskStartDate { get; set; }
        public string TaskStartTime { get; set; }
        public string TaskStopDate { get; set; }
        public string TaskStopTime { get; set; }
        public string TaskDescription { get; set; }

        // we set a constant for not applicable string
        public const string NotApplicableString = "Not Applicable";

        private int _taskId;

        public int TaskId
        {
            get
            {
                return _taskId; //TODO: create a unique task id for every sing
            }
        }

        public Task()
        {
            _taskId = 0;
            TaskName = "UntitledTaskName";
            TaskDescription = "UntitledTaskDescription";
            TaskCategory = TaskTypes.STUDY;
        }

        public void AssignTaskId()
        {
            _taskId += 1;
        }
    }
}