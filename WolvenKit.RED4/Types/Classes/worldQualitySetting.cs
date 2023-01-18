using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldQualitySetting : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("QualityLevel")] 
		public CEnum<ConfigGraphicsQualityLevel> QualityLevel
		{
			get => GetPropertyValue<CEnum<ConfigGraphicsQualityLevel>>();
			set => SetPropertyValue<CEnum<ConfigGraphicsQualityLevel>>(value);
		}

		[Ordinal(1)] 
		[RED("xEntitiesBudget")] 
		public CUInt32 XEntitiesBudget
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldQualitySetting()
		{
			QualityLevel = Enums.ConfigGraphicsQualityLevel.PlayStation4;
			XEntitiesBudget = 50;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
