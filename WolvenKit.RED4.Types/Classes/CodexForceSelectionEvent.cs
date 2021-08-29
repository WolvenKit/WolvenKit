using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CodexForceSelectionEvent : redEvent
	{
		private CInt32 _selectionIndex;
		private CInt32 _hash;

		[Ordinal(0)] 
		[RED("selectionIndex")] 
		public CInt32 SelectionIndex
		{
			get => GetProperty(ref _selectionIndex);
			set => SetProperty(ref _selectionIndex, value);
		}

		[Ordinal(1)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}
	}
}
