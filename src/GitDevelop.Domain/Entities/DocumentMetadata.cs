namespace GitDevelop.Domain.Entities;

public class DocumentMetadata
{
    public string Title { get; set; }
    public string Description { get; set; }
    public IReadOnlyCollection<string> Tags { get; set; }
}
