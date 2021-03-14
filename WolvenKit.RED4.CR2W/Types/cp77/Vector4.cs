using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Vector4 : CVariable
	{
		private CFloat _x;
		private CFloat _y;
		private CFloat _z;
		private CFloat _w;

		[Ordinal(0)] 
		[RED("X")] 
		public CFloat X
		{
			get
			{
				if (_x == null)
				{
					_x = (CFloat) CR2WTypeManager.Create("Float", "X", cr2w, this);
				}
				return _x;
			}
			set
			{
				if (_x == value)
				{
					return;
				}
				_x = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Y")] 
		public CFloat Y
		{
			get
			{
				if (_y == null)
				{
					_y = (CFloat) CR2WTypeManager.Create("Float", "Y", cr2w, this);
				}
				return _y;
			}
			set
			{
				if (_y == value)
				{
					return;
				}
				_y = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Z")] 
		public CFloat Z
		{
			get
			{
				if (_z == null)
				{
					_z = (CFloat) CR2WTypeManager.Create("Float", "Z", cr2w, this);
				}
				return _z;
			}
			set
			{
				if (_z == value)
				{
					return;
				}
				_z = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("W")] 
		public CFloat W
		{
			get
			{
				if (_w == null)
				{
					_w = (CFloat) CR2WTypeManager.Create("Float", "W", cr2w, this);
				}
				return _w;
			}
			set
			{
				if (_w == value)
				{
					return;
				}
				_w = value;
				PropertySet(this);
			}
		}

		public Vector4(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
