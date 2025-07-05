using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExitingEvents : ExitingEventsBase
	{
		[Ordinal(4)] 
		[RED("fromDriverCombat")] 
		public CBool FromDriverCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExitingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
