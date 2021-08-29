using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CollisionExitingEvents : ImmediateExitWithForceEvents
	{
		private CHandle<AnimFeature_StatusEffect> _animFeatureStatusEffect;

		[Ordinal(6)] 
		[RED("animFeatureStatusEffect")] 
		public CHandle<AnimFeature_StatusEffect> AnimFeatureStatusEffect
		{
			get => GetProperty(ref _animFeatureStatusEffect);
			set => SetProperty(ref _animFeatureStatusEffect, value);
		}
	}
}
