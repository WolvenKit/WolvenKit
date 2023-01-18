using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIMoveToCoverCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] 
		[RED("coverNodeRef")] 
		public NodeRef CoverNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("specialAction")] 
		public CEnum<ECoverSpecialAction> SpecialAction
		{
			get => GetPropertyValue<CEnum<ECoverSpecialAction>>();
			set => SetPropertyValue<CEnum<ECoverSpecialAction>>(value);
		}

		public AIMoveToCoverCommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
