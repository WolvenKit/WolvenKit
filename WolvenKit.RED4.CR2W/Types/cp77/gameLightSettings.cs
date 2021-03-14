using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLightSettings : CVariable
	{
		private CFloat _strength;
		private CFloat _intensity;
		private CFloat _radius;
		private CColor _color;
		private CFloat _innerAngle;
		private CFloat _outerAngle;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		public gameLightSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
