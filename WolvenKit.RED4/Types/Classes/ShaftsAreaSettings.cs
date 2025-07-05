using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShaftsAreaSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("shaftsLevelIndex")] 
		public CUInt32 ShaftsLevelIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("shaftsIntensity")] 
		public CFloat ShaftsIntensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("shaftsThresholdsScale")] 
		public CFloat ShaftsThresholdsScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ShaftsAreaSettings()
		{
			ShaftsLevelIndex = 1;
			ShaftsIntensity = 1.000000F;
			ShaftsThresholdsScale = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
