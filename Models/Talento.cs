using System;
using System.Collections.Generic;

namespace ESII2025d2.Models;

public partial class Talento
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public string pais { get; set; } = null!;

    public string email { get; set; } = null!;

    public decimal precohora { get; set; }

    public int? codcategoriatalento { get; set; }

    public int idutilizador { get; set; }

    public virtual ICollection<Experiencium> Experiencia { get; set; } = new List<Experiencium>();

    public virtual ICollection<TalentoSkill> TalentoSkills { get; set; } = new List<TalentoSkill>();

    public virtual CategoriaTalento? codcategoriatalentoNavigation { get; set; }

    public virtual Utilizador idutilizadorNavigation { get; set; } = null!;
}
