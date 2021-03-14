using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetPhysicalState : CVariable
	{
		private Vector4 _position;
		private CFloat _worldYaw;
		private Vector4 _velocity;
		private CBool _isOnGround;
		private Vector4 _groundNormal;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector4) CR2WTypeManager.Create("Vector4", "position", cr2w, this);
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

		[Ordinal(1)] 
		[RED("worldYaw")] 
		public CFloat WorldYaw
		{
			get
			{
				if (_worldYaw == null)
				{
					_worldYaw = (CFloat) CR2WTypeManager.Create("Float", "worldYaw", cr2w, this);
				}
				return _worldYaw;
			}
			set
			{
				if (_worldYaw == value)
				{
					return;
				}
				_worldYaw = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("velocity")] 
		public Vector4 Velocity
		{
			get
			{
				if (_velocity == null)
				{
					_velocity = (Vector4) CR2WTypeManager.Create("Vector4", "velocity", cr2w, this);
				}
				return _velocity;
			}
			set
			{
				if (_velocity == value)
				{
					return;
				}
				_velocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isOnGround")] 
		public CBool IsOnGround
		{
			get
			{
				if (_isOnGround == null)
				{
					_isOnGround = (CBool) CR2WTypeManager.Create("Bool", "isOnGround", cr2w, this);
				}
				return _isOnGround;
			}
			set
			{
				if (_isOnGround == value)
				{
					return;
				}
				_isOnGround = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("groundNormal")] 
		public Vector4 GroundNormal
		{
			get
			{
				if (_groundNormal == null)
				{
					_groundNormal = (Vector4) CR2WTypeManager.Create("Vector4", "groundNormal", cr2w, this);
				}
				return _groundNormal;
			}
			set
			{
				if (_groundNormal == value)
				{
					return;
				}
				_groundNormal = value;
				PropertySet(this);
			}
		}

		public gameMuppetPhysicalState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
