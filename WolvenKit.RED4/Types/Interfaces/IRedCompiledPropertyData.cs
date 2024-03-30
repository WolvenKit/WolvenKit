using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.IO;

namespace WolvenKit.RED4.Types;

public interface IRedCompiledPropertyData
{
    public bool IsCustomReadNeeded(RedPackageHeader redPackageHeader);
    public IRedType? CustomRead(Red4Reader reader, uint size, string propertyName);

    public bool IsCustomWriteNeeded(RedPackageHeader redPackageHeader);
    public void CustomWrite(Red4Writer writer, string propertyName);
}