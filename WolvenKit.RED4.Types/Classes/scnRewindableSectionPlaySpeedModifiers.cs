using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRewindableSectionPlaySpeedModifiers : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("forwardVeryFast")] 
		public CFloat ForwardVeryFast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("forwardFast")] 
		public CFloat ForwardFast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("forwardSlow")] 
		public CFloat ForwardSlow
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("backwardVeryFast")] 
		public CFloat BackwardVeryFast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("backwardFast")] 
		public CFloat BackwardFast
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("backwardSlow")] 
		public CFloat BackwardSlow
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public scnRewindableSectionPlaySpeedModifiers()
		{
			ForwardVeryFast = 6.000000F;
			ForwardFast = 3.000000F;
			ForwardSlow = 0.500000F;
			BackwardVeryFast = 6.000000F;
			BackwardFast = 3.000000F;
			BackwardSlow = 0.500000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
