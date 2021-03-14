using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveComponentReplicatedState : netIComponentState
	{
		private Quaternion _rotation;
		private Vector3 _position;
		private Vector3 _linearVelocity;
		private CInt16 _teleportCount;
		private CBool _touchesGround;
		private CBool _touchesWalls;
		private CBool _physicalMove;
		private netTime _inputTimestamp;

		[Ordinal(2)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Vector3 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector3) CR2WTypeManager.Create("Vector3", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("linearVelocity")] 
		public Vector3 LinearVelocity
		{
			get
			{
				if (_linearVelocity == null)
				{
					_linearVelocity = (Vector3) CR2WTypeManager.Create("Vector3", "linearVelocity", cr2w, this);
				}
				return _linearVelocity;
			}
			set
			{
				if (_linearVelocity == value)
				{
					return;
				}
				_linearVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("teleportCount")] 
		public CInt16 TeleportCount
		{
			get
			{
				if (_teleportCount == null)
				{
					_teleportCount = (CInt16) CR2WTypeManager.Create("Int16", "teleportCount", cr2w, this);
				}
				return _teleportCount;
			}
			set
			{
				if (_teleportCount == value)
				{
					return;
				}
				_teleportCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("touchesGround")] 
		public CBool TouchesGround
		{
			get
			{
				if (_touchesGround == null)
				{
					_touchesGround = (CBool) CR2WTypeManager.Create("Bool", "touchesGround", cr2w, this);
				}
				return _touchesGround;
			}
			set
			{
				if (_touchesGround == value)
				{
					return;
				}
				_touchesGround = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("touchesWalls")] 
		public CBool TouchesWalls
		{
			get
			{
				if (_touchesWalls == null)
				{
					_touchesWalls = (CBool) CR2WTypeManager.Create("Bool", "touchesWalls", cr2w, this);
				}
				return _touchesWalls;
			}
			set
			{
				if (_touchesWalls == value)
				{
					return;
				}
				_touchesWalls = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("physicalMove")] 
		public CBool PhysicalMove
		{
			get
			{
				if (_physicalMove == null)
				{
					_physicalMove = (CBool) CR2WTypeManager.Create("Bool", "physicalMove", cr2w, this);
				}
				return _physicalMove;
			}
			set
			{
				if (_physicalMove == value)
				{
					return;
				}
				_physicalMove = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("inputTimestamp")] 
		public netTime InputTimestamp
		{
			get
			{
				if (_inputTimestamp == null)
				{
					_inputTimestamp = (netTime) CR2WTypeManager.Create("netTime", "inputTimestamp", cr2w, this);
				}
				return _inputTimestamp;
			}
			set
			{
				if (_inputTimestamp == value)
				{
					return;
				}
				_inputTimestamp = value;
				PropertySet(this);
			}
		}

		public moveComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
