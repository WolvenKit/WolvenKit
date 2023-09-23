using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public interface IRedCompiledPropertyData
{
    public IRedType? CustomRead(Red4Reader reader, uint size, CName propertyName);
    public void CustomWrite(Red4Writer writer, CName propertyName);
}