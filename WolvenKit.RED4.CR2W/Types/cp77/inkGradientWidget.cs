using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGradientWidget : inkBaseShapeWidget
	{
		private CEnum<inkGradientMode> _gradientMode;
		private HDRColor _startColor;
		private HDRColor _endColor;
		private CFloat _angle;

		[Ordinal(20)] 
		[RED("gradientMode")] 
		public CEnum<inkGradientMode> GradientMode
		{
			get
			{
				if (_gradientMode == null)
				{
					_gradientMode = (CEnum<inkGradientMode>) CR2WTypeManager.Create("inkGradientMode", "gradientMode", cr2w, this);
				}
				return _gradientMode;
			}
			set
			{
				if (_gradientMode == value)
				{
					return;
				}
				_gradientMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("startColor")] 
		public HDRColor StartColor
		{
			get
			{
				if (_startColor == null)
				{
					_startColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "startColor", cr2w, this);
				}
				return _startColor;
			}
			set
			{
				if (_startColor == value)
				{
					return;
				}
				_startColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("endColor")] 
		public HDRColor EndColor
		{
			get
			{
				if (_endColor == null)
				{
					_endColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "endColor", cr2w, this);
				}
				return _endColor;
			}
			set
			{
				if (_endColor == value)
				{
					return;
				}
				_endColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("angle")] 
		public CFloat Angle
		{
			get
			{
				if (_angle == null)
				{
					_angle = (CFloat) CR2WTypeManager.Create("Float", "angle", cr2w, this);
				}
				return _angle;
			}
			set
			{
				if (_angle == value)
				{
					return;
				}
				_angle = value;
				PropertySet(this);
			}
		}

		public inkGradientWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
