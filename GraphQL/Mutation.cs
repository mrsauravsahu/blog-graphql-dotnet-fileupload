using BlogGraphQLFileUpload.Data;
using HotChocolate.Types;

namespace BlogGraphQLFileUpload.GraphQL;

public class Mutation
{
  public async Task<long?> coverPhoto(IFile file)
  {
    await using var stream = file.OpenReadStream();

    var streamWriter = new FileStream("./output.jpg", FileMode.OpenOrCreate);

    await stream.CopyToAsync(streamWriter);

    GlobalData.me.CoverPhotoLength = stream.Length;

    return GlobalData.me.CoverPhotoLength;
  }
}