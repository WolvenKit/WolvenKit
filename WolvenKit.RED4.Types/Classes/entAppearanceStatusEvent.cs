using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAppearanceStatusEvent : redEvent
	{
		private CEnum<entAppearanceStatus> _status;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<entAppearanceStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}
	}
}
