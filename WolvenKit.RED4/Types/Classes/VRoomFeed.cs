using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VRoomFeed : redEvent
	{
		[Ordinal(0)] 
		[RED("On")] 
		public CBool On
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VRoomFeed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
