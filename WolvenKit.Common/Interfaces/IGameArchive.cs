using System.Collections.Generic;
using ProtoBuf;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.Common
{
    [ProtoContract]
    public interface IGameArchive
    {
        #region Properties

        public string ArchiveAbsolutePath { get; set; }

        public Dictionary<ulong, IGameFile> Files { get; }
        public string Name { get; }
        EArchiveType TypeName { get; }
        

        #endregion Properties
    }

    public interface ICyberGameArchive : IGameArchive
    {

        

    }

    public interface IWitcherGameArchive : IGameArchive
    {


    }
}
