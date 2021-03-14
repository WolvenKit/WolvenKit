using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetMoveState : CVariable
	{
		private CFloat _desiredSpeed;
		private CBool _isJumping;
		private CBool _isFalling;
		private CBool _isDoubleJumped;
		private CEnum<gameMuppetMoveStyle> _moveStyle;
		private CUInt32 _jumpStartFrameId;
		private CUInt32 _landFrameId;

		[Ordinal(0)] 
		[RED("desiredSpeed")] 
		public CFloat DesiredSpeed
		{
			get
			{
				if (_desiredSpeed == null)
				{
					_desiredSpeed = (CFloat) CR2WTypeManager.Create("Float", "desiredSpeed", cr2w, this);
				}
				return _desiredSpeed;
			}
			set
			{
				if (_desiredSpeed == value)
				{
					return;
				}
				_desiredSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isJumping")] 
		public CBool IsJumping
		{
			get
			{
				if (_isJumping == null)
				{
					_isJumping = (CBool) CR2WTypeManager.Create("Bool", "isJumping", cr2w, this);
				}
				return _isJumping;
			}
			set
			{
				if (_isJumping == value)
				{
					return;
				}
				_isJumping = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isFalling")] 
		public CBool IsFalling
		{
			get
			{
				if (_isFalling == null)
				{
					_isFalling = (CBool) CR2WTypeManager.Create("Bool", "isFalling", cr2w, this);
				}
				return _isFalling;
			}
			set
			{
				if (_isFalling == value)
				{
					return;
				}
				_isFalling = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isDoubleJumped")] 
		public CBool IsDoubleJumped
		{
			get
			{
				if (_isDoubleJumped == null)
				{
					_isDoubleJumped = (CBool) CR2WTypeManager.Create("Bool", "isDoubleJumped", cr2w, this);
				}
				return _isDoubleJumped;
			}
			set
			{
				if (_isDoubleJumped == value)
				{
					return;
				}
				_isDoubleJumped = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("moveStyle")] 
		public CEnum<gameMuppetMoveStyle> MoveStyle
		{
			get
			{
				if (_moveStyle == null)
				{
					_moveStyle = (CEnum<gameMuppetMoveStyle>) CR2WTypeManager.Create("gameMuppetMoveStyle", "moveStyle", cr2w, this);
				}
				return _moveStyle;
			}
			set
			{
				if (_moveStyle == value)
				{
					return;
				}
				_moveStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("jumpStartFrameId")] 
		public CUInt32 JumpStartFrameId
		{
			get
			{
				if (_jumpStartFrameId == null)
				{
					_jumpStartFrameId = (CUInt32) CR2WTypeManager.Create("Uint32", "jumpStartFrameId", cr2w, this);
				}
				return _jumpStartFrameId;
			}
			set
			{
				if (_jumpStartFrameId == value)
				{
					return;
				}
				_jumpStartFrameId = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("landFrameId")] 
		public CUInt32 LandFrameId
		{
			get
			{
				if (_landFrameId == null)
				{
					_landFrameId = (CUInt32) CR2WTypeManager.Create("Uint32", "landFrameId", cr2w, this);
				}
				return _landFrameId;
			}
			set
			{
				if (_landFrameId == value)
				{
					return;
				}
				_landFrameId = value;
				PropertySet(this);
			}
		}

		public gameMuppetMoveState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
