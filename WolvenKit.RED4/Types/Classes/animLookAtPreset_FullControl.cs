using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtPreset_FullControl : animLookAtPreset
	{
		[Ordinal(0)] 
		[RED("limits")] 
		public animLookAtLimits Limits
		{
			get => GetPropertyValue<animLookAtLimits>();
			set => SetPropertyValue<animLookAtLimits>(value);
		}

		[Ordinal(1)] 
		[RED("eyesSuppress")] 
		public CFloat EyesSuppress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("eyesMode")] 
		public CInt32 EyesMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("headSuppress")] 
		public CFloat HeadSuppress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("headMode")] 
		public CInt32 HeadMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("headSquareScale")] 
		public CFloat HeadSquareScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("chestSuppress")] 
		public CFloat ChestSuppress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("chestMode")] 
		public CInt32 ChestMode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("chestSquareScale")] 
		public CFloat ChestSquareScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animLookAtPreset_FullControl()
		{
			Limits = new() { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 360.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 180.000000F };
			HeadSuppress = 1.000000F;
			ChestSuppress = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
