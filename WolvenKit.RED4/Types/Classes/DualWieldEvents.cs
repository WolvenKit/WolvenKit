using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DualWieldEvents : UpperBodyEventsTransition
	{
		[Ordinal(6)] 
		[RED("hasInstantEquipHackBeenApplied")] 
		public CBool HasInstantEquipHackBeenApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DualWieldEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
