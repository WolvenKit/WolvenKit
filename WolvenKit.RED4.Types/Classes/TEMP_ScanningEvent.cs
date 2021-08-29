using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TEMP_ScanningEvent : redEvent
	{
		private CName _clue;
		private CBool _showUI;

		[Ordinal(0)] 
		[RED("clue")] 
		public CName Clue
		{
			get => GetProperty(ref _clue);
			set => SetProperty(ref _clue, value);
		}

		[Ordinal(1)] 
		[RED("showUI")] 
		public CBool ShowUI
		{
			get => GetProperty(ref _showUI);
			set => SetProperty(ref _showUI, value);
		}
	}
}
