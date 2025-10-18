namespace Todo_API.DTO.Todo
{
  public class CreateTodoDto
  {
    public int? ParentId { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public string CreatedBy { get; set; }
    public string? AssignedTo { get; set; }
    public string Status { get; set; }
  }
}
