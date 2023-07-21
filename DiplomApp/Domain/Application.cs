using System;
using System.Collections.Generic;

namespace DiplomApp.Domain;

public partial class Application
{
    public int Id { get; set; }

    public DateTime DateTimeStart { get; set; }

    public string Opis { get; set; } = null!;

    public DateTime? DateTimeEnd { get; set; }

    public string? Prim { get; set; }

    public string CompName { get; set; } = null!;

    public string Tel { get; set; } = null!;

    public string? AppState { get; set; }

    public int UserId { get; set; }

    public int? AdminId { get; set; }

    public virtual Admin? Admin { get; set; }

    public virtual User User { get; set; } = null!;
}
