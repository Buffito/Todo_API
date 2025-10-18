namespace Todo_API.DTO.Todo
{
  public class UpdateTodoDto
  {
    public int? ParentId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? AssignedTo { get; set; }
    public string? Status { get; set; }
  }
}
