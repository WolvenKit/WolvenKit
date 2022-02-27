using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public interface INodeParser
{
    public void Read(SaveNode node);
    public SaveNode Write();
}
