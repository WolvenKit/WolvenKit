using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    /// <summary>
    /// An interface for the external side of the archive.
    /// Implemented by Bundle, CollisionCache, TextureCache, W3Speech, SoundCache.
    /// </summary>
    public interface IExternalWitcherArchive
    {
        EBundleType TypeName { get; }
        /// <summary>
        /// In filesystem terminology, absolute path is also called fully-qualified path.
        /// External aka windows-explorable path, from disk root to file name included.
        /// </summary>
        string ExternalAbsoluteArchivePath { get; set; }
    }
}
