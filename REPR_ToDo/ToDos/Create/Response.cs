namespace REPR_ToDo.ToDos.Create;

public record Response(
        int Id,
        string Title,
        DateOnly? DueDate,
        string Author,
        bool IsActive
);