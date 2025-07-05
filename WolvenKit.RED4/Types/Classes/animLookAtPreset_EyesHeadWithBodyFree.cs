using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtPreset_EyesHeadWithBodyFree : animLookAtPreset
	{
		[Ordinal(0)] 
		[RED("suppressHeadAnimation")] 
		public CFloat SuppressHeadAnimation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("headMobility")] 
		public CFloat HeadMobility
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("suppressChestAnimation")] 
		public CFloat SuppressChestAnimation
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("chestMobility")] 
		public CFloat ChestMobility
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animLookAtPreset_EyesHeadWithBodyFree()
		{
			HeadMobility = 0.950000F;
			ChestMobility = 0.850000F;
			SoftLimitAngle = 360.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
