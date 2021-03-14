using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldPosition : CVariable
	{
		private FixedPoint _x;
		private FixedPoint _y;
		private FixedPoint _z;

		[Ordinal(0)] 
		[RED("x")] 
		public FixedPoint X
		{
			get
			{
				if (_x == null)
				{
					_x = (FixedPoint) CR2WTypeManager.Create("FixedPoint", "x", cr2w, this);
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
		[RED("y")] 
		public FixedPoint Y
		{
			get
			{
				if (_y == null)
				{
					_y = (FixedPoint) CR2WTypeManager.Create("FixedPoint", "y", cr2w, this);
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
		[RED("z")] 
		public FixedPoint Z
		{
			get
			{
				if (_z == null)
				{
					_z = (FixedPoint) CR2WTypeManager.Create("FixedPoint", "z", cr2w, this);
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

		public WorldPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
