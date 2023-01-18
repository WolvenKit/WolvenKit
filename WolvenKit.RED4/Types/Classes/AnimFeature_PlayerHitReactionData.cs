using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_PlayerHitReactionData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("hitDirection")] 
		public CFloat HitDirection
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("hitStrength")] 
		public CFloat HitStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("isMeleeHit")] 
		public CBool IsMeleeHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isLightMeleeHit")] 
		public CBool IsLightMeleeHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isStrongMeleeHit")] 
		public CBool IsStrongMeleeHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isQuickMeleeHit")] 
		public CBool IsQuickMeleeHit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isExplosion")] 
		public CBool IsExplosion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("isPressureWave")] 
		public CBool IsPressureWave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("meleeAttackDirection")] 
		public CInt32 MeleeAttackDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AnimFeature_PlayerHitReactionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
