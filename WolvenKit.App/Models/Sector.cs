using HelixToolkit.Wpf.SharpDX;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Models;

public class Sector
{
    public Sector(string name, Element3D text)
    {
        Name = name;
        Text = text;
    }

    public string Name { get; set; }

    public CName DepotPath { get; set; }
    public bool IsLoaded { get; set; }
    public Element3D Text { get; set; }
    public Element3D? Element { get; set; }
    public uint NumberOfHandles { get; set; }

    private bool _showElements;
    public bool ShowElements
    {
        get => _showElements;
        set
        {
            _showElements = value;
            if (Element is not null)
            {
                Element.IsRendering = _showElements;
            }
        }
    }
}
