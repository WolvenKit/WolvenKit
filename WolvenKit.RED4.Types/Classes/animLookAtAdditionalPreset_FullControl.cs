using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtAdditionalPreset_FullControl : animLookAtAdditionalPreset
	{
		[Ordinal(0)] 
		[RED("useRightHand")] 
		public CBool UseRightHand
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("attachHandToOtherOne")] 
		public CBool AttachHandToOtherOne
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("limits")] 
		public animLookAtLimits Limits
		{
			get => GetPropertyValue<animLookAtLimits>();
			set => SetPropertyValue<animLookAtLimits>(value);
		}

		[Ordinal(3)] 
		[RED("suppress")] 
		public CFloat Suppress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animLookAtAdditionalPreset_FullControl()
		{
			UseRightHand = true;
			Limits = new() { SoftLimitDegrees = 360.000000F, HardLimitDegrees = 360.000000F, HardLimitDistance = 1000000.000000F, BackLimitDegrees = 180.000000F };
			Suppress = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
