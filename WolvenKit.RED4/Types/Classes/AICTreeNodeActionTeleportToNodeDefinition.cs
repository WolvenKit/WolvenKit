using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeActionTeleportToNodeDefinition : AICTreeNodeActionDefinition
	{
		[Ordinal(1)] 
		[RED("nodeRef")] 
		public LibTreeDefNodeRef NodeRef
		{
			get => GetPropertyValue<LibTreeDefNodeRef>();
			set => SetPropertyValue<LibTreeDefNodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public LibTreeDefVector Offset
		{
			get => GetPropertyValue<LibTreeDefVector>();
			set => SetPropertyValue<LibTreeDefVector>(value);
		}

		[Ordinal(3)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AICTreeNodeActionTeleportToNodeDefinition()
		{
			NodeRef = new LibTreeDefNodeRef();
			Offset = new LibTreeDefVector();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
