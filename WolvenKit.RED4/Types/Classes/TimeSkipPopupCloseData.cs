using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TimeSkipPopupCloseData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("timeChanged")] 
		public CBool TimeChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TimeSkipPopupCloseData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
