using HotChocolate.Types;
using BlogGraphQLFileUpload.GraphQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddType<UploadType>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseAuthorization();
app.MapControllers();

app
    .UseRouting()
    .UseEndpoints(endpoints => { endpoints.MapGraphQL(); });

app.Run();
