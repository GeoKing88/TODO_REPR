using REPR_ToDo.ToDos.Create;
using REPR_ToDo.ToDos.List;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapTodoCreateEndpoint();
app.MapTodoListEndpoint();

app.Run();