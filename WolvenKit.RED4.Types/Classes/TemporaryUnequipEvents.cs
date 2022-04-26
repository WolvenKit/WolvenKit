using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TemporaryUnequipEvents : UpperBodyEventsTransition
	{
		[Ordinal(6)] 
		[RED("forceOpen")] 
		public CBool ForceOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TemporaryUnequipEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
