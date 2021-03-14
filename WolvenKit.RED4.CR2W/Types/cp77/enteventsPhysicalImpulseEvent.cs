using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class enteventsPhysicalImpulseEvent : redEvent
	{
		private CUInt32 _bodyIndex;
		private Vector3 _worldImpulse;
		private Vector3 _worldPosition;
		private CFloat _radius;
		private CUInt32 _shapeIndex;

		[Ordinal(0)] 
		[RED("bodyIndex")] 
		public CUInt32 BodyIndex
		{
			get
			{
				if (_bodyIndex == null)
				{
					_bodyIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "bodyIndex", cr2w, this);
				}
				return _bodyIndex;
			}
			set
			{
				if (_bodyIndex == value)
				{
					return;
				}
				_bodyIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("worldImpulse")] 
		public Vector3 WorldImpulse
		{
			get
			{
				if (_worldImpulse == null)
				{
					_worldImpulse = (Vector3) CR2WTypeManager.Create("Vector3", "worldImpulse", cr2w, this);
				}
				return _worldImpulse;
			}
			set
			{
				if (_worldImpulse == value)
				{
					return;
				}
				_worldImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("worldPosition")] 
		public Vector3 WorldPosition
		{
			get
			{
				if (_worldPosition == null)
				{
					_worldPosition = (Vector3) CR2WTypeManager.Create("Vector3", "worldPosition", cr2w, this);
				}
				return _worldPosition;
			}
			set
			{
				if (_worldPosition == value)
				{
					return;
				}
				_worldPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("shapeIndex")] 
		public CUInt32 ShapeIndex
		{
			get
			{
				if (_shapeIndex == null)
				{
					_shapeIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "shapeIndex", cr2w, this);
				}
				return _shapeIndex;
			}
			set
			{
				if (_shapeIndex == value)
				{
					return;
				}
				_shapeIndex = value;
				PropertySet(this);
			}
		}

		public enteventsPhysicalImpulseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
