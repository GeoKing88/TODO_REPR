namespace REPR_ToDo.ToDos.List;

public record Response(
    int NumberOfTodos,
    IReadOnlyCollection<ResponseItem> Data);
        
    public record ResponseItem(int id, string title);