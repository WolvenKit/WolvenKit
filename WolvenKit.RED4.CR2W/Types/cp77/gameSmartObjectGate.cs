using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectGate : CVariable
	{
		private CName _animationName;
		private CEnum<moveMovementType> _movementType;
		private CEnum<moveMovementOrientationType> _movementOrientationType;

		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get
			{
				if (_animationName == null)
				{
					_animationName = (CName) CR2WTypeManager.Create("CName", "animationName", cr2w, this);
				}
				return _animationName;
			}
			set
			{
				if (_animationName == value)
				{
					return;
				}
				_animationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CEnum<moveMovementType>) CR2WTypeManager.Create("moveMovementType", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("movementOrientationType")] 
		public CEnum<moveMovementOrientationType> MovementOrientationType
		{
			get
			{
				if (_movementOrientationType == null)
				{
					_movementOrientationType = (CEnum<moveMovementOrientationType>) CR2WTypeManager.Create("moveMovementOrientationType", "movementOrientationType", cr2w, this);
				}
				return _movementOrientationType;
			}
			set
			{
				if (_movementOrientationType == value)
				{
					return;
				}
				_movementOrientationType = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectGate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
