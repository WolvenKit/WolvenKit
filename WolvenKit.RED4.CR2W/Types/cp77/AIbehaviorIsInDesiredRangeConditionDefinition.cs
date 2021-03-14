using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorIsInDesiredRangeConditionDefinition : AIbehaviorCompanionConditionDefinition
	{
		private CHandle<AIArgumentMapping> _desiredDistance;
		private CHandle<AIArgumentMapping> _deadZoneRadius;

		[Ordinal(3)] 
		[RED("desiredDistance")] 
		public CHandle<AIArgumentMapping> DesiredDistance
		{
			get
			{
				if (_desiredDistance == null)
				{
					_desiredDistance = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "desiredDistance", cr2w, this);
				}
				return _desiredDistance;
			}
			set
			{
				if (_desiredDistance == value)
				{
					return;
				}
				_desiredDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("deadZoneRadius")] 
		public CHandle<AIArgumentMapping> DeadZoneRadius
		{
			get
			{
				if (_deadZoneRadius == null)
				{
					_deadZoneRadius = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "deadZoneRadius", cr2w, this);
				}
				return _deadZoneRadius;
			}
			set
			{
				if (_deadZoneRadius == value)
				{
					return;
				}
				_deadZoneRadius = value;
				PropertySet(this);
			}
		}

		public AIbehaviorIsInDesiredRangeConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
