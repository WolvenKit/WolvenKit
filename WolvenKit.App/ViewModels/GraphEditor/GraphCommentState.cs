using System.Collections.Generic;

namespace WolvenKit.App.ViewModels.GraphEditor;

internal sealed class GraphCommentState
{
    public List<GraphCommentStateEntry>? Comments { get; set; } = [];
}

internal sealed class GraphCommentStateEntry
{
    public string? Id { get; set; }
    public string? Text { get; set; }
    public string? AccentColor { get; set; }
    public double? X { get; set; }
    public double? Y { get; set; }
    public double? Width { get; set; }
    public double? Height { get; set; }
}
