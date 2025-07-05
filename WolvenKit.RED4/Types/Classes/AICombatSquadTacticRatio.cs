using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICombatSquadTacticRatio : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ratioSum")] 
		public CFloat RatioSum
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("reachSum")] 
		public CFloat ReachSum
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("area")] 
		public CFloat Area
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AICombatSquadTacticRatio()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
