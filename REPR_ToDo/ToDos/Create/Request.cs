namespace REPR_ToDo.ToDos.Create;

public record Request(
        string Title,
        DateOnly? DueDate,
        string Author
);