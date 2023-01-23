using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questVisionMode_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("visionModeType")] 
		public CEnum<questVisionModeType> VisionModeType
		{
			get => GetPropertyValue<CEnum<questVisionModeType>>();
			set => SetPropertyValue<CEnum<questVisionModeType>>(value);
		}

		public questVisionMode_ConditionType()
		{
			TimeInterval = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
