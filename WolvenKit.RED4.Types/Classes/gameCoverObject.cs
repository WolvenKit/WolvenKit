using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCoverObject : gameObject
	{
		[Ordinal(35)] 
		[RED("coverType")] 
		public CEnum<animCoverState> CoverType
		{
			get => GetPropertyValue<CEnum<animCoverState>>();
			set => SetPropertyValue<CEnum<animCoverState>>(value);
		}

		[Ordinal(36)] 
		[RED("slotRadius")] 
		public CFloat SlotRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("hpMax")] 
		public CFloat HpMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("isDestructible")] 
		public CBool IsDestructible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(39)] 
		[RED("fovDegrees")] 
		public CFloat FovDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(40)] 
		[RED("fovExposureDegrees")] 
		public CFloat FovExposureDegrees
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameCoverObject()
		{
			CoverType = Enums.animCoverState.LowCover;
			SlotRadius = 0.800000F;
			HpMax = 1000.000000F;
			IsDestructible = true;
			FovDegrees = 120.000000F;
			FovExposureDegrees = 160.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
