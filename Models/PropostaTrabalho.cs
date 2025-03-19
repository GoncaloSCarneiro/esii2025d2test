using System;
using System.Collections.Generic;

namespace ESII2025d2.Models;

public partial class PropostaTrabalho
{
    public int cod { get; set; }

    public int codskill { get; set; }

    public string nome { get; set; } = null!;

    public int numtotalhoras { get; set; }

    public string? descricao { get; set; }

    public int? cliente_id { get; set; }

    public int? cattalento_cod { get; set; }

    public virtual CategoriaTalento? cattalento_codNavigation { get; set; }

    public virtual Cliente? cliente { get; set; }

    public virtual Skill codskillNavigation { get; set; } = null!;
}
