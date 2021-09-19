using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public class Red4File
    {
        public HandleManager HandleManager;

        protected internal IList<IRedClass> _chunks;
        protected internal IList<IRedBuffer> _buffers;

        public Red4File()
        {
            HandleManager = new(this);

            _chunks = new List<IRedClass>();
            _buffers = new List<IRedBuffer>();
        }
    }
}
