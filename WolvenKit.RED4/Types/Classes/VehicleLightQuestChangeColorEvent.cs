using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleLightQuestChangeColorEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("lightType")] 
		public CEnum<vehicleELightType> LightType
		{
			get => GetPropertyValue<CEnum<vehicleELightType>>();
			set => SetPropertyValue<CEnum<vehicleELightType>>(value);
		}

		[Ordinal(2)] 
		[RED("forceOverrideEmissiveColor")] 
		public CBool ForceOverrideEmissiveColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleLightQuestChangeColorEvent()
		{
			Color = new CColor();
			LightType = Enums.vehicleELightType.Default;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
