namespace BenivoProject.Models
{
    public class JobViewModel
    {
        public int Id { get; set; }
        public int CategoriId { get; set; }
        public bool Bookmarked { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Details { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string EmploymentType { get; set; }
    }
}
