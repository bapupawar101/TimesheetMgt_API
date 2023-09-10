namespace TimesheetManagement_API.Models
{
    public class Employee
    {
        public string? Name { get; set; }
        public bool IsBillable { get; set; }
        public string? OtherSkills { get; set; }
        public string[]? Comments { get; set; }
        public string? Designation { get; set; }
    }
}
