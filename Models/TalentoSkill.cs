using System;
using System.Collections.Generic;

namespace ESII2025d2.Models;

public partial class TalentoSkill
{
    public int codskill { get; set; }

    public int idtalento { get; set; }

    public int anosexperiencia { get; set; }

    public virtual Skill codskillNavigation { get; set; } = null!;

    public virtual Talento idtalentoNavigation { get; set; } = null!;
}
