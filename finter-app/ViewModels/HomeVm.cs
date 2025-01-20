using finter_app.Models;

namespace finter_app.ViewModels;

public class HomeVm
{
    public ICollection<Agent> Agents { get; set; }
    public ICollection<Position> Positions { get; set; }
}
