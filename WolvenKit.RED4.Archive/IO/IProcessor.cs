using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public interface IPreProcessor
{
    public void Process(RedBaseClass cls);
}