using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseHideUIDetectionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("shouldHideUIDetection")] 
		public CBool ShouldHideUIDetection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public senseHideUIDetectionEvent()
		{
			ShouldHideUIDetection = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
