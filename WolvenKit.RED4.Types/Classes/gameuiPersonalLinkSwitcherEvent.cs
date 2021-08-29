using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPersonalLinkSwitcherEvent : redEvent
	{
		private CBool _isAdvanced;

		[Ordinal(0)] 
		[RED("isAdvanced")] 
		public CBool IsAdvanced
		{
			get => GetProperty(ref _isAdvanced);
			set => SetProperty(ref _isAdvanced, value);
		}
	}
}
