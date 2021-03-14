using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EditableGameLightSettings : CVariable
	{
		private CName _componentName;
		private CFloat _strength;
		private CBool _modifyStrength;
		private CFloat _intensity;
		private CBool _modifyIntensity;
		private CFloat _radius;
		private CBool _modifyRadius;
		private CColor _color;
		private CBool _modifyColor;
		private CFloat _innerAngle;
		private CBool _modifyInnerAngle;
		private CFloat _outerAngle;
		private CBool _modifyOuterAngle;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get
			{
				if (_strength == null)
				{
					_strength = (CFloat) CR2WTypeManager.Create("Float", "strength", cr2w, this);
				}
				return _strength;
			}
			set
			{
				if (_strength == value)
				{
					return;
				}
				_strength = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("modifyStrength")] 
		public CBool ModifyStrength
		{
			get
			{
				if (_modifyStrength == null)
				{
					_modifyStrength = (CBool) CR2WTypeManager.Create("Bool", "modifyStrength", cr2w, this);
				}
				return _modifyStrength;
			}
			set
			{
				if (_modifyStrength == value)
				{
					return;
				}
				_modifyStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("intensity")] 
		public CFloat Intensity
		{
			get
			{
				if (_intensity == null)
				{
					_intensity = (CFloat) CR2WTypeManager.Create("Float", "intensity", cr2w, this);
				}
				return _intensity;
			}
			set
			{
				if (_intensity == value)
				{
					return;
				}
				_intensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("modifyIntensity")] 
		public CBool ModifyIntensity
		{
			get
			{
				if (_modifyIntensity == null)
				{
					_modifyIntensity = (CBool) CR2WTypeManager.Create("Bool", "modifyIntensity", cr2w, this);
				}
				return _modifyIntensity;
			}
			set
			{
				if (_modifyIntensity == value)
				{
					return;
				}
				_modifyIntensity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("modifyRadius")] 
		public CBool ModifyRadius
		{
			get
			{
				if (_modifyRadius == null)
				{
					_modifyRadius = (CBool) CR2WTypeManager.Create("Bool", "modifyRadius", cr2w, this);
				}
				return _modifyRadius;
			}
			set
			{
				if (_modifyRadius == value)
				{
					return;
				}
				_modifyRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("color")] 
		public CColor Color
		{
			get
			{
				if (_color == null)
				{
					_color = (CColor) CR2WTypeManager.Create("Color", "color", cr2w, this);
				}
				return _color;
			}
			set
			{
				if (_color == value)
				{
					return;
				}
				_color = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("modifyColor")] 
		public CBool ModifyColor
		{
			get
			{
				if (_modifyColor == null)
				{
					_modifyColor = (CBool) CR2WTypeManager.Create("Bool", "modifyColor", cr2w, this);
				}
				return _modifyColor;
			}
			set
			{
				if (_modifyColor == value)
				{
					return;
				}
				_modifyColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("innerAngle")] 
		public CFloat InnerAngle
		{
			get
			{
				if (_innerAngle == null)
				{
					_innerAngle = (CFloat) CR2WTypeManager.Create("Float", "innerAngle", cr2w, this);
				}
				return _innerAngle;
			}
			set
			{
				if (_innerAngle == value)
				{
					return;
				}
				_innerAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("modifyInnerAngle")] 
		public CBool ModifyInnerAngle
		{
			get
			{
				if (_modifyInnerAngle == null)
				{
					_modifyInnerAngle = (CBool) CR2WTypeManager.Create("Bool", "modifyInnerAngle", cr2w, this);
				}
				return _modifyInnerAngle;
			}
			set
			{
				if (_modifyInnerAngle == value)
				{
					return;
				}
				_modifyInnerAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("outerAngle")] 
		public CFloat OuterAngle
		{
			get
			{
				if (_outerAngle == null)
				{
					_outerAngle = (CFloat) CR2WTypeManager.Create("Float", "outerAngle", cr2w, this);
				}
				return _outerAngle;
			}
			set
			{
				if (_outerAngle == value)
				{
					return;
				}
				_outerAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("modifyOuterAngle")] 
		public CBool ModifyOuterAngle
		{
			get
			{
				if (_modifyOuterAngle == null)
				{
					_modifyOuterAngle = (CBool) CR2WTypeManager.Create("Bool", "modifyOuterAngle", cr2w, this);
				}
				return _modifyOuterAngle;
			}
			set
			{
				if (_modifyOuterAngle == value)
				{
					return;
				}
				_modifyOuterAngle = value;
				PropertySet(this);
			}
		}

		public EditableGameLightSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
