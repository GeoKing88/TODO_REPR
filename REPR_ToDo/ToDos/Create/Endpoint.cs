namespace REPR_ToDo.ToDos.Create;

public static class Endpoint
{

    public static WebApplication MapTodoCreateEndpoint(this WebApplication app)
    {
        app.MapPost("api/todos/create", HandleAsync);
        return app;
    }

    private static Task<Response> HandleAsync(Request request)
    {
        Response response = new Response(1, request.Title, request.DueDate, request.Author, true);
        return Task.FromResult(response);
    }
}