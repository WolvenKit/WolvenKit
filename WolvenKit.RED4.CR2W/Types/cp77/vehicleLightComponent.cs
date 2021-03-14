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
			get
			{
				if (_allowSeparateEmissiveColor == null)
				{
					_allowSeparateEmissiveColor = (CBool) CR2WTypeManager.Create("Bool", "allowSeparateEmissiveColor", cr2w, this);
				}
				return _allowSeparateEmissiveColor;
			}
			set
			{
				if (_allowSeparateEmissiveColor == value)
				{
					return;
				}
				_allowSeparateEmissiveColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(70)] 
		[RED("emissiveColor")] 
		public CColor EmissiveColor
		{
			get
			{
				if (_emissiveColor == null)
				{
					_emissiveColor = (CColor) CR2WTypeManager.Create("Color", "emissiveColor", cr2w, this);
				}
				return _emissiveColor;
			}
			set
			{
				if (_emissiveColor == value)
				{
					return;
				}
				_emissiveColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(71)] 
		[RED("lightType")] 
		public CEnum<vehicleELightType> LightType
		{
			get
			{
				if (_lightType == null)
				{
					_lightType = (CEnum<vehicleELightType>) CR2WTypeManager.Create("vehicleELightType", "lightType", cr2w, this);
				}
				return _lightType;
			}
			set
			{
				if (_lightType == value)
				{
					return;
				}
				_lightType = value;
				PropertySet(this);
			}
		}

		[Ordinal(72)] 
		[RED("highBeamPitchAngle")] 
		public CFloat HighBeamPitchAngle
		{
			get
			{
				if (_highBeamPitchAngle == null)
				{
					_highBeamPitchAngle = (CFloat) CR2WTypeManager.Create("Float", "highBeamPitchAngle", cr2w, this);
				}
				return _highBeamPitchAngle;
			}
			set
			{
				if (_highBeamPitchAngle == value)
				{
					return;
				}
				_highBeamPitchAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(73)] 
		[RED("highBeamRadiusMultiplier")] 
		public CFloat HighBeamRadiusMultiplier
		{
			get
			{
				if (_highBeamRadiusMultiplier == null)
				{
					_highBeamRadiusMultiplier = (CFloat) CR2WTypeManager.Create("Float", "highBeamRadiusMultiplier", cr2w, this);
				}
				return _highBeamRadiusMultiplier;
			}
			set
			{
				if (_highBeamRadiusMultiplier == value)
				{
					return;
				}
				_highBeamRadiusMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(74)] 
		[RED("highBeamConeMultiplier")] 
		public CFloat HighBeamConeMultiplier
		{
			get
			{
				if (_highBeamConeMultiplier == null)
				{
					_highBeamConeMultiplier = (CFloat) CR2WTypeManager.Create("Float", "highBeamConeMultiplier", cr2w, this);
				}
				return _highBeamConeMultiplier;
			}
			set
			{
				if (_highBeamConeMultiplier == value)
				{
					return;
				}
				_highBeamConeMultiplier = value;
				PropertySet(this);
			}
		}

		public vehicleLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
