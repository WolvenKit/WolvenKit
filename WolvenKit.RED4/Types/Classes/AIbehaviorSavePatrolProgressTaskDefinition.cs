using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorSavePatrolProgressTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(2)] 
		[RED("saveOnDeactivation")] 
		public CBool SaveOnDeactivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("savedState")] 
		public CHandle<AIArgumentMapping> SavedState
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AIbehaviorSavePatrolProgressTaskDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
