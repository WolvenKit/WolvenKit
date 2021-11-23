using System.Collections.Generic;

namespace WolvenKit.RED4.Types
{
    public class Red4File
    {
        public HandleManager HandleManager;
        public BufferHandler BufferHandler;

        protected internal IList<IRedClass> _chunks;
        protected internal IList<RedBuffer> _buffers;

        public Red4File()
        {
            HandleManager = new(this);
            BufferHandler = new(this);

            _chunks = new List<IRedClass>();
            _buffers = new List<RedBuffer>();
        }

        public IList<IRedClass> Chunks
        {
            get => _chunks;
        }
    }
}
