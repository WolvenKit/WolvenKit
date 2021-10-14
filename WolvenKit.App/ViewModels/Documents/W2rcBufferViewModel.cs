using WolvenKit.Common.Model.Cr2w;

namespace WolvenKit.ViewModels.Documents
{
    public class W2rcBufferViewModel : RedDocumentItemViewModel
    {
        private ICR2WBuffer _buffer;

        public W2rcBufferViewModel(ICR2WBuffer buffer)
        {
            _buffer = buffer;
        }

        public override ERedDocumentItemType DocumentItemType => ERedDocumentItemType.W2rcBuffer;

        #region methods

        public override string ToString() => $"buffer.{_buffer.Index}";

        #endregion
    }
}
