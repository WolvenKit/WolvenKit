using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.ViewModels.Documents
{
    public class W2rcBufferViewModel : W2rcFileViewModel
    {
        private ICR2WBuffer _buffer;
        private IWolvenkitFile _cr2wbuffer;
        private readonly CR2WFile _w2RcFile;

        public W2rcBufferViewModel(ICR2WBuffer buffer, IWolvenkitFile redbuffer, CR2WFile w2rcFile) : base(redbuffer)
        {
            _buffer = buffer;
            _cr2wbuffer = redbuffer;
            _w2RcFile = w2rcFile;
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        #region methods

        public override string ToString() => $"{_w2RcFile.GetBufferIndex(_buffer)}.buffer";

        #endregion
    }
}
