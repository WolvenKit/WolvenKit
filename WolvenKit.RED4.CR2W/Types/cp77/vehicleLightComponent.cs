using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleLightComponent : gameLightComponent
	{
		private CBool _allowSeparateEmissiveColor;
		private CColor _emissiveColor;
		private CEnum<vehicleELightType> _lightType;
		private CFloat _highBeamPitchAngle;
		private CFloat _highBeamRadiusMultiplier;
		private CFloat _highBeamConeMultiplier;

		[Ordinal(69)] 
		[RED("allowSeparateEmissiveColor")] 
		public CBool AllowSeparateEmissiveColor
		{
			get => GetProperty(ref _allowSeparateEmissiveColor);
			set => SetProperty(ref _allowSeparateEmissiveColor, value);
		}

		[Ordinal(70)] 
		[RED("emissiveColor")] 
		public CColor EmissiveColor
		{
			get => GetProperty(ref _emissiveColor);
			set => SetProperty(ref _emissiveColor, value);
		}

		[Ordinal(71)] 
		[RED("lightType")] 
		public CEnum<vehicleELightType> LightType
		{
			get => GetProperty(ref _lightType);
			set => SetProperty(ref _lightType, value);
		}

		[Ordinal(72)] 
		[RED("highBeamPitchAngle")] 
		public CFloat HighBeamPitchAngle
		{
			get => GetProperty(ref _highBeamPitchAngle);
			set => SetProperty(ref _highBeamPitchAngle, value);
		}

		[Ordinal(73)] 
		[RED("highBeamRadiusMultiplier")] 
		public CFloat HighBeamRadiusMultiplier
		{
			get => GetProperty(ref _highBeamRadiusMultiplier);
			set => SetProperty(ref _highBeamRadiusMultiplier, value);
		}

		[Ordinal(74)] 
		[RED("highBeamConeMultiplier")] 
		public CFloat HighBeamConeMultiplier
		{
			get => GetProperty(ref _highBeamConeMultiplier);
			set => SetProperty(ref _highBeamConeMultiplier, value);
		}

		public vehicleLightComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
