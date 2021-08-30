using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameFocusClueStateChangeEvent : redEvent
	{
		private CInt32 _clueIndex;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("clueIndex")] 
		public CInt32 ClueIndex
		{
			get => GetProperty(ref _clueIndex);
			set => SetProperty(ref _clueIndex, value);
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		public gameFocusClueStateChangeEvent()
		{
			_clueIndex = -1;
		}
	}
}
