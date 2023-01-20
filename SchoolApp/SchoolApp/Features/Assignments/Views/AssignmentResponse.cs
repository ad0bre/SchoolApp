namespace SchoolApp.Features.Assignments.Views;

public class AssignmentResponse
{
    public string Id { get; set; }
    
    public string Subject { get; set; }
    
    public string Description { get; set; }
    
    public DateTime Deadline { get; set; }
}