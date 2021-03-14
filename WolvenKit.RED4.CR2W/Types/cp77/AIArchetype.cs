using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArchetype : CResource
	{
		private CHandle<AIbehaviorParameterizedBehavior> _behaviorDefinition;
		private CStatic<moveMovementParameters> _movementParameters;

		[Ordinal(1)] 
		[RED("behaviorDefinition")] 
		public CHandle<AIbehaviorParameterizedBehavior> BehaviorDefinition
		{
			get
			{
				if (_behaviorDefinition == null)
				{
					_behaviorDefinition = (CHandle<AIbehaviorParameterizedBehavior>) CR2WTypeManager.Create("handle:AIbehaviorParameterizedBehavior", "behaviorDefinition", cr2w, this);
				}
				return _behaviorDefinition;
			}
			set
			{
				if (_behaviorDefinition == value)
				{
					return;
				}
				_behaviorDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("movementParameters", 5)] 
		public CStatic<moveMovementParameters> MovementParameters
		{
			get
			{
				if (_movementParameters == null)
				{
					_movementParameters = (CStatic<moveMovementParameters>) CR2WTypeManager.Create("static:5,moveMovementParameters", "movementParameters", cr2w, this);
				}
				return _movementParameters;
			}
			set
			{
				if (_movementParameters == value)
				{
					return;
				}
				_movementParameters = value;
				PropertySet(this);
			}
		}

		public AIArchetype(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
