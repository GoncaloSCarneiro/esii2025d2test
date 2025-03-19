using System;
using System.Collections.Generic;

namespace ESII2025d2.Models;

public partial class Cliente
{
    public int id { get; set; }

    public string empresa { get; set; } = null!;

    public string numerotelefone { get; set; } = null!;

    public int idutilizador { get; set; }

    public virtual ICollection<PropostaTrabalho> PropostaTrabalhos { get; set; } = new List<PropostaTrabalho>();

    public virtual Utilizador idutilizadorNavigation { get; set; } = null!;
}
