using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMargin : CVariable
	{
		private CFloat _left;
		private CFloat _top;
		private CFloat _right;
		private CFloat _bottom;

		[Ordinal(0)] 
		[RED("left")] 
		public CFloat Left
		{
			get
			{
				if (_left == null)
				{
					_left = (CFloat) CR2WTypeManager.Create("Float", "left", cr2w, this);
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
		[RED("top")] 
		public CFloat Top
		{
			get
			{
				if (_top == null)
				{
					_top = (CFloat) CR2WTypeManager.Create("Float", "top", cr2w, this);
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
		[RED("right")] 
		public CFloat Right
		{
			get
			{
				if (_right == null)
				{
					_right = (CFloat) CR2WTypeManager.Create("Float", "right", cr2w, this);
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
		[RED("bottom")] 
		public CFloat Bottom
		{
			get
			{
				if (_bottom == null)
				{
					_bottom = (CFloat) CR2WTypeManager.Create("Float", "bottom", cr2w, this);
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

		public inkMargin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
