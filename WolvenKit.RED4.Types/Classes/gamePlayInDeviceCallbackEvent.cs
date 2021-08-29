using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayInDeviceCallbackEvent : redEvent
	{
		private CBool _wasPlayInDeviceSuccessful;

		[Ordinal(0)] 
		[RED("wasPlayInDeviceSuccessful")] 
		public CBool WasPlayInDeviceSuccessful
		{
			get => GetProperty(ref _wasPlayInDeviceSuccessful);
			set => SetProperty(ref _wasPlayInDeviceSuccessful, value);
		}
	}
}
