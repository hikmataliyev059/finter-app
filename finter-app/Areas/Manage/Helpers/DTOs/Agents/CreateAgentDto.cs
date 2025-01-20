namespace finter_app.Areas.Manage.Helpers.DTOs.Agents;

public record CreateAgentDto
{
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public IFormFile File { get; set; }
    public int? PositionID { get; set; }
}
