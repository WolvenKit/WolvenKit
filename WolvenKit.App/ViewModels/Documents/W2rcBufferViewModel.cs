using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Modkit.RED4.Compiled;

namespace WolvenKit.ViewModels.Documents
{
    public class W2rcBufferViewModel : W2rcFileViewModel
    {
        private ICR2WBuffer _buffer;
        private IWolvenkitFile _cr2wbuffer;

        public W2rcBufferViewModel(ICR2WBuffer buffer, IWolvenkitFile redbuffer) : base(redbuffer)
        {
            _buffer = buffer;
            _cr2wbuffer = redbuffer;
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        #region methods

        public override string ToString() => $"buffer.{_buffer.Index}";

        #endregion
    }
}
