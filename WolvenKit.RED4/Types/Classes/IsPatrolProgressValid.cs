using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsPatrolProgressValid : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public IsPatrolProgressValid()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
