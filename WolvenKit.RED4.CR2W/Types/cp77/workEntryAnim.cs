using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workEntryAnim : workIEntry
	{
		private CName _animName;
		private CName _idleAnim;
		private CEnum<moveMovementType> _movementType;
		private CEnum<moveMovementOrientationType> _orientationType;
		private CBool _isSynchronized;
		private CName _slotName;
		private Transform _syncOffset;
		private CFloat _blendOutTime;

		[Ordinal(2)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("idleAnim")] 
		public CName IdleAnim
		{
			get
			{
				if (_idleAnim == null)
				{
					_idleAnim = (CName) CR2WTypeManager.Create("CName", "idleAnim", cr2w, this);
				}
				return _idleAnim;
			}
			set
			{
				if (_idleAnim == value)
				{
					return;
				}
				_idleAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("orientationType")] 
		public CEnum<moveMovementOrientationType> OrientationType
		{
			get
			{
				if (_orientationType == null)
				{
					_orientationType = (CEnum<moveMovementOrientationType>) CR2WTypeManager.Create("moveMovementOrientationType", "orientationType", cr2w, this);
				}
				return _orientationType;
			}
			set
			{
				if (_orientationType == value)
				{
					return;
				}
				_orientationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isSynchronized")] 
		public CBool IsSynchronized
		{
			get
			{
				if (_isSynchronized == null)
				{
					_isSynchronized = (CBool) CR2WTypeManager.Create("Bool", "isSynchronized", cr2w, this);
				}
				return _isSynchronized;
			}
			set
			{
				if (_isSynchronized == value)
				{
					return;
				}
				_isSynchronized = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("syncOffset")] 
		public Transform SyncOffset
		{
			get
			{
				if (_syncOffset == null)
				{
					_syncOffset = (Transform) CR2WTypeManager.Create("Transform", "syncOffset", cr2w, this);
				}
				return _syncOffset;
			}
			set
			{
				if (_syncOffset == value)
				{
					return;
				}
				_syncOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get
			{
				if (_blendOutTime == null)
				{
					_blendOutTime = (CFloat) CR2WTypeManager.Create("Float", "blendOutTime", cr2w, this);
				}
				return _blendOutTime;
			}
			set
			{
				if (_blendOutTime == value)
				{
					return;
				}
				_blendOutTime = value;
				PropertySet(this);
			}
		}

		public workEntryAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
