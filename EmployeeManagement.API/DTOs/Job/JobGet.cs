namespace EmployeeManagement.API.DTOs.Job
{
    public class JobGet
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
