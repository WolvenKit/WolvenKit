using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToState : gameActionReplicatedState
	{
		private Vector3 _targetPos;
		private CFloat _toleranceRadius;
		private CBool _rotateEntity;
		private CUInt32 _moveStyle;

		[Ordinal(5)] 
		[RED("targetPos")] 
		public Vector3 TargetPos
		{
			get
			{
				if (_targetPos == null)
				{
					_targetPos = (Vector3) CR2WTypeManager.Create("Vector3", "targetPos", cr2w, this);
				}
				return _targetPos;
			}
			set
			{
				if (_targetPos == value)
				{
					return;
				}
				_targetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("toleranceRadius")] 
		public CFloat ToleranceRadius
		{
			get
			{
				if (_toleranceRadius == null)
				{
					_toleranceRadius = (CFloat) CR2WTypeManager.Create("Float", "toleranceRadius", cr2w, this);
				}
				return _toleranceRadius;
			}
			set
			{
				if (_toleranceRadius == value)
				{
					return;
				}
				_toleranceRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("rotateEntity")] 
		public CBool RotateEntity
		{
			get
			{
				if (_rotateEntity == null)
				{
					_rotateEntity = (CBool) CR2WTypeManager.Create("Bool", "rotateEntity", cr2w, this);
				}
				return _rotateEntity;
			}
			set
			{
				if (_rotateEntity == value)
				{
					return;
				}
				_rotateEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("moveStyle")] 
		public CUInt32 MoveStyle
		{
			get
			{
				if (_moveStyle == null)
				{
					_moveStyle = (CUInt32) CR2WTypeManager.Create("Uint32", "moveStyle", cr2w, this);
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

		public gameActionMoveToState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
