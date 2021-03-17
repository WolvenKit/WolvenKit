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
			get => GetProperty(ref _behaviorDefinition);
			set => SetProperty(ref _behaviorDefinition, value);
		}

		[Ordinal(2)] 
		[RED("movementParameters", 5)] 
		public CStatic<moveMovementParameters> MovementParameters
		{
			get => GetProperty(ref _movementParameters);
			set => SetProperty(ref _movementParameters, value);
		}

		public AIArchetype(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
