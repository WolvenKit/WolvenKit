using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionDynamicMoveToDefinition : AICTreeNodeActionDefinition
	{
		private CEnum<moveMovementType> _moveType;
		private CFloat _tolerance;
		private CName _target;
		private CBool _keepDistance;

		[Ordinal(1)] 
		[RED("moveType")] 
		public CEnum<moveMovementType> MoveType
		{
			get
			{
				if (_moveType == null)
				{
					_moveType = (CEnum<moveMovementType>) CR2WTypeManager.Create("moveMovementType", "moveType", cr2w, this);
				}
				return _moveType;
			}
			set
			{
				if (_moveType == value)
				{
					return;
				}
				_moveType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tolerance")] 
		public CFloat Tolerance
		{
			get
			{
				if (_tolerance == null)
				{
					_tolerance = (CFloat) CR2WTypeManager.Create("Float", "tolerance", cr2w, this);
				}
				return _tolerance;
			}
			set
			{
				if (_tolerance == value)
				{
					return;
				}
				_tolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("target")] 
		public CName Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CName) CR2WTypeManager.Create("CName", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("keepDistance")] 
		public CBool KeepDistance
		{
			get
			{
				if (_keepDistance == null)
				{
					_keepDistance = (CBool) CR2WTypeManager.Create("Bool", "keepDistance", cr2w, this);
				}
				return _keepDistance;
			}
			set
			{
				if (_keepDistance == value)
				{
					return;
				}
				_keepDistance = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeActionDynamicMoveToDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
