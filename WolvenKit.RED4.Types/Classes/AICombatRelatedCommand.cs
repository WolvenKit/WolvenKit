using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICombatRelatedCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AICombatRelatedCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
