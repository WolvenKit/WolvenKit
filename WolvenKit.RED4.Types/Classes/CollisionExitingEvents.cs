using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CollisionExitingEvents : ImmediateExitWithForceEvents
	{
		[Ordinal(6)] 
		[RED("animFeatureStatusEffect")] 
		public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect
		{
			get => GetPropertyValue<CHandle<AnimFeature_StatusEffect>>();
			set => SetPropertyValue<CHandle<AnimFeature_StatusEffect>>(value);
		}
	}
}
