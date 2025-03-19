using System;
using System.Collections.Generic;

namespace ESII2025d2.Models;

public partial class Experiencium
{
    public int id { get; set; }

    public string titulo { get; set; } = null!;

    public string nomeempresa { get; set; } = null!;

    public int anocomeco { get; set; }

    public int? anofim { get; set; }

    public int idtalento { get; set; }

    public virtual Talento idtalentoNavigation { get; set; } = null!;
}
