using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HackingRewardNotificationEvent : redEvent
	{
		private CString _text;
		private CArray<CString> _icons;

		[Ordinal(0)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(1)] 
		[RED("icons")] 
		public CArray<CString> Icons
		{
			get => GetProperty(ref _icons);
			set => SetProperty(ref _icons, value);
		}
	}
}
