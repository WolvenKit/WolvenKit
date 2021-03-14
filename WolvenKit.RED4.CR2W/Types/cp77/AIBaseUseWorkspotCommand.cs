using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIBaseUseWorkspotCommand : AICommand
	{
		private CBool _moveToWorkspot;
		private CName _forceEntryAnimName;
		private CArray<workWorkEntryId> _workExcludedGestures;
		private workWorkEntryId _infiniteSequenceEntryId;
		private CBool _idleOnlyMode;
		private CBool _continueInCombat;
		private CEnum<moveMovementType> _movementType;

		[Ordinal(4)] 
		[RED("moveToWorkspot")] 
		public CBool MoveToWorkspot
		{
			get
			{
				if (_moveToWorkspot == null)
				{
					_moveToWorkspot = (CBool) CR2WTypeManager.Create("Bool", "moveToWorkspot", cr2w, this);
				}
				return _moveToWorkspot;
			}
			set
			{
				if (_moveToWorkspot == value)
				{
					return;
				}
				_moveToWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("forceEntryAnimName")] 
		public CName ForceEntryAnimName
		{
			get
			{
				if (_forceEntryAnimName == null)
				{
					_forceEntryAnimName = (CName) CR2WTypeManager.Create("CName", "forceEntryAnimName", cr2w, this);
				}
				return _forceEntryAnimName;
			}
			set
			{
				if (_forceEntryAnimName == value)
				{
					return;
				}
				_forceEntryAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("workExcludedGestures")] 
		public CArray<workWorkEntryId> WorkExcludedGestures
		{
			get
			{
				if (_workExcludedGestures == null)
				{
					_workExcludedGestures = (CArray<workWorkEntryId>) CR2WTypeManager.Create("array:workWorkEntryId", "workExcludedGestures", cr2w, this);
				}
				return _workExcludedGestures;
			}
			set
			{
				if (_workExcludedGestures == value)
				{
					return;
				}
				_workExcludedGestures = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("infiniteSequenceEntryId")] 
		public workWorkEntryId InfiniteSequenceEntryId
		{
			get
			{
				if (_infiniteSequenceEntryId == null)
				{
					_infiniteSequenceEntryId = (workWorkEntryId) CR2WTypeManager.Create("workWorkEntryId", "infiniteSequenceEntryId", cr2w, this);
				}
				return _infiniteSequenceEntryId;
			}
			set
			{
				if (_infiniteSequenceEntryId == value)
				{
					return;
				}
				_infiniteSequenceEntryId = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("idleOnlyMode")] 
		public CBool IdleOnlyMode
		{
			get
			{
				if (_idleOnlyMode == null)
				{
					_idleOnlyMode = (CBool) CR2WTypeManager.Create("Bool", "idleOnlyMode", cr2w, this);
				}
				return _idleOnlyMode;
			}
			set
			{
				if (_idleOnlyMode == value)
				{
					return;
				}
				_idleOnlyMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("continueInCombat")] 
		public CBool ContinueInCombat
		{
			get
			{
				if (_continueInCombat == null)
				{
					_continueInCombat = (CBool) CR2WTypeManager.Create("Bool", "continueInCombat", cr2w, this);
				}
				return _continueInCombat;
			}
			set
			{
				if (_continueInCombat == value)
				{
					return;
				}
				_continueInCombat = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
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

		public AIBaseUseWorkspotCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
