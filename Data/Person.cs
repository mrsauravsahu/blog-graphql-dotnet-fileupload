using BlogGraphQLFileUpload.Models;

namespace BlogGraphQLFileUpload.Data;

// Note: this is done for the example
// In production, store data in some sort of a dataStore, like a Database

public static class GlobalData
{
  public static Person me = new Person
  {
    FirstName = "Saurav",
    LastName = "Sahu",
    Id = 1,
  };
}