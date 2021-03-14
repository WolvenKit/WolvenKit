using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Rect : CVariable
	{
		private CInt32 _left;
		private CInt32 _top;
		private CInt32 _right;
		private CInt32 _bottom;

		[Ordinal(0)] 
		[RED("left")] 
		public CInt32 Left
		{
			get
			{
				if (_left == null)
				{
					_left = (CInt32) CR2WTypeManager.Create("Int32", "left", cr2w, this);
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
		public CInt32 Top
		{
			get
			{
				if (_top == null)
				{
					_top = (CInt32) CR2WTypeManager.Create("Int32", "top", cr2w, this);
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
		public CInt32 Right
		{
			get
			{
				if (_right == null)
				{
					_right = (CInt32) CR2WTypeManager.Create("Int32", "right", cr2w, this);
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
		public CInt32 Bottom
		{
			get
			{
				if (_bottom == null)
				{
					_bottom = (CInt32) CR2WTypeManager.Create("Int32", "bottom", cr2w, this);
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

		public Rect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
