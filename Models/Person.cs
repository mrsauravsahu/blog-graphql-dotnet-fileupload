namespace BlogGraphQLFileUpload.Models;

public record Person
{
  public int Id { get; set; }
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public long? CoverPhotoLength { get; set; }
  public string CoverPhoto { get; set; }
}