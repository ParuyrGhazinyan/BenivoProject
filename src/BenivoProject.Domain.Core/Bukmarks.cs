namespace BenivoProject.Domain.Core
{
    public class Bookmark:BaseEntity
    {
        public int UserId { get; set; }
        public int Jobid { get; set; }

        public User User { get; set; }
        public Job Job { get; set; }
    }
}
