using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeSkipPopupCloseData : inkGameNotificationData
	{
		[Ordinal(6)] 
		[RED("timeChanged")] 
		public CBool TimeChanged
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
