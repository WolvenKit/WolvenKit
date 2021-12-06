using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.ViewModels.Documents
{
    public class W2rcBufferViewModel : W2rcFileViewModel
    {
        private IRedBuffer _buffer;
        private Red4File _cr2wbuffer;
        private readonly CR2WFile _w2RcFile;

        public W2rcBufferViewModel(IRedBuffer buffer, Red4File redbuffer, CR2WFile w2rcFile) : base(redbuffer)
        {
            _buffer = buffer;
            _cr2wbuffer = redbuffer;
            _w2RcFile = w2rcFile;
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        #region methods

        public override string ToString() => $"Buffer {_w2RcFile.Buffers.IndexOf(_buffer)}";
        //public override string ToString() => $"TODO.buffer";

        #endregion
    }
}
