using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePlayInDeviceCallbackEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("wasPlayInDeviceSuccessful")] 
		public CBool WasPlayInDeviceSuccessful
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gamePlayInDeviceCallbackEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
