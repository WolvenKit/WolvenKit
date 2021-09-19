using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public class Red4File
    {
        internal HandleManager _handleManager;

        public IList<CName> Names { get; set; }
        public IList<IRedImport> Imports { get; set; }
        public IList<IRedClass> Chunks { get; set; }
        public IList<IRedBuffer> Buffers { get; set; }

        public Red4File()
        {
            _handleManager = new(this);
        }
    }
}
