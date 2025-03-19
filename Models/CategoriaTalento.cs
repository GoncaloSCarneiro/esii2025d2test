using System;
using System.Collections.Generic;

namespace ESII2025d2.Models;

public partial class CategoriaTalento
{
    public int cod { get; set; }

    public string nome { get; set; } = null!;

    public virtual ICollection<PropostaTrabalho> PropostaTrabalhos { get; set; } = new List<PropostaTrabalho>();

    public virtual ICollection<Talento> Talentos { get; set; } = new List<Talento>();
}
