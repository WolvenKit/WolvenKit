using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KnockOverBikeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("forceKnockdown")] 
		public CBool ForceKnockdown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("applyDirectionalForce")] 
		public CBool ApplyDirectionalForce
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public KnockOverBikeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
