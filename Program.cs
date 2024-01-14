var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddTypes()
    .AddMutationConventions(false);

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
