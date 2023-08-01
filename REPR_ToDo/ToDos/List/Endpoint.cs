namespace REPR_ToDo.ToDos.List;

public static class EndPoint
{
    public static WebApplication MapTodoListEndpoint(this WebApplication app)
    {
        app.MapGet("api/todos", HandleAsync);
        return app;
    }

    private static Task<Response> HandleAsync()
    {
        List<ResponseItem> responseItems = new List<ResponseItem>
        {
            new(10, "Clean house"),
            new(11, "See Movie")
        };
        Response response = new Response(2, responseItems);
        return Task.FromResult(response);
    }
}