using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScanEvent : redEvent
	{
		private CString _clue;
		private CBool _isAvailable;

		[Ordinal(0)] 
		[RED("clue")] 
		public CString Clue
		{
			get => GetProperty(ref _clue);
			set => SetProperty(ref _clue, value);
		}

		[Ordinal(1)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get => GetProperty(ref _isAvailable);
			set => SetProperty(ref _isAvailable, value);
		}
	}
}
