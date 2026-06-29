var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<string> dataStore = new List<string> { "Value1", "Value2", "Value3" };

app.MapGet("/api/values", () => 
{
    return Results.Ok(dataStore); // Returns 200 OK with the array
});

app.MapGet("/api/values/{id:int}", (int id) => 
{
    if (id < 0 || id >= dataStore.Count)
    {
        return Results.BadRequest("Invalid ID provided."); // Returns 400 Bad Request
    }
    return Results.Ok(dataStore[id]);
});

app.MapPost("/api/values", (string newValue) => 
{
    if (string.IsNullOrEmpty(newValue))
    {
        return Results.BadRequest("Value cannot be empty.");
    }
    dataStore.Add(newValue);
    return Results.StatusCode(201); // Returns 201 Created
});

app.Run();