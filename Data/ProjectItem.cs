namespace abdulkareem_alabi.Data;

public class ProjectItem
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Client { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
}