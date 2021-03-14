using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMatrix_ : CVariable
	{
		private Vector4 _x;
		private Vector4 _y;
		private Vector4 _z;
		private Vector4 _w;

		[Ordinal(0)] 
		[RED("X")] 
		public Vector4 X
		{
			get
			{
				if (_x == null)
				{
					_x = (Vector4) CR2WTypeManager.Create("Vector4", "X", cr2w, this);
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
		public Vector4 Y
		{
			get
			{
				if (_y == null)
				{
					_y = (Vector4) CR2WTypeManager.Create("Vector4", "Y", cr2w, this);
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
		public Vector4 Z
		{
			get
			{
				if (_z == null)
				{
					_z = (Vector4) CR2WTypeManager.Create("Vector4", "Z", cr2w, this);
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
		public Vector4 W
		{
			get
			{
				if (_w == null)
				{
					_w = (Vector4) CR2WTypeManager.Create("Vector4", "W", cr2w, this);
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

		public CMatrix_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
