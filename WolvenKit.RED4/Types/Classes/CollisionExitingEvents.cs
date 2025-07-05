using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CollisionExitingEvents : ImmediateExitWithForceEvents
	{
		[Ordinal(7)] 
		[RED("animFeatureStatusEffect")] 
		public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect
		{
			get => GetPropertyValue<CHandle<AnimFeature_StatusEffect>>();
			set => SetPropertyValue<CHandle<AnimFeature_StatusEffect>>(value);
		}

		public CollisionExitingEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
