using System;
using System.Collections.Generic;

namespace DiplomApp.Domain;

public partial class User
{
    public int Id { get; set; }

    public string Fio { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
    public override string ToString()
    {
        return Fio;
    }
}
