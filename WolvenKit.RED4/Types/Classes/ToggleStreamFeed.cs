using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleStreamFeed : ActionBool
	{
		[Ordinal(38)] 
		[RED("vRoomFake")] 
		public CBool VRoomFake
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleStreamFeed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
