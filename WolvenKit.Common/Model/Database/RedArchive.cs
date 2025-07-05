using System.Collections.Generic;

namespace WolvenKit.Common.Model.Database;

public class RedArchive
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Source { get; set; }
    public List<RedFile>? Files { get; set; }
}
