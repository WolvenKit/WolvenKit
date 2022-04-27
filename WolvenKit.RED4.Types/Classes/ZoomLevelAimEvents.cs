using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ZoomLevelAimEvents : ZoomEventsTransition
	{
		[Ordinal(0)] 
		[RED("isAmingWithWeapon")] 
		public CBool IsAmingWithWeapon
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ZoomLevelAimEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
