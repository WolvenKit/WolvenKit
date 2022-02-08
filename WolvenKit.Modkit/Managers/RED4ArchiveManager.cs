using ProtoBuf;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    /// <summary>
    /// Abstract implementation for cyberpunk 2077 archive managers
    /// e.g. archive
    /// </summary>
    [ProtoContract]
    public abstract class RED4ArchiveManager : WolvenKitArchiveManager
    {
        public RED4ArchiveManager()
        {
        }
    }
}
