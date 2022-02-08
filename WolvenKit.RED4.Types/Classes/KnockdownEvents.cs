using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KnockdownEvents : StatusEffectEvents
	{
		[Ordinal(6)] 
		[RED("cachedPlayerVelocity")] 
		public Vector4 CachedPlayerVelocity
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(7)] 
		[RED("secondaryKnockdownDir")] 
		public Vector4 SecondaryKnockdownDir
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(8)] 
		[RED("secondaryKnockdownTimer")] 
		public CFloat SecondaryKnockdownTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("playedImpactAnim")] 
		public CBool PlayedImpactAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("frictionForceApplied")] 
		public CBool FrictionForceApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("frictionForceAppliedLastFrame")] 
		public CBool FrictionForceAppliedLastFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("delayDamageFrame")] 
		public CBool DelayDamageFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public KnockdownEvents()
		{
			CachedPlayerVelocity = new();
			SecondaryKnockdownDir = new();
		}
	}
}
