namespace WolvenKit.App.ViewModels.GraphEditor;

public interface IGraphProvider
{
    public RedGraph? Graph { get; }

    public void RecalculateSockets();
}