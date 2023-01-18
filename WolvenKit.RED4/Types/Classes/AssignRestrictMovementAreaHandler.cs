using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AssignRestrictMovementAreaHandler : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("inCommand")] 
		public CHandle<AIArgumentMapping> InCommand
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("resultOnNoChange")] 
		public CEnum<AIbehaviorCompletionStatus> ResultOnNoChange
		{
			get => GetPropertyValue<CEnum<AIbehaviorCompletionStatus>>();
			set => SetPropertyValue<CEnum<AIbehaviorCompletionStatus>>(value);
		}

		public AssignRestrictMovementAreaHandler()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
