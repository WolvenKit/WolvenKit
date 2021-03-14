using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerMovement : animAnimFeature_Movement
	{
		private Vector4 _facingDirection;
		private CFloat _verticalSpeed;
		private CFloat _movementDirectionHorizontalAngle;
		private CBool _inAir;
		private CFloat _standingTerrainAngle;

		[Ordinal(9)] 
		[RED("facingDirection")] 
		public Vector4 FacingDirection
		{
			get
			{
				if (_facingDirection == null)
				{
					_facingDirection = (Vector4) CR2WTypeManager.Create("Vector4", "facingDirection", cr2w, this);
				}
				return _facingDirection;
			}
			set
			{
				if (_facingDirection == value)
				{
					return;
				}
				_facingDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("verticalSpeed")] 
		public CFloat VerticalSpeed
		{
			get
			{
				if (_verticalSpeed == null)
				{
					_verticalSpeed = (CFloat) CR2WTypeManager.Create("Float", "verticalSpeed", cr2w, this);
				}
				return _verticalSpeed;
			}
			set
			{
				if (_verticalSpeed == value)
				{
					return;
				}
				_verticalSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("movementDirectionHorizontalAngle")] 
		public CFloat MovementDirectionHorizontalAngle
		{
			get
			{
				if (_movementDirectionHorizontalAngle == null)
				{
					_movementDirectionHorizontalAngle = (CFloat) CR2WTypeManager.Create("Float", "movementDirectionHorizontalAngle", cr2w, this);
				}
				return _movementDirectionHorizontalAngle;
			}
			set
			{
				if (_movementDirectionHorizontalAngle == value)
				{
					return;
				}
				_movementDirectionHorizontalAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inAir")] 
		public CBool InAir
		{
			get
			{
				if (_inAir == null)
				{
					_inAir = (CBool) CR2WTypeManager.Create("Bool", "inAir", cr2w, this);
				}
				return _inAir;
			}
			set
			{
				if (_inAir == value)
				{
					return;
				}
				_inAir = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("standingTerrainAngle")] 
		public CFloat StandingTerrainAngle
		{
			get
			{
				if (_standingTerrainAngle == null)
				{
					_standingTerrainAngle = (CFloat) CR2WTypeManager.Create("Float", "standingTerrainAngle", cr2w, this);
				}
				return _standingTerrainAngle;
			}
			set
			{
				if (_standingTerrainAngle == value)
				{
					return;
				}
				_standingTerrainAngle = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_PlayerMovement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
