using System;
using System.Collections.Generic;
using System.Linq;
using ProtoBuf;
using WolvenKit.Common.Model;
using WolvenKit.RED4.Types;

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
            RedReflection.BuildCache();
        }
    }
}
