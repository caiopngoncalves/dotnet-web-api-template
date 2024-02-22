using Domain.Common;

namespace Domain.Entities;

public class User : BaseEntity
{
    public required string Nome { get; set; }
    public required string Email { get; set; }
}
