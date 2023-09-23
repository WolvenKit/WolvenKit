using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FilterNPCDodgeOpportunity : gameEffectObjectGroupFilter_Scripted
	{
		[Ordinal(0)] 
		[RED("applyToTechWeapons")] 
		public CBool ApplyToTechWeapons
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("doDodgingTargetsGetFilteredOut")] 
		public CBool DoDodgingTargetsGetFilteredOut
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FilterNPCDodgeOpportunity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
