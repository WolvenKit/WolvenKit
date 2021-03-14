using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficCollisionSphere : CVariable
	{
		private Vector3 _worldPos;
		private Vector3 _direction;
		private CFloat _radius;
		private CUInt64 _userData;
		private CUInt8 _flags;

		[Ordinal(0)] 
		[RED("worldPos")] 
		public Vector3 WorldPos
		{
			get
			{
				if (_worldPos == null)
				{
					_worldPos = (Vector3) CR2WTypeManager.Create("Vector3", "worldPos", cr2w, this);
				}
				return _worldPos;
			}
			set
			{
				if (_worldPos == value)
				{
					return;
				}
				_worldPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public Vector3 Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (Vector3) CR2WTypeManager.Create("Vector3", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get
			{
				if (_radius == null)
				{
					_radius = (CFloat) CR2WTypeManager.Create("Float", "radius", cr2w, this);
				}
				return _radius;
			}
			set
			{
				if (_radius == value)
				{
					return;
				}
				_radius = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("userData")] 
		public CUInt64 UserData
		{
			get
			{
				if (_userData == null)
				{
					_userData = (CUInt64) CR2WTypeManager.Create("Uint64", "userData", cr2w, this);
				}
				return _userData;
			}
			set
			{
				if (_userData == value)
				{
					return;
				}
				_userData = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt8) CR2WTypeManager.Create("Uint8", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public worldTrafficCollisionSphere(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
