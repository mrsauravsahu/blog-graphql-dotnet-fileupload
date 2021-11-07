using BlogGraphQLFileUpload.Data;
using BlogGraphQLFileUpload.Models;

namespace BlogGraphQLFileUpload.GraphQL;

public class Query 
{
  public Person person() => GlobalData.me;
}