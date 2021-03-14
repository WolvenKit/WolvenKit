using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMaskEffect : inkIEffect
	{
		private CFloat _angle;
		private CFloat _opacity;
		private CBool _invert;

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("opacity")] 
		public CFloat Opacity
		{
			get
			{
				if (_opacity == null)
				{
					_opacity = (CFloat) CR2WTypeManager.Create("Float", "opacity", cr2w, this);
				}
				return _opacity;
			}
			set
			{
				if (_opacity == value)
				{
					return;
				}
				_opacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		public inkMaskEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
