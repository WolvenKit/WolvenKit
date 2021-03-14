using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkScanlineWipeEffect : inkIEffect
	{
		private CFloat _angle;
		private CFloat _transition;
		private CFloat _width;

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
		[RED("transition")] 
		public CFloat Transition
		{
			get
			{
				if (_transition == null)
				{
					_transition = (CFloat) CR2WTypeManager.Create("Float", "transition", cr2w, this);
				}
				return _transition;
			}
			set
			{
				if (_transition == value)
				{
					return;
				}
				_transition = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("width")] 
		public CFloat Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CFloat) CR2WTypeManager.Create("Float", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		public inkScanlineWipeEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
