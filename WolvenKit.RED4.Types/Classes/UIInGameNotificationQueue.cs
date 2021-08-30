using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UIInGameNotificationQueue : gameuiGenericNotificationGameController
	{
		private CFloat _duration;

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public UIInGameNotificationQueue()
		{
			_duration = 5.000000F;
		}
	}
}
