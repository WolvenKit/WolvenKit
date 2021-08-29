using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuickHackPanelStateEvent : redEvent
	{
		private CBool _isOpened;

		[Ordinal(0)] 
		[RED("isOpened")] 
		public CBool IsOpened
		{
			get => GetProperty(ref _isOpened);
			set => SetProperty(ref _isOpened, value);
		}
	}
}
