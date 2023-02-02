using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsclothPhaseConfig : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stiffness")] 
		public CFloat Stiffness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("stiffnessMultiplier")] 
		public CFloat StiffnessMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("compressionLimit")] 
		public CFloat CompressionLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("stretchLimit")] 
		public CFloat StretchLimit
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public physicsclothPhaseConfig()
		{
			Stiffness = 1.000000F;
			StiffnessMultiplier = 1.000000F;
			CompressionLimit = 1.000000F;
			StretchLimit = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
