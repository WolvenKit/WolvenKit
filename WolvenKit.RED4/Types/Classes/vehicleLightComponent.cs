using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleLightComponent : gameLightComponent
	{
		[Ordinal(71)] 
		[RED("allowSeparateEmissiveColor")] 
		public CBool AllowSeparateEmissiveColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(72)] 
		[RED("emissiveColor")] 
		public CColor EmissiveColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(73)] 
		[RED("lightType")] 
		public CEnum<vehicleELightType> LightType
		{
			get => GetPropertyValue<CEnum<vehicleELightType>>();
			set => SetPropertyValue<CEnum<vehicleELightType>>(value);
		}

		[Ordinal(74)] 
		[RED("highBeamPitchAngle")] 
		public CFloat HighBeamPitchAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(75)] 
		[RED("highBeamRadiusMultiplier")] 
		public CFloat HighBeamRadiusMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(76)] 
		[RED("highBeamConeMultiplier")] 
		public CFloat HighBeamConeMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleLightComponent()
		{
			EmissiveColor = new();
			LightType = Enums.vehicleELightType.Head;
			HighBeamRadiusMultiplier = 2.000000F;
			HighBeamConeMultiplier = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
