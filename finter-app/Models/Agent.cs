using finter_app.Models.Common;

namespace finter_app.Models;

public class Agent : BaseEntity
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public IFormFile File { get; set; }
    public int PositionID { get; set; }
    public Position Position { get; set; }
}
