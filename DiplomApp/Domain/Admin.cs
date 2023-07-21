using System;
using System.Collections.Generic;

namespace DiplomApp.Domain;

public partial class Admin
{
    public int Id { get; set; }

    public string Fio { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int ByroId { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual Byro Byro { get; set; } = null!;
}
