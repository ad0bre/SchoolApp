namespace SchoolApp.Base.Models;

public class Model : IModel
{
    protected Model()
    {
        Id = Guid.NewGuid().ToString();
        Created = Updated = DateTime.UtcNow;
    }
    
    public string Id { get; set; }

    public DateTime Created { get; set; }

    public DateTime Updated { get; set; }
}