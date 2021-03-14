using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimVariableVector : animAnimVariable
	{
		private CFloat _x;
		private CFloat _y;
		private CFloat _z;
		private CFloat _w;
		private Vector4 _default;
		private Vector4 _min;
		private Vector4 _max;

		[Ordinal(2)] 
		[RED("x")] 
		public CFloat X
		{
			get
			{
				if (_x == null)
				{
					_x = (CFloat) CR2WTypeManager.Create("Float", "x", cr2w, this);
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

		[Ordinal(3)] 
		[RED("y")] 
		public CFloat Y
		{
			get
			{
				if (_y == null)
				{
					_y = (CFloat) CR2WTypeManager.Create("Float", "y", cr2w, this);
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

		[Ordinal(4)] 
		[RED("z")] 
		public CFloat Z
		{
			get
			{
				if (_z == null)
				{
					_z = (CFloat) CR2WTypeManager.Create("Float", "z", cr2w, this);
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

		[Ordinal(5)] 
		[RED("w")] 
		public CFloat W
		{
			get
			{
				if (_w == null)
				{
					_w = (CFloat) CR2WTypeManager.Create("Float", "w", cr2w, this);
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

		[Ordinal(6)] 
		[RED("default")] 
		public Vector4 Default
		{
			get
			{
				if (_default == null)
				{
					_default = (Vector4) CR2WTypeManager.Create("Vector4", "default", cr2w, this);
				}
				return _default;
			}
			set
			{
				if (_default == value)
				{
					return;
				}
				_default = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("min")] 
		public Vector4 Min
		{
			get
			{
				if (_min == null)
				{
					_min = (Vector4) CR2WTypeManager.Create("Vector4", "min", cr2w, this);
				}
				return _min;
			}
			set
			{
				if (_min == value)
				{
					return;
				}
				_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("max")] 
		public Vector4 Max
		{
			get
			{
				if (_max == null)
				{
					_max = (Vector4) CR2WTypeManager.Create("Vector4", "max", cr2w, this);
				}
				return _max;
			}
			set
			{
				if (_max == value)
				{
					return;
				}
				_max = value;
				PropertySet(this);
			}
		}

		public animAnimVariableVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
