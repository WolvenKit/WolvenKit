using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIPatrolPathParameters : IScriptable
	{
		private NodeRef _path;
		private CEnum<moveMovementType> _movementType;
		private CBool _enterClosest;
		private CBool _patrolWithWeapon;
		private CBool _isBackAndForth;
		private CBool _isInfinite;
		private CUInt32 _numberOfLoops;
		private CBool _sortPatrolPoints;
		private TweakDBID _patrolAction;

		[Ordinal(0)] 
		[RED("path")] 
		public NodeRef Path
		{
			get
			{
				if (_path == null)
				{
					_path = (NodeRef) CR2WTypeManager.Create("NodeRef", "path", cr2w, this);
				}
				return _path;
			}
			set
			{
				if (_path == value)
				{
					return;
				}
				_path = value;
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
		[RED("enterClosest")] 
		public CBool EnterClosest
		{
			get
			{
				if (_enterClosest == null)
				{
					_enterClosest = (CBool) CR2WTypeManager.Create("Bool", "enterClosest", cr2w, this);
				}
				return _enterClosest;
			}
			set
			{
				if (_enterClosest == value)
				{
					return;
				}
				_enterClosest = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("patrolWithWeapon")] 
		public CBool PatrolWithWeapon
		{
			get
			{
				if (_patrolWithWeapon == null)
				{
					_patrolWithWeapon = (CBool) CR2WTypeManager.Create("Bool", "patrolWithWeapon", cr2w, this);
				}
				return _patrolWithWeapon;
			}
			set
			{
				if (_patrolWithWeapon == value)
				{
					return;
				}
				_patrolWithWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isBackAndForth")] 
		public CBool IsBackAndForth
		{
			get
			{
				if (_isBackAndForth == null)
				{
					_isBackAndForth = (CBool) CR2WTypeManager.Create("Bool", "isBackAndForth", cr2w, this);
				}
				return _isBackAndForth;
			}
			set
			{
				if (_isBackAndForth == value)
				{
					return;
				}
				_isBackAndForth = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isInfinite")] 
		public CBool IsInfinite
		{
			get
			{
				if (_isInfinite == null)
				{
					_isInfinite = (CBool) CR2WTypeManager.Create("Bool", "isInfinite", cr2w, this);
				}
				return _isInfinite;
			}
			set
			{
				if (_isInfinite == value)
				{
					return;
				}
				_isInfinite = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("numberOfLoops")] 
		public CUInt32 NumberOfLoops
		{
			get
			{
				if (_numberOfLoops == null)
				{
					_numberOfLoops = (CUInt32) CR2WTypeManager.Create("Uint32", "numberOfLoops", cr2w, this);
				}
				return _numberOfLoops;
			}
			set
			{
				if (_numberOfLoops == value)
				{
					return;
				}
				_numberOfLoops = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("sortPatrolPoints")] 
		public CBool SortPatrolPoints
		{
			get
			{
				if (_sortPatrolPoints == null)
				{
					_sortPatrolPoints = (CBool) CR2WTypeManager.Create("Bool", "sortPatrolPoints", cr2w, this);
				}
				return _sortPatrolPoints;
			}
			set
			{
				if (_sortPatrolPoints == value)
				{
					return;
				}
				_sortPatrolPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("patrolAction")] 
		public TweakDBID PatrolAction
		{
			get
			{
				if (_patrolAction == null)
				{
					_patrolAction = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "patrolAction", cr2w, this);
				}
				return _patrolAction;
			}
			set
			{
				if (_patrolAction == value)
				{
					return;
				}
				_patrolAction = value;
				PropertySet(this);
			}
		}

		public AIPatrolPathParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
