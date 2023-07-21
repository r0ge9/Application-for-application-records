using System;
using System.Collections.Generic;

namespace DiplomApp.Domain;

public partial class Byro
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();
}
