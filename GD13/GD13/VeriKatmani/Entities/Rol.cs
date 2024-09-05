using System;
using System.Collections.Generic;

namespace VeriKatmani.Entities;

public partial class Rol
{
    public int No { get; set; }
    public int id { get; set; }
    public string? Ad { get; set; }
    public string? Aciklama { get; set; }

    public virtual ICollection<Kullanici> Kullanici { get; set; } = new List<Kullanici>();
}
