using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TimeSkipPopupCloseData : inkGameNotificationData
	{
		private CBool _timeChanged;

		[Ordinal(6)] 
		[RED("timeChanged")] 
		public CBool TimeChanged
		{
			get => GetProperty(ref _timeChanged);
			set => SetProperty(ref _timeChanged, value);
		}
	}
}
