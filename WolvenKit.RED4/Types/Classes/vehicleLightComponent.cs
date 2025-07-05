using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleLightComponent : gameLightComponent
	{
		[Ordinal(77)] 
		[RED("allowSeparateEmissiveColor")] 
		public CBool AllowSeparateEmissiveColor
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(78)] 
		[RED("emissiveColor")] 
		public CColor EmissiveColor
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(79)] 
		[RED("lightType")] 
		public CEnum<vehicleELightType> LightType
		{
			get => GetPropertyValue<CEnum<vehicleELightType>>();
			set => SetPropertyValue<CEnum<vehicleELightType>>(value);
		}

		[Ordinal(80)] 
		[RED("highBeamPitchAngle")] 
		public CFloat HighBeamPitchAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(81)] 
		[RED("highBeamRadiusMultiplier")] 
		public CFloat HighBeamRadiusMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(82)] 
		[RED("highBeamConeMultiplier")] 
		public CFloat HighBeamConeMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public vehicleLightComponent()
		{
			EmissiveColor = new CColor();
			LightType = Enums.vehicleELightType.Head;
			HighBeamRadiusMultiplier = 2.000000F;
			HighBeamConeMultiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
