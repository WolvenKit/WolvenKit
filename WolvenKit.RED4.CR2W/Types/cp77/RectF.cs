using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RectF : CVariable
	{
		private CFloat _left;
		private CFloat _top;
		private CFloat _right;
		private CFloat _bottom;

		[Ordinal(0)] 
		[RED("Left")] 
		public CFloat Left
		{
			get
			{
				if (_left == null)
				{
					_left = (CFloat) CR2WTypeManager.Create("Float", "Left", cr2w, this);
				}
				return _left;
			}
			set
			{
				if (_left == value)
				{
					return;
				}
				_left = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Top")] 
		public CFloat Top
		{
			get
			{
				if (_top == null)
				{
					_top = (CFloat) CR2WTypeManager.Create("Float", "Top", cr2w, this);
				}
				return _top;
			}
			set
			{
				if (_top == value)
				{
					return;
				}
				_top = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Right")] 
		public CFloat Right
		{
			get
			{
				if (_right == null)
				{
					_right = (CFloat) CR2WTypeManager.Create("Float", "Right", cr2w, this);
				}
				return _right;
			}
			set
			{
				if (_right == value)
				{
					return;
				}
				_right = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Bottom")] 
		public CFloat Bottom
		{
			get
			{
				if (_bottom == null)
				{
					_bottom = (CFloat) CR2WTypeManager.Create("Float", "Bottom", cr2w, this);
				}
				return _bottom;
			}
			set
			{
				if (_bottom == value)
				{
					return;
				}
				_bottom = value;
				PropertySet(this);
			}
		}

		public RectF(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
