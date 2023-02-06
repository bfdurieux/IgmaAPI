namespace IgmaAPI.Models;

public class Client
{
    public Guid ClientId { get; set; }
    public string Name { get; set; }
    public string Registration { get; set; }
    public DateTime Birthdate { get; set; }
}