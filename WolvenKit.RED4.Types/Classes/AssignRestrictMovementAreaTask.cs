using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AssignRestrictMovementAreaTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("restrictMovementAreaRef")] 
		public CHandle<AIArgumentMapping> RestrictMovementAreaRef
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public AssignRestrictMovementAreaTask()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
