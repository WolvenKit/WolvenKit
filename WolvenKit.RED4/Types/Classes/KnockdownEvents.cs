using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class KnockdownEvents : StatusEffectEvents
	{
		[Ordinal(12)] 
		[RED("cachedPlayerVelocity")] 
		public Vector4 CachedPlayerVelocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(13)] 
		[RED("secondaryKnockdownDir")] 
		public Vector4 SecondaryKnockdownDir
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(14)] 
		[RED("secondaryKnockdownTimer")] 
		public CFloat SecondaryKnockdownTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("playedImpactAnim")] 
		public CBool PlayedImpactAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("frictionForceApplied")] 
		public CBool FrictionForceApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("frictionForceAppliedLastFrame")] 
		public CBool FrictionForceAppliedLastFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("delayDamageFrame")] 
		public CBool DelayDamageFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("bikeKnockdown")] 
		public CBool BikeKnockdown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public KnockdownEvents()
		{
			CachedPlayerVelocity = new Vector4();
			SecondaryKnockdownDir = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
