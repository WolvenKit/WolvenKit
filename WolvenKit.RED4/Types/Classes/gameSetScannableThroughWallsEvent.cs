using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameSetScannableThroughWallsEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isScannableThroughWalls")] 
		public CBool IsScannableThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameSetScannableThroughWallsEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
