using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayInDeviceCallbackEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("wasPlayInDeviceSuccessful")] 
		public CBool WasPlayInDeviceSuccessful
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
