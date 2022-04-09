using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeCompleteImmediatelyDefinition : AICTreeNodeAtomicDefinition
	{
		[Ordinal(0)] 
		[RED("completeWithSuccess")] 
		public CBool CompleteWithSuccess
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AICTreeNodeCompleteImmediatelyDefinition()
		{
			CompleteWithSuccess = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
