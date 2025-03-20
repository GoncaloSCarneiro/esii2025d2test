using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ESII2025d2.Models;

[Table("Cliente")]
public partial class Cliente
{
    [Key]
    public int id { get; set; }

    public string empresa { get; set; } = null!;

    public string numerotelefone { get; set; } = null!;

    public int idutilizador { get; set; }

    public virtual ICollection<PropostaTrabalho> PropostaTrabalhos { get; set; } = new List<PropostaTrabalho>();

    [ForeignKey("idutilizador")]
    public virtual Utilizador idutilizadorNavigation { get; set; } = null!;
}
